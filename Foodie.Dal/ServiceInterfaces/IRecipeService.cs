using Foodie.Dal.DTOs;
using Foodie.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Foodie.Dal.ServiceInterfaces
{
    public interface IRecipeService
    {
        Task InsertAsync(Recipe recipeToInsert);

        PagedResult<RecipePreview> Get(
         int pageNumber,
         int pageSize,
         Func<Recipe, bool> filter);

        Task<Recipe> GetAsync(int id);

        Task UpdatesAsync(Recipe updatedRecipe);

        Task DeleteAsync(int id);
    }
}
