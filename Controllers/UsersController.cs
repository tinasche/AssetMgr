using System.Collections.Generic;
using AssetManager.Interfaces;
using AssetManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssetManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _repo;

        public UsersController(IUserRepository repository)
        {   
            _repo = repository;
        }

        
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            var users = _repo.GetAllUsers();
            if (users != null)
                return Ok(users);

            return NotFound();
        }

        [HttpGet("{id}", Name = "GetUserById")]
        public ActionResult<User> GetUserById(int id)
        {
            var user = _repo.GetUserById(id);
            if (user== null)
                return NotFound(user);

            return Ok(user);
        }


        // Create a new user record. Do not supply the userId as the system will generate one automatically.
        [HttpPost]
        public ActionResult <User> CreateAsset(User newUser)
        {
            if (newUser != null)
                _repo.CreateUser(newUser);

            return CreatedAtRoute(nameof(GetUserById), new { Id = newUser.Id }, newUser);
        }
        
        [HttpPut("{id}")]
        public ActionResult ReplaceUserById(int id, User replacementUser)
        {
            if (id != replacementUser.Id)
                return BadRequest();

            if (! _repo.ReplaceUserById(id, replacementUser))
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUserById(int id)
        {
            if (! _repo.DeleteUser(id))
                return NotFound();

            return NoContent();
        }
    }
}