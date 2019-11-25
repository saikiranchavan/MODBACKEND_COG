using MOD.TrainingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TrainingService.Repositories
{
    public interface ITrainingRep
    {
        public string Add(Training item);
        public IEnumerable<Training> GetAllTrainings();
        public IEnumerable<Training> GetTrainingsByUserID_completed(int userId,string status);
        public IEnumerable<Training> GetTrainingsByUserID_current(int userId, string status);
        public IEnumerable<Training> GetTrainingsByMentorID_completed(int mentorId,string status);
        public IEnumerable<Training> GetTrainingsByMentorID_current(int mentorId, string status);
        public string Edit(Training item);
        public void Delete(int Userid,int Mentorid);

        public void EditById(int id,string status,int progress);

        public void EditRating(int id,string rating);
    }
}
