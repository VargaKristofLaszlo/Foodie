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

        public int Category { get; set; }

        public int PreparationTime { get; set; }

        public int CookingTime { get; set; }

        public string Name { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; } = new HashSet<Ingredient>();

        public ICollection<string> Instruction { get; set; } = new List<string>();
    }
}
