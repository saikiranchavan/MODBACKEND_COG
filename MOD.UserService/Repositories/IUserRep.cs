using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.UserService.Models;
namespace MOD.UserService.Repositories
{
    public interface IUserRep
    {
        string AddUser(User item);
        
        void DeleteUser(int id);
        IEnumerable<User> GetAllUsers();

        void UpdateUserBlock(int id);

        /*void UpdateUserUnblock(int id);*/
        User Login(string email, string password);
    }
}
