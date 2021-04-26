using Foodie.BL.Models;
using Foodie.BL.ServiceInterfaces;
using Foodie.Dal.DTOs;
using Foodie.Dal.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<IActionResult> Post([FromBody] RecipeDetails recipeDetails)
        {
            await recipeLogic.InsertAsync(recipeDetails);
            return NoContent();
        }

        // PUT api/<RecipeController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] RecipeDetails recipeDetails)
        {
            await recipeLogic.UpdatesAsync(recipeDetails);
            return NoContent();
        }

        // DELETE api/<RecipeController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await recipeLogic.DeleteAsync(id);
            return NoContent();
        }
    }
}
