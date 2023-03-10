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
        public Role EmployeeRole { get; set; }

        public Employee(string name, string email, string password, Role role)
        {
            Name = name;
            Email = email;
            Password = password;
            EmployeeRole = role;
        }

        public override string ToString()
        {
            return $"{EmployeeId}, {Name}, {Email}, {Password}, {EmployeeRole}";
        }
    }
}