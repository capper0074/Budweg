using Budweg2._1.Model;
using Budweg2._1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budweg2._1.ViewModel
{
    public class EmployeeController
    {

        EmployeeRepository employeeRepository = new EmployeeRepository();

        public List<Employee> GetAssemblyWorkers() // Returns a list of Emplyoees with the AssemblyWorker role
        {
            employeeRepository.Load();

            List<Employee> employees = new List<Employee>();

            foreach (Employee employee in employeeRepository.GetAllEmployees())
            {
                if (employee.EmployeeRole == Role.AssemblyWorker)
                {
                    employees.Add(employee);
                }
            }

            return employees;
        }


    }
}
