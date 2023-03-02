using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budweg.Models
{
    public class Employee
    {
        private int iDCount = 0;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role EmpoyeeRole { get; set; }

        public Employee(int iDCount, int id, string name, string email, string password, Role empoyeeRole)
        {
            this.iDCount = iDCount;
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            EmpoyeeRole = empoyeeRole;
        }
    }
}
