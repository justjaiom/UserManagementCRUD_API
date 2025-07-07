// UsersController.cs
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using UserManagementAPI.Models;

namespace UserManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private List<User> _users = new List<User>
        {
            new User { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
            new User { Id = 2, Name = "Jane Doe", Email = "jane.doe@example.com" },
            new User { Id = 3, Name = "Bob Smith", Email = "bob.smith@example.com" }
        };

        // GET api/users
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _users.AsQueryable().ToList();
            return Ok(users);
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            try
            {
                var user = _users.Find(u => u.Id == id);
                if (user == null)
                {
                    return NotFound();
                }
                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        // POST api/users
        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            if (string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Email))
            {
                return BadRequest("Invalid user data");
            }
            _users.Add(user);
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }

        // PUT api/users/5
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, User user)
        {
            try
            {
                var existingUser = _users.Find(u => u.Id == id);
                if (existingUser == null)
                {
                    return NotFound();
                }
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
                return Ok(existingUser);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                var user = _users.Find(u => u.Id == id);
                if (user == null)
                {
                    return NotFound();
                }
                _users.Remove(user);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}