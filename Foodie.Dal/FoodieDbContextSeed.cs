using Foodie.Dal.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foodie.Dal
{
    public partial class FoodieDbContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RecipeEntityConfiguration());            
          
        }
    }
}
