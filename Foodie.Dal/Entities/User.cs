using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Foodie.Dal.Entities
{
    public class User : IdentityUser<int>
    {
        public ICollection<UserRecipe> FavouriteRecipes { get; set; } = new HashSet<UserRecipe>();
    }
}
