using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budweg2._1.Model
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
            return $"{EmployeeId}, {Name}, {Email}, {EmployeeRole}";
        }
    }
}
