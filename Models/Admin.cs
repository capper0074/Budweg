using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budweg.Models
{
    public class Admin
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Admin(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
