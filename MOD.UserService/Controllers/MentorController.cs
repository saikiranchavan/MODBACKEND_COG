using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.UserService.Context;
using MOD.UserService.Repositories;
using MOD.UserService.Models;
namespace MOD.UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MentorController : ControllerBase
    {
        IMentorRep _repository;
        public MentorController(IMentorRep mentorRep)
        {
            _repository = mentorRep;
        }
        // GET: api/Mentor
        [HttpGet]
        [Route("MentorGet")]
        public IEnumerable<Mentor> Get()
        {
            return _repository.GetAllMentors();
        }

        //Get for Login
        [HttpGet("MentorLogin/{email}/{password}")]
        [Route("MentorLogin/{email}/{password}")]

        public Mentor Get(string email,string password)
        {
            return _repository.Login(email,password);
        }

        [HttpGet("search/{Tech}/{ST}/{ET}")]
        [Route("search/{Tech}/{ST}/{ET}")]
        public IEnumerable<Mentor> SearchMentors(string Tech,int ST,int ET)
        {
            return _repository.SearchMentor(Tech,ST,ET);
        }

        [HttpPut("{id}")]
        [Route("UpdateMentorBlock/{id}")]
        public void Put(int id)
        {
            _repository.UpdateMentorBlock(id);
        }

        // POST: api/Mentor
        [HttpPost("{item}")]
        [Route("MentorPost/{item}")]
        public string Post(Mentor item)
        {
            return _repository.AddMentor(item);
            
        }

        //Post for Mentor Login
        

        // PUT: api/Mentor/5
        [HttpPut("{item}")]
       
        public void Put(Mentor item)
        {
            _repository.UpdateMentor(item);
        }

        // DELETE: api/ApiWithActions/5
        
        [HttpDelete("{id}")]
        [Route("DeleteMentor/{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);

        }
    }
}
