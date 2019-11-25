using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.TechnologyService.Models;
using MOD.TechnologyService.Context;
using MOD.TechnologyService.Repositories;
namespace MOD.TechnologyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnologyController : ControllerBase
    {
        ITechRepo repository;
        public TechnologyController(ITechRepo techRepo)
        {
            repository = techRepo;
        }
        // GET: api/Technology
        [HttpGet]
        [Route("GetAllTechnology")]
        public IEnumerable<Technology> Get()
        {
            return repository.GetAllTechnologies();
        }

        // GET: api/Technology/5

        [HttpGet("{name}", Name = "Get")]
        [Route("GetTechnologyByName/{name}")]
        public Technology Get(string name)
        {
            return repository.GetTechnology(name);
        }

        //[HttpGet("{id}", Name = "Get")]
        [Route("GetTechnologyById/{id}")]
        public Technology Get(int id)
        {
            return repository.GetTechnologyById(id);
        }

        // POST: api/Technology
        [HttpPost("{item}")]
        [Route("AddTech")]
        public IActionResult Post(Technology item)
        {
            repository.Add(item);

            return Ok();
        }

        // PUT: api/Technology/5
        [HttpPut("{item}")]
        [Route("UpdateTech")]
        public IActionResult Put(Technology item)
        {
            var a=repository.Edit(item);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("DeleteTechnology/{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                repository.deleteTechnology(id);
                return Ok();
            }
            return BadRequest();
        }
    }
}
