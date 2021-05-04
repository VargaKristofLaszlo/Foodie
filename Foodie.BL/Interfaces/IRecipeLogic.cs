using Foodie.BL.Models;
using Foodie.Dal.DTOs;
using System.Threading.Tasks;

namespace Foodie.BL.Interfaces
{
    public interface IRecipeLogic
    {
        Task InsertAsync(RecipeDetails recipe);

        public PagedResult<RecipePreview> Get(RecipeGetFilter filter);

        Task<RecipeDetailsWithRatings> GetAsync(int id);

        Task UpdatesAsync(RecipeDetails updatedRecipe);

        Task DeleteAsync(int id);
        Task RateRecipe(int recipeId, int rating, int userId, Comment comment);
        Task<int> GetRecipeRating(int recipeId);
    }
}
