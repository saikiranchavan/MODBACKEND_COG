using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.TrainingService.Context;
using MOD.TrainingService.Models;

namespace MOD.TrainingService.Repositories
{
    class TrainingRep : ITrainingRep
    {
        TrainingContext _context;

        public TrainingRep(TrainingContext context)
        {
            _context = context;
        }
        public string Add(Training item)
        {
            _context.Trainings.Add(item);
            _context.SaveChanges();
            return "Trianing is added";
            /*var obj = _context.Trainings.Where(i => i.MentorID == item.MentorID && i.UserID == item.UserID);
            if (obj == null)
            {
                _context.Trainings.Add(item);
                _context.SaveChanges();
            }
            else
            {
                return "Mentor and User are already inside the training field";
            }
            return "Training is been added";
*/
        }

        public void Delete(int Userid,int Mentorid)
        {
            var obj=_context.Trainings.SingleOrDefault(i=>i.UID==Userid&&i.MentorID==Mentorid);
            _context.Remove(obj);
            _context.SaveChanges();
        }

        public string Edit(Training item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return "Training details has been Edited";
        }

        public IEnumerable<Training> GetAllTrainings()
        {
            return _context.Trainings;
        }

        public IEnumerable<Training> GetTrainingsByMentorID_completed(int mentorId,string status)
        {
            return _context.Trainings.Where(i => i.MentorID == mentorId&&i.Status.Equals("Completed"));
        }

        public IEnumerable<Training> GetTrainingsByMentorID_current(int mentorId, string status)
        {
            return _context.Trainings.Where(i => i.MentorID == mentorId && !i.Status.Equals("Completed"));
        }

        public IEnumerable<Training> GetTrainingsByUserID_completed(int userId,string status)
        {
            return _context.Trainings.Where(i => i.UID == userId&&i.Status.Equals("Completed"));
        }

        public IEnumerable<Training> GetTrainingsByUserID_current(int userId,string status)
        {
            return _context.Trainings.Where(i => i.UID == userId&&!i.Status.Equals("Completed"));
        }

        public void EditById(int id, string status, int progress)
        {
            var obj = _context.Trainings.Find(id);
            obj.Status = status;
            obj.Progress = progress;
            _context.SaveChanges();
        }
    }
}
