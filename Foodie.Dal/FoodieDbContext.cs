using Foodie.Dal.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Foodie.Dal
{
    public partial class FoodieDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public FoodieDbContext(DbContextOptions<FoodieDbContext> options) : base(options)
        {
        }

        protected FoodieDbContext()
        {
        }


        public DbSet<Recipe> Recipes { get; set; }

        /// <summary>
        /// Kapcsoló tábla a több-több kapcsolathoz
        /// </summary>
        public DbSet<UserRecipe> UserRecipes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<UserRecipe>()
                .HasKey(ur => new { ur.RecipeId, ur.UserId });


            modelBuilder.Entity<UserRecipe>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.FavouriteRecipes)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRecipe>()
                 .HasOne(ur => ur.Recipe)
                .WithMany(r => r.Users)
                .HasForeignKey(ur => ur.RecipeId);


            modelBuilder.Entity<Rating>()
                .HasKey(ra => new { ra.RecipeId, ra.UserId });

            modelBuilder.Entity<Rating>()
                .HasOne(re => re.Recipe)
                .WithMany(ra => ra.Ratings)
                .HasForeignKey(re => re.RecipeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Rating>()
                .HasOne(us => us.User)
                .WithMany(re => re.Ratings)
                .HasForeignKey(us => us.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Recipe>()
                .OwnsMany(r => r.Ingredients);

            var splitStringConverter = new ValueConverter<ICollection<string>, string>(v => string.Join(";", v), v => v.Split(new[] { ';' }));
            modelBuilder.Entity<Recipe>().Property(nameof(Recipe.Instruction)).HasConversion(splitStringConverter);


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
