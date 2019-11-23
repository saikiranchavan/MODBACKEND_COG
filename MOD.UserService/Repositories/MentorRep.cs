using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.UserService.Models;
using Microsoft.EntityFrameworkCore;
using MOD.UserService.Context;
using Microsoft.AspNetCore.Mvc;
using MOD.UserService.Repositories;

namespace MOD.UserService.Repositories
{
    public class MentorRep : IMentorRep
    {
        UserContext _context;
        public MentorRep(UserContext con)
        {
            _context = con;
        }
        public string AddMentor(Mentor item)
        {
            var obj = _context.Mentors.SingleOrDefault(i=>i.Email.Equals(item.Email));
            if (obj == null)
            {
                _context.Mentors.Add(item);
                _context.SaveChanges();
                return "The Mentor Details Has been inserted";
            }
            else
            {
                return "The Mentor Email Already exists please type another Email";
            }
        }

        public void Delete(int id)
        {
            var obj=_context.Mentors.Find(id);
            _context.Mentors.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Mentor> GetAllMentors()
        {
            return _context.Mentors;
        }

        public Mentor Login(string email, string password)
        {
            try
            {
                return _context.Mentors.SingleOrDefault(i => i.Email.Equals(email) && i.Password.Equals(password));
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public void UpdateMentorBlock(int id)
        {
            var obj = _context.Mentors.Find(id);
            if (obj.MentorBlock == true)
                obj.MentorBlock = false;
            else
                obj.MentorBlock = true;
            
            _context.SaveChanges();

        }

        public IEnumerable<Mentor> SearchMentor(string Tech, int StartTime, int EndTime)
        {
            return _context.Mentors.Where(i => i.PrimaryTechnology.Equals(Tech) && i.StartTime == StartTime && i.EndTime == EndTime);
            
        }

        public void UpdateMentor(Mentor item)
        {
            /*var obj = _context.Mentors.Find(id);
            if(obj!=null)
                _context.Mentors.Update(item);*/
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
