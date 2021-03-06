using Foodie.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodie.BL.Models
{
    public class RecipeGetFilter
    {
        public int PageNumber { get; set; } = default;
        public int PageSize { get; set; } = 5;
        public List<string> IngredientNames { get; set; } = default;
        public int CategoryFilter { get; set; } = default;
        public int CookingTimeFilter { get; set; } = default;
        public int PreparationTimeFilter { get; set; } = default;
    }
}
