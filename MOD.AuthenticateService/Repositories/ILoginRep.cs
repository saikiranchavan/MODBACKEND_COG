using MOD.AuthenticateService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.AuthenticateService.Repositories
{
    public interface ILoginRep
    {
        public User UserLogin(string email, string pwd);
        public Mentor MentorLogin(string email, string pwd);
    }
}
