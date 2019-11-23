using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.TrainingService.Models;
using MOD.TrainingService.Repositories;

namespace MOD.TrainingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        ITrainingRep _repository;
        public TrainingController(ITrainingRep rep)
        {
            _repository=rep;
        }
        // GET: api/Training
        [HttpGet]
        [Route("GetAllTrainings")]
        public IEnumerable<Training> Get()
        {
            return _repository.GetAllTrainings();
        }

        [Route("UserId/{id}/{status}")]
        public IEnumerable<Training> GetByUserId(int id,string status)
        {
            if (status.Equals("Completed"))
            {
                return _repository.GetTrainingsByUserID_completed(id,status);
            }
            else
            {
                return _repository.GetTrainingsByUserID_current(id, status);
            }
        }

        [Route("MentorId/{id}/{status}")]
        public IEnumerable<Training> GetByMentorId(int id,string status)
        {
            //return _repository.GetTrainingsByMentorID(id);
            if (status.Equals("Completed"))
            {
                return _repository.GetTrainingsByMentorID_completed(id, status);
            }
            else
            {
                return _repository.GetTrainingsByMentorID_current(id, status);
            }
        }

        // POST: api/Training
        [HttpPost("{item}")]
        [Route("AddTraining/{item}")]
        public void Post(Training item)
        {
            _repository.Add(item);

        }

        // PUT: api/Training/5
        [HttpPut("{item}")]
        [Route("UpdateTraining")]
        public void Put(Training item)
        {
            _repository.Edit(item);
        }

        [HttpPut("{id}/{status}/{progress}")]
        [Route("UpdateTrainingByID/{id}/{status}/{progress}")]
        public void Put1(int id,string status,int progress)
        {
            _repository.EditById(id,status,progress);
           
        }

        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{userid}/{mentorid}")]
        [Route("Delete/{userid}/{mentorid}")]
        public void Delete(int userid,int mentorid)
        {
            _repository.Delete(userid, mentorid);
        }
    }
}
