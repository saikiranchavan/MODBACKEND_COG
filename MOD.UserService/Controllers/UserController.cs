using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.UserService.Models;
using MOD.UserService.Context;
using MOD.UserService.Repositories;
namespace MOD.UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserRep _repository;
        public UserController(IUserRep rep)
        {
            _repository = rep;
        }
        // GET: api/User
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<User> Get()
        {
            return _repository.GetAllUsers();
        }

        [HttpGet("UserLogin/{email}/{password}")]
        [Route("UserLogin/{email}/{password}")]

        public User Get(string email, string password)
        {
            return _repository.Login(email, password);
        }

        // POST: api/User
        [HttpPost("{item}")]
        [Route("PostUser/{item}")]
        public string Post(User item)
        {
            return _repository.AddUser(item);

        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        [Route("UpdateUserBlock/{id}")]
        public void Put(int id)
        {
            _repository.UpdateUserBlock(id);
        }

        /*[HttpPut("{id}")]
        [Route("UpdateUserUnBlock/{id}")]
        public void Put2(int id)
        {
             _repository.UpdateUserUnblock(id);
        }*/

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("DeleteUser/{id}")]
        public void Delete(int id)
        {
            _repository.DeleteUser(id);
        }
    }
}
