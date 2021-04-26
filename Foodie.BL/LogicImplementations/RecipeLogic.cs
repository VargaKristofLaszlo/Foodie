using AutoMapper;
using Foodie.BL.Models;
using Foodie.BL.ServiceInterfaces;
using Foodie.Dal.DTOs;
using Foodie.Dal.Entities;
using Foodie.Dal.ServiceInterfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Foodie.BL.LogicImplementations
{
    public class RecipeLogic : IRecipeLogic
    {
        private readonly IRecipeService recipeService;
        private readonly IMapper mapper;

        public RecipeLogic(IRecipeService recipeService, IMapper mapper)
        {
            this.recipeService = recipeService;
            this.mapper = mapper;
        }

        public async Task DeleteAsync(int id)
        {
            await recipeService.DeleteAsync(id);
        }



        public PagedResult<RecipePreview> Get(RecipeGetFilter getFilter)
        {
            if (getFilter.PageNumber < 1)
                getFilter.PageNumber = 1;

            if (getFilter.PageSize < 6)
                getFilter.PageSize = 6;

            Func<Recipe, bool> ingredientFilterFunc = recipe => true;
            Func<Recipe, bool> categoryFilterFunc = recipe => true;
            Func<Recipe, bool> preparationTimeFilterFunc = recipe => true;
            Func<Recipe, bool> cookingTimeFilterFunc = recipe => true;

            if (getFilter.IngredientNames != null)
            {
                ingredientFilterFunc = recipe =>
                {
                    var ingredientNames = recipe.Ingredients.Select(i => i.Name.ToLower());

                    foreach (var name in getFilter.IngredientNames)
                    {
                        if (ingredientNames.Contains(name.ToLower()) == false)
                            return false;
                    }
                    return true;
                };
            }
            if ((Category)getFilter.CategoryFilter != Category.Default)
            {
                categoryFilterFunc = recipe => recipe.Category.HasFlag((Category)getFilter.CategoryFilter);
            }

            if (getFilter.CookingTimeFilter != default)
            {
                cookingTimeFilterFunc = recipe => recipe.CookingTime.TotalSeconds <= getFilter.CookingTimeFilter;
            }

            if (getFilter.PreparationTimeFilter != default)
            {
                preparationTimeFilterFunc = recipe => recipe.PreparationTime.TotalSeconds <= getFilter.PreparationTimeFilter;
            }


            Func<Recipe, bool> filter = recipe =>
            {
                return
                    ingredientFilterFunc.Invoke(recipe) &&
                    categoryFilterFunc.Invoke(recipe) &&
                    preparationTimeFilterFunc.Invoke(recipe) &&
                    cookingTimeFilterFunc.Invoke(recipe);
            };

            return recipeService.Get(getFilter.PageNumber, getFilter.PageSize, filter);
        }
        public async Task<RecipeDetails> GetAsync(int id)
        {
            var result = await recipeService.GetAsync(id);

            return mapper.Map<RecipeDetails>(result);
        }

        public async Task InsertAsync(RecipeDetails recipe)
        {
            var recipeToInsert = mapper.Map<Recipe>(recipe);
            await recipeService.InsertAsync(recipeToInsert);
        }

        public async Task UpdatesAsync(RecipeDetails updatedRecipe)
        {
            var recipeToUpdate = mapper.Map<Recipe>(updatedRecipe);
            await recipeService.UpdatesAsync(recipeToUpdate);
        }
    }
}
