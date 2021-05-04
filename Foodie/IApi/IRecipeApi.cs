using Foodie.BL.Models;
using Foodie.Dal.DTOs;
using Refit;
using System.Threading.Tasks;

namespace Foodie.Web.IApi
{
    public interface IRecipeApi
    {
        [Get("")]
        Task<PagedResult<RecipePreview>> GetRecipePreviewsAsync([Body] RecipeGetFilter filter);

        [Get("/{id}")]
        Task<RecipeDetailsWithRatings> GetAsync(int id);

    }
}
