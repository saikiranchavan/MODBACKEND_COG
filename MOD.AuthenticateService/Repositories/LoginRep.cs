using MOD.AuthenticateService.Context;
using MOD.AuthenticateService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.AuthenticateService.Repositories
{
    public class LoginRep : ILoginRep
    {
        private readonly LoginContext _context;
        public LoginRep(LoginContext context)
        {
            _context = context;
        }
        public Mentor MentorLogin(string email, string pwd)
        {
            
            Mentor obj = _context.Mentor.SingleOrDefault(data => data.Email.Equals(email) && data.Password.Equals(pwd));
            return obj;
        }

        public User UserLogin(string email, string pwd)
        {
            User obj = _context.User.SingleOrDefault(data => data.UserEmail.Equals(email) && data.Password.Equals(pwd));
            return obj;
        }
    }
}
