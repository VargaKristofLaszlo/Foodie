using Foodie.BL.Models;
using Foodie.Dal.DTOs;
using Refit;
using System.Net.Http;
using System.Threading.Tasks;

namespace Foodie.Web.IApi
{
    public interface IRecipeApi
    {
        [Get("")]
        Task<PagedResult<RecipePreview>> GetRecipePreviewsAsync([Body] RecipeGetFilter filter);

        [Get("/{id}")]
        Task<RecipePreview> GetAsync(int id);

        [Post("")]
        Task Post([Body] RecipeDetails recipeDetails);

        [Put("/{id}")]
        Task Put(int id, [Body] RecipeDetails recipeDetails);

        [Delete("/{id}")]
        Task Delete(int id);
    }
}
