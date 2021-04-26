using AutoMapper;
using Foodie.Dal.DTOs;
using Foodie.Dal.Entities;
using Foodie.Dal.ServiceInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodie.Dal.ServiceImplementation
{
    public class RecipeService : IRecipeService
    {
        private readonly FoodieDbContext context;
        private readonly IMapper mapper;

        public RecipeService(FoodieDbContext context, IMapper mapper)
        {           
            this.context = context;
            this.mapper = mapper;
        }

        public async Task DeleteAsync(int id)
        {
            context.Recipes.Remove(new Recipe { Id = id });

            await context.SaveChangesAsync();
        }

        public PagedResult<RecipePreview> Get(
          int pageNumber,
          int pageSize,
          Func<Recipe, bool> filter)
        {
            var query = context.Recipes
                .Where(filter)
                .OrderBy(recipe => recipe.Name);            

            var results = query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(r => mapper.Map<RecipePreview>(r))
                .AsEnumerable();            

            return new PagedResult<RecipePreview>() 
            {
                AllResultsCount = query.Count(),
                PageNumber = pageNumber,
                PageSize = pageSize,
                Results = results
            };
        }

        public async Task<Recipe> GetAsync(int id)
        {
            return await context.Recipes
                .FindAsync(id);
        }

        public async Task InsertAsync(Recipe recipeToInsert)
        {
            await context.Recipes.AddAsync(recipeToInsert);

            await context.SaveChangesAsync();
        }

        public async Task UpdatesAsync(Recipe updatedRecipe)
        {
            var recipe = await context.Recipes.FindAsync(updatedRecipe.Id);

            if (updatedRecipe.Category != Category.Default)
                recipe.Category = updatedRecipe.Category;

            if (updatedRecipe.PreparationTime != default)
                recipe.PreparationTime = updatedRecipe.PreparationTime;

            if (updatedRecipe.CookingTime != default)
                recipe.CookingTime = updatedRecipe.CookingTime;

            if (string.IsNullOrEmpty(updatedRecipe.Name) == false)
                recipe.Name = updatedRecipe.Name;

            if (updatedRecipe.Instruction.Count > 0)
                recipe.Instruction = updatedRecipe.Instruction;


            if (updatedRecipe.Ingredients.Count > 0)
                recipe.Ingredients = updatedRecipe.Ingredients;

            await context.SaveChangesAsync();
        }
    }
}
