using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budweg.Models;

namespace Budweg.Repositories
{
    internal class UserRepository
    {
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }
        public User GetUserById(int id)
        {
            return users.FirstOrDefault(u => u.Id == id);
        }
        public User GetUserByEmail(string email)
        {
            return users.FirstOrDefault(u => u.Email == email);
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public bool AuthenticateUser(string email, string password)
        {
            var user = users.FirstOrDefault(u => u.Email == email);
            return user != null && user.Password == password;
      
        }

       
    }
}
