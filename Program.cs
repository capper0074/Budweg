using Budweg.Models;
using Budweg.Repositories;
using Budweg.Views;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Xml.Linq;

class Program
{
  static void Main(string[] args)
    {
        //EmployeeRepository employeeRepository = new EmployeeRepository();

        //Employee employee = new Employee("Niko", "Niko@gmail.com", "22222", Role.AssemblyWorker);
        //employeeRepository.AddEmployee(employee);

        //employeeRepository.Save();

        //Employee employee1 = new Employee("Oliver", "Oliver@gmail.com", "11111", Role.AssemblyWorker);
        //employeeRepository.AddEmployee(employee1);


        //Employee employee2 = new Employee("Hanne", "Hanne@gmail.com", "21529", Role.QualityManager);
        //employeeRepository.AddEmployee(employee2);

        //employeeRepository.Save();

        //employeeRepository.Load();

        OrderRepository orderRepository = new OrderRepository();

        //Order order = new Order(42, 125, "Husk at checke bagstemplet, Egon.", false);
        //orderRepository.AddOrder(order);

        //foreach (Order ord in orderRepository.GetOrders())
        //{
        //    Console.WriteLine(ord.ToString());
        //}
        orderRepository.Load();

    }

}

