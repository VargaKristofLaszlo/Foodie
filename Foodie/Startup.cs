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
using Foodie.BL.LogicImplementations;
using Foodie.BL.ServiceInterfaces;
using Refit;
using Foodie.Web.IApi;

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

            services.AddIdentity<User, IdentityRole<int>>()
               .AddEntityFrameworkStores<FoodieDbContext>()
               .AddDefaultTokenProviders();

            services.AddScoped<IRoleSeedService, RoleSeedService>()
                    .AddScoped<IUserSeedService, UserSeedService>()
                    .AddScoped<IRecipeService, RecipeService>();

            services.AddScoped<IRecipeLogic, RecipeLogic>();

            services.AddAuthentication();
            services.AddAuthorization();

            services.AddSingleton(sp => new MapperConfiguration(config =>
            {
                config.AddProfile(new IngredientProfile());
                config.AddProfile(new RecipeProfile());
            }).CreateMapper());


            services.AddRefitClient<IRecipeApi>()
                    .ConfigureHttpClient(c => c.BaseAddress = new System.Uri("https://localhost:44394/api/Recipe"));



            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.IdleTimeout = System.TimeSpan.FromMinutes(5);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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



            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });
        }
    }
}
