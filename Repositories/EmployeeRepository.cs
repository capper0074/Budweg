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
            //Save list to database
        }

        public void Load()
        {
            //Loading database tables
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void UpdateEmployee(int id, int choice, string newData)
        {
            try
            {
                if (id > 0)
                {
                    switch (choice)
                    {
                        case 1:
                            GetUserById(id).Name = newData;
                            break;
                        case 2:
                            GetUserById(id).Email = newData;
                            break;
                        case 3:
                            GetUserById(id).Password = newData;
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void DeleteEmployee(int id)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].EmployeeId == id)
                {
                    employees.Remove(employees[i]);
                }
            }
        }

        public void SetRole(int choice, int id)
        {
            try
            {
                if (choice > 0 && choice < 4)
                {
                    switch (choice)
                    {
                        case 1:
                            GetUserById(id).EmpoyeeRole = Role.Foreman;
                            break;
                        case 2:
                            GetUserById(id).EmpoyeeRole = Role.ProductionWorker;
                            break;
                        case 3:
                            GetUserById(id).EmpoyeeRole = Role.QualityAssurance;
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

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

        public Employee GetUserById(int id)
        {
            if (id > 0)
                for (int i = id; i < employees.Count(); i++)
                {
                    if (employees[i].Id == id)
                    {
                        return employees[i];
                    }
                }
            return null;
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

    public Employee GetNextId(int id)
    {

        return null; //method for getting next id?
    }



}
}
