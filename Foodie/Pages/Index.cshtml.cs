using Foodie.Dal.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Foodie.Web.ViewComponents.PagerViewComponent;
using Foodie.Dal.Entities;
using System.Collections.Generic;
using System;
using Foodie.BL.Models;
using System.Linq;
using Foodie.Web.Helpers;
using System.Threading.Tasks;
using Foodie.Web.IApi;
using Foodie.BL.Interfaces;

namespace Foodie.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRecipeLogic recipeLogic;
        private readonly IRecipeApi recipeApi;
        private readonly string SessionKeyCookingTime = "_Cook";
        private readonly string SessionKeyPreparTime = "_Prepar";
        private readonly string SessionKeyCategories = "_Category";
        public List<Category> Categories { get; set; } = Enum.GetValues(typeof(Category)).Cast<Category>().ToList();
        public PagedResult<RecipePreview> RecipePreviews { get; set; }

        public IndexModel(IRecipeLogic recipeLogic, IRecipeApi recipeApi)
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

        public async Task<IActionResult> OnGet()
        {
            CookingTimeLimitInMinutes = HttpContext.Session.Get<int>(SessionKeyCookingTime);
            PreparingTimeLimitInMinutes = HttpContext.Session.Get<int>(SessionKeyPreparTime);
            SelectedCategoryFlags = HttpContext.Session.Get<Category>(SessionKeyCategories);

            RecipePreviews = await recipeApi.GetRecipePreviewsAsync(new RecipeGetFilter()
            {
                PageNumber = Specification.PageNumber,
                PageSize = Specification.PageSize,
                CategoryFilter = (int)SelectedCategoryFlags,
                CookingTimeFilter = CookingTimeLimitInMinutes * 60,
                PreparationTimeFilter = PreparingTimeLimitInMinutes * 60
            });

            return Page();
        }

        public void OnPost()
        {


            Specification.PageNumber = 1;
            SelectedCategoryFlags = GetCategoryFilter();
            HttpContext.Session.Set(SessionKeyCategories, GetCategoryFilter());
            HttpContext.Session.Set(SessionKeyCookingTime, CookingTimeLimitInMinutes);
            HttpContext.Session.Set(SessionKeyPreparTime, PreparingTimeLimitInMinutes);

            RecipePreviews = recipeLogic.Get(new RecipeGetFilter()
            {
                PageNumber = Specification.PageNumber,
                PageSize = Specification.PageSize,
                CategoryFilter = (int)SelectedCategoryFlags,
                CookingTimeFilter = CookingTimeLimitInMinutes * 60,
                PreparationTimeFilter = PreparingTimeLimitInMinutes * 60
            });
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
