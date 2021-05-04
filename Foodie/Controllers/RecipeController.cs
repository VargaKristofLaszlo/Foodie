using Foodie.BL.Interfaces;
using Foodie.BL.Models;
using Foodie.Dal.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Foodie.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeLogic recipeLogic;

        public RecipeController(IRecipeLogic recipeLogic)
        {
            this.recipeLogic = recipeLogic;
        }


        // GET: api/<RecipeController>
        [HttpGet]
        public IActionResult Get([FromBody] RecipeGetFilter filter)
        {
            var result = recipeLogic.Get(filter);
            return Ok(result);
        }

        // GET api/<RecipeController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await recipeLogic.GetAsync(id);
            return Ok(result);
        }

        // POST api/<RecipeController>
        [HttpPost]
        [Authorize(Roles = Dal.Roles.Roles.Administrator)]
        //    [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Post([FromBody] RecipeDetails recipeDetails)
        {
            await recipeLogic.InsertAsync(recipeDetails);
            return NoContent();
        }

        // PUT api/<RecipeController>/5
        [HttpPut]
        [Authorize(Roles = Dal.Roles.Roles.Administrator)]
        public async Task<IActionResult> Put([FromBody] RecipeDetails recipeDetails)
        {
            await recipeLogic.UpdatesAsync(recipeDetails);
            return NoContent();
        }

        // DELETE api/<RecipeController>/5
        [HttpDelete("{id}")]
        [Authorize(Roles = Dal.Roles.Roles.Administrator)]
        public async Task<IActionResult> Delete(int id)
        {
            await recipeLogic.DeleteAsync(id);
            return NoContent();
        }

        [HttpPost("{recipeId}/{rating}")]
        [Authorize]
        public async Task<IActionResult> RateRecipe(int recipeId, int rating, [FromBody] Comment comment)
        {
            var userId = this.HttpContext.User.Claims.First(x => x.Type.Equals(ClaimTypes.NameIdentifier)).Value;
            await recipeLogic.RateRecipe(recipeId, rating, int.Parse(userId), comment);
            return Ok();
        }

        [HttpGet("ratings/{recipeId}")]
        public async Task<IActionResult> GetRecipeRating(int recipeId)
        {
            var rating = await recipeLogic.GetRecipeRating(recipeId);

            return Ok(rating);
        }
    }
}
