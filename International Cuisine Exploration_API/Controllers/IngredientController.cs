using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace International_Cuisine_Exploration_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {   
            private readonly IIngredientRepo repo;

            public IngredientController(IIngredientRepo repo)
            {
                this.repo = repo;
            }



            //get: api/<samuraicontroller>
            [HttpGet] // this is a dataannotation / attribute
            public List<Ingredient> GetAll()
            {
                // If I want to DEBUG
                return repo.GetAll();
            }

            // Create: api/<SamuraiController>
            [HttpPost]
            public void Create(Ingredient ingredient)
            {
                repo.Create(ingredient);

            }

            [HttpPut("{id}")]
            public Ingredient UpdateById(int id, Ingredient updatedIngredient)
            {
                return repo.UpdateById(id, updatedIngredient);
            }

            [HttpDelete("{id}")]
            public Ingredient DeleteById(int id)
            {
                return repo.DeleteById(id);
            }
        
    }
}
