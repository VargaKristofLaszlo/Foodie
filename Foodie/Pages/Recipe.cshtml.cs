using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foodie.Dal.DTOs;
using Foodie.Web.IApi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Foodie.Web.Pages
{
    public class RecipeModel : PageModel
    {
        private readonly IRecipeApi recipeApi;

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public RecipeDetailsWithRatings RecipeDetails { get; set; }

        public RecipeModel(IRecipeApi recipeApi)
        {
            this.recipeApi = recipeApi;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            RecipeDetails = await this.recipeApi.GetAsync(Id);

            return Page();
        }
    }
}
