using System.ComponentModel.DataAnnotations;

namespace Foodie.Dal.Entities
{
    public class UserRecipe
    {      
        public int RecipeId { get; set; }
        [Required]
        public Recipe Recipe { get; set; }


        public int UserId { get; set; }
        [Required]
        public User User { get; set; }
    }
}
