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
        private List<User> users;

        public UserRepository()
        {
            users = new List<User>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }
        public void UpdateUser(User user)
        {
            //find index of user to update
            int index = users.FindIndex(u => u.Id == user.Id);

            //if user found, update it
            if (index == -1)
            {
                users[index] = user;
            }
        }

        public void DeleteUser (User user)
        {
            users.Remove(user);
        }

        public List<User> GetAllUsers()
        {
            return users;
        }
        public User GetUserById(int id)
        {
            return users.Find(u => u.Id == id);
        }

        public User GetUserByEmail(string email)
        {
            return users.Find(u => u.Email == email);
        }

        public User CreateUser(string name, string email, Role role)
        {
            User user = new User()
            {
                Id = GetNextId(),
                Name = name,
                Email = email,
                Role = role,
            };

            AddUser(user);
            return user;
        }

        private int GetNextId()
        {
            int nextId = 1;

            if (users.Count > 0)
            {
                nextId = users[users.Count - 1].Id + 1;
            }

            return nextId;
        }

    }
}
