using Budweg.Models;
using Budweg.Repositories;
using Budweg.Views;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
    {
        EmployeeRepository employeeRepository = new EmployeeRepository();

        Employee employee = new Employee("Niko", "Niko@gmail.com", "22222", Role.AssemblyWorker);
        employeeRepository.AddEmployee(employee);

        employeeRepository.Save();

        Employee employee1 = new Employee("Oliver", "Oliver@gmail.com", "11111", Role.AssemblyWorker);
        employeeRepository.AddEmployee(employee1);


        Employee employee2 = new Employee("Hanne", "Hanne@gmail.com", "21529", Role.QualityManager);
        employeeRepository.AddEmployee(employee2);
        
        employeeRepository.Save();

        employeeRepository.Load();

        foreach (Employee emp in employeeRepository.GetAllEmployees())
        {
            Console.WriteLine(emp.ToString());
        }
        Console.ReadLine();
    }

}

