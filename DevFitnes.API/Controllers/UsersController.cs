using DevFitnes.API.Core.Entities;
using DevFitnes.API.Models.InputModels;
using DevFitnes.API.Models.ViewModels;
using DevFitnes.API.Persistence;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFitnes.API.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DevFitnessDbContext _dbContext;
        public UsersController(DevFitnessDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            var userViewModel = new UserViewModel(user.Id, user.FullName, user.Height, user.Weight, user.BirthDate);
            return Ok(userViewModel);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateUserInputModel inputmodel)
        {
            var user = new User(inputmodel.FullName, inputmodel.Height, inputmodel.Weight, inputmodel.BirthDate);
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            
            return CreatedAtAction(nameof(Get), new { id = user.Id }, inputmodel);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateUserModel inputmodel)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);

            if(user == null)
            {
                return NotFound();
            }
            user.Update(inputmodel.Heigth, inputmodel.Weight);
            _dbContext.SaveChanges();

            return NoContent();
        }

    }
}
