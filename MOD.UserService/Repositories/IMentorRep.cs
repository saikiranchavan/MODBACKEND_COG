using Microsoft.AspNetCore.Mvc;
using MOD.UserService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.UserService.Repositories
{
    public interface IMentorRep
    {
        string AddMentor(Mentor item);
        void UpdateMentor(Mentor item);
        IEnumerable<Mentor> SearchMentor(string Tech,int StartTime,int EndTime);
        void Delete(int id);
        IEnumerable<Mentor> GetAllMentors();
        Mentor Login(string email, string password);
        public void UpdateMentorBlock(int id);
    }
}
