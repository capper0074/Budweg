using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budweg.Models
{
    public class Employee
    {

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role EmpoyeeRole { get; set; }

        public Employee(string name, string email, string password)
        {
            
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
