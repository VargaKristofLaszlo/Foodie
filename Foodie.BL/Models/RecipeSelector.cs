using Foodie.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodie.BL.Models
{
    public class RecipeSelector
    {
        public int PageNumber { get; set; } = 0;
        public int PageSize { get; set; } = 5;
        public List<string> IngredientNames { get; set; } = null;
        public int CategoryFilter { get; set; } = 0;
        public int CookingTimeFilter { get; set; } = default;
        public int PreparationTimeFilter { get; set; } = default;
    }
}
