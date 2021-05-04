using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Foodie.BL.Interfaces;
using Foodie.BL.Models;
using Foodie.Dal.DTOs;
using Foodie.Dal.Entities;
using Foodie.Web.Helpers;
using Foodie.Web.IApi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using static Foodie.Web.ViewComponents.PagerViewComponent;

namespace Foodie.Web.Pages
{
    public class FilterRecipesModel : PageModel
    {
        private readonly IRecipeLogic recipeLogic;
        private readonly IRecipeApi recipeApi;
        private readonly string SessionKeyCookingTime = "_Cook";
        private readonly string SessionKeyPreparTime = "_Prepar";
        private readonly string SessionKeyCategories = "_Category";
        private readonly string SessionKeyFilteredIngredientNames = "_Ingredients";
        private readonly string SessionKeyRecipes = "_Recipes";

        public List<Category> Categories { get; set; } = Enum.GetValues(typeof(Category)).Cast<Category>().ToList();
        public PagedResult<RecipePreview> RecipePreviews { get; set; }

        public FilterRecipesModel(IRecipeLogic recipeLogic, IRecipeApi recipeApi)
        {
            this.recipeLogic = recipeLogic;
            this.recipeApi = recipeApi;
        }

        [BindProperty]
        public List<Category> SelectedCategories { get; set; } = new List<Category>();

        [BindProperty(SupportsGet = true)]
        public PagerSpecification Specification { get; set; }

        [BindProperty]
        public int CookingTimeLimitInMinutes { get; set; }
        [BindProperty]
        public int PreparingTimeLimitInMinutes { get; set; }

        [BindProperty(SupportsGet = true)]
        public Category SelectedCategoryFlags { get; set; } = Category.Default;

        [BindProperty]
        [Display(Name = "Ingredient name")]
        public string NewIngredientName { get; set; }

        [BindProperty]
        public string SelectedIngredientName { get; set; }

        [BindProperty]
        public IEnumerable<SelectListItem> DisplayedIngredientNames { get; set; }



        public async Task<IActionResult> OnGet()
        {
            CookingTimeLimitInMinutes = HttpContext.Session.Get<int>(SessionKeyCookingTime);
            PreparingTimeLimitInMinutes = HttpContext.Session.Get<int>(SessionKeyPreparTime);
            SelectedCategoryFlags = HttpContext.Session.Get<Category>(SessionKeyCategories);
            var FilteredIngredientNames = HttpContext.Session.Get<List<string>>(SessionKeyFilteredIngredientNames);

            if (FilteredIngredientNames == null)
                FilteredIngredientNames = new List<string>();
            DisplayedIngredientNames = ConvertToSelectListItem(FilteredIngredientNames);



            RecipePreviews = await recipeApi.GetRecipePreviewsAsync(new RecipeGetFilter()
            {
                PageNumber = Specification.PageNumber,
                PageSize = Specification.PageSize,
                CategoryFilter = (int)SelectedCategoryFlags,
                CookingTimeFilter = CookingTimeLimitInMinutes * 60,
                PreparationTimeFilter = PreparingTimeLimitInMinutes * 60
            });

            HttpContext.Session.Set(SessionKeyRecipes, RecipePreviews);

            return Page();
        }

        public async Task OnPostSearchAsync()
        {
            var ingredientNames = HttpContext.Session.Get<List<string>>(SessionKeyFilteredIngredientNames) ?? new List<string>();

            DisplayedIngredientNames = ConvertToSelectListItem(ingredientNames);

            Specification.PageNumber = 1;
            SelectedCategoryFlags = GetCategoryFilter();

            RecipePreviews = await recipeApi.GetRecipePreviewsAsync(new RecipeGetFilter()
            {
                PageNumber = Specification.PageNumber,
                PageSize = Specification.PageSize,
                CategoryFilter = (int)SelectedCategoryFlags,
                CookingTimeFilter = CookingTimeLimitInMinutes * 60,
                PreparationTimeFilter = PreparingTimeLimitInMinutes * 60,
                IngredientNames = ingredientNames
            });


            HttpContext.Session.Set(SessionKeyCategories, GetCategoryFilter());
            HttpContext.Session.Set(SessionKeyCookingTime, CookingTimeLimitInMinutes);
            HttpContext.Session.Set(SessionKeyPreparTime, PreparingTimeLimitInMinutes);
            HttpContext.Session.Set(SessionKeyFilteredIngredientNames, ingredientNames);
        }


        private IEnumerable<SelectListItem> ConvertToSelectListItem(List<string> list)
        {
            var selectList = new List<SelectListItem>();

            if (list != null)
            {
                foreach (var item in list)
                {
                    selectList.Add(new SelectListItem()
                    {
                        Text = item,
                        Value = item
                    });
                }
            }
            return selectList;
        }


        public void OnPostAddIngredient()
        {
            if (string.IsNullOrEmpty(NewIngredientName) == false)
            {
                var newList = HttpContext.Session.Get<List<string>>(SessionKeyFilteredIngredientNames) ?? new List<string>();

                if (newList.Contains(NewIngredientName) == false)
                    newList.Add(NewIngredientName);

                DisplayedIngredientNames = ConvertToSelectListItem(newList);

                HttpContext.Session.Remove(SessionKeyFilteredIngredientNames);
                HttpContext.Session.Set(SessionKeyFilteredIngredientNames, newList);
            }
            RecipePreviews = HttpContext.Session.Get<PagedResult<RecipePreview>>(SessionKeyRecipes);
            CookingTimeLimitInMinutes = HttpContext.Session.Get<int>(SessionKeyCookingTime);
            PreparingTimeLimitInMinutes = HttpContext.Session.Get<int>(SessionKeyPreparTime);
            SelectedCategoryFlags = HttpContext.Session.Get<Category>(SessionKeyCategories);
        }

        public void OnPostRemoveIngredient()
        {
            var newList = HttpContext.Session.Get<List<string>>(SessionKeyFilteredIngredientNames) ?? new List<string>();

            var item = newList.Find(x => x.Equals(SelectedIngredientName));

            newList.Remove(item);

            DisplayedIngredientNames = ConvertToSelectListItem(newList);

            HttpContext.Session.Remove(SessionKeyFilteredIngredientNames);
            HttpContext.Session.Set(SessionKeyFilteredIngredientNames, newList);

            RecipePreviews = HttpContext.Session.Get<PagedResult<RecipePreview>>(SessionKeyRecipes);
            CookingTimeLimitInMinutes = HttpContext.Session.Get<int>(SessionKeyCookingTime);
            PreparingTimeLimitInMinutes = HttpContext.Session.Get<int>(SessionKeyPreparTime);
            SelectedCategoryFlags = HttpContext.Session.Get<Category>(SessionKeyCategories);

        }

        public Category GetCategoryFilter()
        {
            if (SelectedCategories.Count() == 0)
                return Category.Default;

            Category res = SelectedCategories.First();

            for (int i = 1; i < SelectedCategories.Count(); i++)
            {
                res |= SelectedCategories.ElementAt(i);
            }
            return res;
        }

    }
}
