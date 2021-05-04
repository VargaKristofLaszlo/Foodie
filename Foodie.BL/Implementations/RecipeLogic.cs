using AutoMapper;
using Foodie.BL.Interfaces;
using Foodie.BL.Models;
using Foodie.Dal.DTOs;
using Foodie.Dal.Entities;
using Foodie.Dal.Exceptions;
using Foodie.Dal.ServiceInterfaces;
using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodie.BL.Implementations
{
    public class RecipeLogic : IRecipeLogic
    {
        private readonly IRecipeService recipeService;
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment environment;


        public RecipeLogic(IRecipeService recipeService, IMapper mapper, IWebHostEnvironment environment)
        {
            this.recipeService = recipeService;
            this.mapper = mapper;
            this.environment = environment;
        }

        public async Task DeleteAsync(int id)
        {

            string imgPath = Path.Combine(environment.WebRootPath, $"images/{id}.PNG");

            try
            {
                if (File.Exists(imgPath))
                {
                    File.Delete(imgPath);
                }
            }
            catch (Exception) { }


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
                    foreach (var filterIngredient in getFilter.IngredientNames)
                    {
                        bool found = false;
                        foreach (var recipeIngredient in recipe.Ingredients)
                        {
                            if (recipeIngredient.Name.Contains(filterIngredient, StringComparison.OrdinalIgnoreCase))
                            {
                                found = true;
                                break;
                            }
                        }
                        if (!found) return false;
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
        public async Task<RecipeDetailsWithRatings> GetAsync(int id)
        {
            var result = await recipeService.GetAsync(id);

            if (result == null)
                throw new NotFoundException();

            return mapper.Map<RecipeDetailsWithRatings>(result);
        }

        public async Task InsertAsync(RecipeDetails recipe)
        {
            if (recipe.Image.Split(',')[0].Equals("data:image/png;base64") == false)
                throw new BadRequestException();

            var recipeToInsert = mapper.Map<Recipe>(recipe);
            await recipeService.InsertAsync(recipeToInsert);


            string imgPath = Path.Combine(environment.WebRootPath, $"images/{recipeToInsert.Id}.PNG");

            bool isNewImage = File.Exists(imgPath);

            if (isNewImage == true)
                throw new BadRequestException();

            byte[] data = Convert.FromBase64String(recipe.Image.Split(',')[1]);

            var format = GetImageFormat(data);

            if (format != ImageFormat.png)
                throw new BadRequestException();

            using (var imageFile = new FileStream(imgPath, FileMode.Create))
            {
                imageFile.Write(data, 0, data.Length);
                imageFile.Flush();
            }
        }

        public async Task UpdatesAsync(RecipeDetails updatedRecipe)
        {
            if (string.IsNullOrEmpty(updatedRecipe.Image) == false)
            {
                if (updatedRecipe.Image.Split(',')[0].Equals("data:image/png;base64") == false)
                    throw new BadRequestException();

                string imgPath = Path.Combine(environment.WebRootPath, $"images/{updatedRecipe.Id}.PNG");

                byte[] data = Convert.FromBase64String(updatedRecipe.Image.Split(',')[1]);

                var format = GetImageFormat(data);

                if (format != ImageFormat.png)
                    throw new BadRequestException();

                bool isNewImage = File.Exists(imgPath);

                if (isNewImage == true)
                {
                    using (var imageFile = new FileStream(imgPath, FileMode.Create))
                    {
                        imageFile.Write(data, 0, data.Length);
                        imageFile.Flush();
                    }
                }
                else
                {
                    using (var imageFile = new FileStream(imgPath, FileMode.Open))
                    {
                        imageFile.Write(data, 0, data.Length);
                        imageFile.Flush();
                    }
                }
            }
            var recipeToUpdate = mapper.Map<Recipe>(updatedRecipe);
            await recipeService.UpdatesAsync(recipeToUpdate);


        }

        private static ImageFormat GetImageFormat(byte[] bytes)
        {
            // see http://www.mikekunz.com/image_file_header.html  
            byte[] bmp = Encoding.ASCII.GetBytes("BM");     // BMP
            var gif = Encoding.ASCII.GetBytes("GIF");    // GIF
            var png = new byte[] { 137, 80, 78, 71 };    // PNG
            var tiff = new byte[] { 73, 73, 42 };         // TIFF
            var tiff2 = new byte[] { 77, 77, 42 };         // TIFF
            var jpeg = new byte[] { 255, 216, 255, 224 }; // jpeg
            var jpeg2 = new byte[] { 255, 216, 255, 225 }; // jpeg canon

            if (bmp.SequenceEqual(bytes.Take(bmp.Length)))
                return ImageFormat.bmp;

            if (gif.SequenceEqual(bytes.Take(gif.Length)))
                return ImageFormat.gif;

            if (png.SequenceEqual(bytes.Take(png.Length)))
                return ImageFormat.png;

            if (tiff.SequenceEqual(bytes.Take(tiff.Length)))
                return ImageFormat.tiff;

            if (tiff2.SequenceEqual(bytes.Take(tiff2.Length)))
                return ImageFormat.tiff;

            if (jpeg.SequenceEqual(bytes.Take(jpeg.Length)))
                return ImageFormat.jpeg;

            if (jpeg2.SequenceEqual(bytes.Take(jpeg2.Length)))
                return ImageFormat.jpeg;

            return ImageFormat.unknown;
        }

        public async Task RateRecipe(int recipeId, int rating, int userId, Comment comment)
        {
            await recipeService.AddRatingAsync(recipeId, rating, userId, comment.Text);
        }

        public async Task<int> GetRecipeRating(int recipeId)
        {
            return await recipeService.GetRecipeRating(recipeId);
        }
    }



    internal enum ImageFormat
    {
        bmp,
        jpeg,
        gif,
        tiff,
        png,
        unknown
    }
}
