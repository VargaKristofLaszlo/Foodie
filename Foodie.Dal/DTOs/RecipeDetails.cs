using Foodie.Dal.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Foodie.Dal.DTOs
{
    public class RecipeDetails
    {
        public int Id { get; set; }
      
        public Category Category { get; set; }
       
        public TimeSpan PreparationTime { get; set; }

        public TimeSpan CookingTime { get; set; }

        public string Name { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; } = new HashSet<Ingredient>();

        public ICollection<string> Instruction { get; set; } = new List<string>();
    }
}
