using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foodie.Web.IApi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Foodie.Dal.Entities;
using Foodie.Dal.DTOs;

namespace Foodie.Web.Pages.Admin
{
    public class AddOrUpdateRecipeModel : PageModel
    {
        private readonly IRecipeApi recipeApi;

        [BindProperty]
        public List<Category> Categories { get; set; } = Enum.GetValues(typeof(Category)).Cast<Category>().ToList();

        [BindProperty]
        public List<Measurement> Measurements { get; set; } = Enum.GetValues(typeof(Measurement)).Cast<Measurement>().ToList();

        [BindProperty(SupportsGet = true)]
        public int? Id { get; set; }

        [BindProperty]
        public RecipeDetails Recipe { get; set; } = new RecipeDetails();

        public AddOrUpdateRecipeModel(IRecipeApi recipeApi)
        {
            this.recipeApi = recipeApi;
        }

        public async Task OnGetAsync()
        {
            if (Id.HasValue)
            {
                this.Recipe = await this.recipeApi.GetAsync(Id.Value);
            }
        }
    }
}
