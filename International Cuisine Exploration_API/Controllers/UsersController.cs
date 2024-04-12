using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace International_Cuisine_Exploration_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository repo;

        public UsersController(IUserRepository repo)
        {
            this.repo = repo;
        }



        //get: api/<samuraicontroller>
        [HttpGet] // this is a dataannotation / attribute
        public List<Users> GetAll()
        {
            // If I want to DEBUG
            return repo.GetAll();
        }

        // Create: api/<SamuraiController>
        [HttpPost]
        public void Create(Users user)
        {
            repo.Create(user);

        }

        [HttpPut("{id}")]
        public Users UpdateById(int id, Users updatedUser)
        {
            return repo.UpdateById(id, updatedUser);
        }

        [HttpDelete("{id}")]
        public Users DeleteById(int id)
        {
            return repo.DeleteById(id);
        }
    }
}
