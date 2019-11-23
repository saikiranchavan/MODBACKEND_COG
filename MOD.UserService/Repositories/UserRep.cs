using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.UserService.Context;
using MOD.UserService.Models;

namespace MOD.UserService.Repositories
{
    public class UserRep : IUserRep
    {
        UserContext _context;
        public UserRep(UserContext context)
        {
            _context = context;
        }

        public User Login(string email, string password)
        {
            try
            {
                return _context.Users.SingleOrDefault(i => i.UserEmail.Equals(email) && i.Password.Equals(password));
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public string AddUser(User item)
        {
            var obj=_context.Users.SingleOrDefault(i=>i.UserEmail.Equals(item.UserEmail));
            if (obj == null)
            {
                _context.Users.Add(item);
                _context.SaveChanges();
                return "User data is Saved";
            }
            else
            {
                return "User Exists With this Email Please Give Another name";
            }
        }

        public void DeleteUser(int id)
        {
            var obj= _context.Users.Find(id);
            _context.Users.Remove(obj);
            _context.SaveChanges();
        }

        public void UpdateUserBlock(int id)
        {
            var obj = _context.Users.Find(id);
            if (obj.UserBlock == true)
                obj.UserBlock = false;
            else
                obj.UserBlock = true;
            //obj.UserBlock =!obj.UserBlock;
            //_context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            
        }

        /*public void UpdateUserUnblock(int id)
        {
            var obj = _context.Users.Find(id);
            obj.UserBlock = false;
            _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            
            
        }*/

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users;
        }
    }
}
