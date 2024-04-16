using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace International_Cuisine_Exploration_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepo repo;

        public CategoryController(ICategoryRepo repo)
        {
            this.repo = repo;
        }

        //Changed varible names so it's easier to copy&paste

        //get: api/<samuraicontroller>
        [HttpGet] // this is a dataannotation / attribute
        public List<Category> GetAll()
        {
            // If I want to DEBUG
            return repo.GetAll();
        }

        // Create: api/<SamuraiController>
        [HttpPost]
        public void Create(Category column)
        {
            repo.Create(column);

        }

        [HttpPut("{id}")]
        public Category UpdateById(int id, Category updatedColumn)
        {
            return repo.UpdateById(id, updatedColumn);
        }

        [HttpDelete("{id}")]
        public Category DeleteById(int id)
        {
            return repo.DeleteById(id);
        }
    }
}
