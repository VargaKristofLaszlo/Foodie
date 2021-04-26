using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Foodie.Dal.Entities
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public TimeSpan PreparationTime { get; set; }

        [Required]
        public TimeSpan CookingTime { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Provide an instruction to the recipe")]
        public ICollection<string> Instruction { get; set; } = new List<string>();

        [Required]
        public ICollection<Ingredient> Ingredients { get; set; } = new HashSet<Ingredient>();

        public ICollection<UserRecipe> Users { get; set; } = new HashSet<UserRecipe>();
    }
}
