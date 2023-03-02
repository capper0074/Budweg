using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Budweg.Models;

namespace Budweg.Repositories
{
    public class EmployeeRepository
    {
        private List<Employee> employees = new List<Employee>();

        public void Save()
        {

        }

        public void Load()
        {

        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {

        }

        public void DeleteEmployee(int id)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id == id)
                {
                    employees.Remove(employees[i]);
                }
            }
        }

        public void SetRole(int choice)
        {

        }

        public bool ValidateEmployee(string email, string password)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Email.Equals(email) && employees[i].Password.Equals(password))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public void GetUserById(int id, Employee employee)
        {
            
        }

        public void GetNextId(Employee employee, int id)
        {

        }


       
    }
}
