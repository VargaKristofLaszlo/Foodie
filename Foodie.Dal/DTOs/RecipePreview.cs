using System;

namespace Foodie.Dal.DTOs
{
    public class RecipePreview
    {
        public int Id { get; set; }

        public int PreparationTime { get; set; }

        public int CookingTime { get; set; }

        public string Name { get; set; }
    }
}
