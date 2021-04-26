using System;

namespace Foodie.Dal.DTOs
{
    public class RecipePreview
    {
        public int Id { get; set; }

        public TimeSpan PreparationTime { get; set; }
        
        public TimeSpan CookingTime { get; set; }

        public string Name { get; set; }
    }
}
