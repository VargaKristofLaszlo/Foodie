using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foodie.Web.IApi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Foodie.Dal.Entities;
using Foodie.Dal.DTOs;
using System.Globalization;

namespace Foodie.Web.Pages.Admin
{
    public class AddOrUpdateRecipeModel : PageModel
    {
        private readonly IRecipeApi recipeApi;

        private int selectionId = 0;

        public int SelectionId
        {
            get
            {
                return selectionId;
            }
        }

        public int SelectionIdWithIncrement
        {
            get
            {
                return selectionId++;
            }
        }

        [BindProperty]
        public List<Category> Categories { get; set; } = Enum.GetValues(typeof(Category)).Cast<Category>().ToList();

        [BindProperty]
        public List<Measurement> Measurements { get; set; } = Enum.GetValues(typeof(Measurement)).Cast<Measurement>().ToList();

        [BindProperty(SupportsGet = true)]
        public int? Id { get; set; } = null;

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public Category Category { get; set; }

        [BindProperty]
        public TimeSpan PreparationTime { get; set; }

        [BindProperty]
        public TimeSpan CookingTime { get; set; }

        [BindProperty]
        public IEnumerable<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        [BindProperty]
        public List<string> Instructions { get; set; } = new List<string>();

        public AddOrUpdateRecipeModel(IRecipeApi recipeApi)
        {
            this.recipeApi = recipeApi;
        }


        public async Task OnGetAsync()
        {


            if (Id.HasValue)
            {
                var recipe = await this.recipeApi.GetAsync(Id.Value);
                Name = recipe.Name;
                Category = (Category)recipe.Category;
                PreparationTime = new TimeSpan(0, 0, recipe.PreparationTime);
                CookingTime = new TimeSpan(0, 0, recipe.CookingTime);
                Ingredients = recipe.Ingredients.AsEnumerable();
                Instructions = recipe.Instruction.AsEnumerable().ToList();
            }
        }

    }
}
