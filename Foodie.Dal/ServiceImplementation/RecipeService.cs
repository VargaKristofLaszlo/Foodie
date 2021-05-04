using AutoMapper;
using Foodie.Dal.DTOs;
using Foodie.Dal.Entities;
using Foodie.Dal.Exceptions;
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

        public async Task AddRatingAsync(int recipeId, int rating, int userId, string text)
        {
            if (rating < 0)
                rating = 0;

            if (rating > 5)
                rating = 5;


            var recipe = await this.context.Recipes.FirstOrDefaultAsync(x => x.Id.Equals(recipeId));
            if (recipe == null)
                throw new NotFoundException();

            var user = await this.context.Users.FirstOrDefaultAsync(x => x.Id.Equals(userId));
            if (user == null)
                throw new NotFoundException();

            recipe.Ratings.Add(new Rating
            {
                User = user,
                UserId = user.Id,
                Recipe = recipe,
                RecipeId = recipe.Id,
                Value = rating,
                Comment = text
            });

            if (rating > 3)
            {
                user.FavouriteRecipes.Add(new UserRecipe()
                {
                    Recipe = recipe,
                    RecipeId = recipe.Id,
                    User = user,
                    UserId = user.Id
                });
            }

            await context.SaveChangesAsync();
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
            var res = await context.Recipes
                .Include(x => x.Ratings)
                .ThenInclude(r => r.User)
                .FirstOrDefaultAsync(x => x.Id.Equals(id));


            if (res == null)
                throw new NotFoundException();

            return res;
        }

        public async Task<int> GetRecipeRating(int recipeId)
        {
            var recipe = await context.Recipes
                .Include(r => r.Ratings)
                .FirstOrDefaultAsync(x => x.Id.Equals(recipeId));

            if (recipe == null)
                throw new NotFoundException();

            await context.SaveChangesAsync();

            int sum = 0;
            int count = 0;

            foreach (var rating in recipe.Ratings)
            {
                sum += rating.Value;
                count += 1;
            }

            if (sum == 0 || count == 0)
                return 0;

            return (int)Math.Floor((double)sum / count);

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
