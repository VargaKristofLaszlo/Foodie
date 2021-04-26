using Foodie.BL.Models;
using Foodie.Dal.DTOs;
using Foodie.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Foodie.BL.ServiceInterfaces
{
    public interface IRecipeLogic
    {
        Task InsertAsync(RecipeDetails recipe);

        public PagedResult<RecipePreview> Get(RecipeGetFilter filter);

        Task<RecipeDetails> GetAsync(int id);

        Task UpdatesAsync(RecipeDetails updatedRecipe);

        Task DeleteAsync(int id);
    }
}
