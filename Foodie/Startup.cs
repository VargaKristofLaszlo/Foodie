using Foodie.Dal;
using Foodie.Dal.Entities;
using Foodie.Dal.SeedInterfaces;
using Foodie.Dal.SeedService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper;
using Foodie.Dal.MapperProfiles;
using Foodie.Dal.ServiceImplementation;
using Foodie.Dal.ServiceInterfaces;
using Refit;
using Foodie.Web.IApi;
using Microsoft.AspNetCore.Identity.UI.Services;
using Foodie.Web.Helpers;
using Hellang.Middleware.ProblemDetails;
using System;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using Hangfire;
using Hangfire.SqlServer;
using Hangfire.Common;
using System.Linq;
using System.Text.Encodings.Web;
using Microsoft.OpenApi.Models;
using Foodie.Dal.Exceptions;
using Foodie.BL.Interfaces;
using Foodie.BL.Implementations;

namespace Foodie
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<FoodieDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString(nameof(FoodieDbContext)));
            });




            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Foodie Api",
                        Description = "Webportálok nevû tárgyra készített házim Api-ja.",
                        Version = "v1.0"
                    });
                options.EnableAnnotations();
            });





            // Add Hangfire services.
            services.AddHangfire(configuration => configuration
                .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseRecommendedSerializerSettings()
                .UseSqlServerStorage(Configuration.GetConnectionString("HangfireConnection"), new SqlServerStorageOptions
                {
                    CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                    SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                    QueuePollInterval = TimeSpan.Zero,
                    UseRecommendedIsolationLevel = true,
                    DisableGlobalLocks = true
                }));

            // Add the processing server as IHostedService
            services.AddHangfireServer();

            services.AddIdentity<User, IdentityRole<int>>()
               .AddEntityFrameworkStores<FoodieDbContext>()
               .AddDefaultTokenProviders();

            services.AddScoped<IRoleSeedService, RoleSeedService>()
                    .AddScoped<IUserSeedService, UserSeedService>()
                    .AddScoped<IRecipeService, RecipeService>();


            services.AddTransient<IEmailSender, EmailSender>();
            services.AddScoped(sp =>
            {
                return new AuthMessageSenderOptions()
                {
                    SendGridKey = Configuration["SendGridKey"],
                    SendGridUser = Configuration["SendGridUser"]
                };
            });

            services.AddScoped<IRecipeLogic, RecipeLogic>();

            services.AddAuthentication();
            services.AddAuthorization();

            services.AddSingleton(sp => new MapperConfiguration(config =>
            {
                config.AddProfile(new IngredientProfile());
                config.AddProfile(new RecipeProfile());
                config.AddProfile(new RatingProfile());
            }).CreateMapper());



            services.AddRefitClient<IRecipeApi>()
                  .ConfigureHttpClient(c => c.BaseAddress = new System.Uri("https://localhost:44394/api/Recipe"));
            // .ConfigureHttpClient(c => c.BaseAddress = new System.Uri("https://localhost:5001/api/Recipe"));

            services.AddProblemDetails(opt =>
            {
                opt.IncludeExceptionDetails = (context, ex) =>
                {
                    var environment = context.RequestServices.GetRequiredService<IHostEnvironment>();

                    return environment.IsDevelopment();
                };
                // This will map NotImplementedException to the 501 Not Implemented status code.
                opt.MapToStatusCode<NotImplementedException>(StatusCodes.Status501NotImplemented);

                //Mapping my custom exceptions to status codes
                opt.MapToStatusCode<NotFoundException>(StatusCodes.Status404NotFound);
                opt.MapToStatusCode<UnAuthorizedUserException>(StatusCodes.Status401Unauthorized);
                opt.MapToStatusCode<BannedUserException>(StatusCodes.Status403Forbidden);
                opt.MapToStatusCode<NotConfirmedAccountException>(StatusCodes.Status422UnprocessableEntity);
                opt.MapToStatusCode<BadRequestException>(StatusCodes.Status400BadRequest);

                // This will map HttpRequestException to the 503 Service Unavailable status code.
                opt.MapToStatusCode<HttpRequestException>(StatusCodes.Status503ServiceUnavailable);

                // Because exceptions are handled polymorphically, this will act as a "catch all" mapping, which is why it's added last.
                // If an exception other than NotImplementedException and HttpRequestException is thrown, this will handle it.
                opt.MapToStatusCode<Exception>(StatusCodes.Status500InternalServerError);
            });

            services.AddLogging();

            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.IdleTimeout = System.TimeSpan.FromMinutes(5);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddAuthentication()
              .AddGoogle(options =>
              {
                  IConfigurationSection googleAuthNSection =
                      Configuration.GetSection("Authentication:Google");

                  options.ClientId = googleAuthNSection["ClientId"];
                  options.ClientSecret = googleAuthNSection["ClientSecret"];
              });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, FoodieDbContext context, IEmailSender emailSender, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "StrategyGame Web API V1");
            });

            app.UseHangfireDashboard();

            var manager = new RecurringJobManager();
            manager.AddOrUpdate("SendRecipe", Job.FromExpression(() => new DailyRecipes(context, emailSender).SendRecipes()), Cron.Daily());


            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();

            app.UseProblemDetails();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapHangfireDashboard();
            });
        }
    }

    public class DailyRecipes
    {
        private readonly FoodieDbContext context;
        private readonly IEmailSender emailSender;
        private readonly Random random;

        public DailyRecipes(FoodieDbContext context, IEmailSender emailSender)
        {
            this.context = context;
            this.emailSender = emailSender;
            this.random = new Random();
        }

        public async System.Threading.Tasks.Task SendRecipes()
        {
            if (context.Recipes.Count() > 0)
            {
                int rndIndex = random.Next(0, context.Recipes.Count());

                string callbackUrl = "https://localhost:5001/Recipe?id=";
                var recipes = await context.Recipes.ToListAsync();
                callbackUrl += recipes.ElementAt(rndIndex).Id.ToString();

                foreach (var user in await context.Users.Where(user => user.Subscribed).ToListAsync())
                {
                    await emailSender.SendEmailAsync(user.Email, "Your dailys recipe",
                            $"To get your dailys recipe <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>click here</a>.");


                }
            }
        }
    }
}
