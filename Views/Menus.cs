using Budweg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budweg.Repositories;

namespace Budweg.Views
{
    public class Menus
    {
        public static void ShowInvalidInputMessage()

        {
            Console.WriteLine("Invalid Input. Please try again.");
        }
        public static int GetMenuChoice(int maxChoice)
        {
            int choice = 0;
            bool validChoice = false;

            while (!validChoice)
            {
                Console.Write("Enter your choice: ");
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > maxChoice)
                {
                    ShowInvalidInputMessage();
                }
                else
                {
                    validChoice = true;
                }
            }

            return choice;
        }


        public void LoadMenu(User user, OrderRepository orderRepository, Order order)
        {
            switch (user.Role)
            {
                case Role.Foreman:
                    LoadForemanMenu(orderRepository, order);
                    break;
                case Role.ProductionWorker:
                    LoadProductionWorkerMenu(orderRepository, order);
                    break;
                case Role.QualityAssurance:
                    LoadQualityAssuranceMenu(orderRepository, order);
                    break;
                default:
                    Console.WriteLine("Invalid user role.");
                    break;
            }
        }

        private void LoadForemanMenu(OrderRepository orderRepository, Order order)
        {
            Console.WriteLine("Foreman Menu");
            Console.WriteLine("1. Create Order");
            Console.WriteLine("2. View Orders");

            int choice = Menus.GetMenuChoice(2);

            switch (choice)
            {
                case 1:
                    // Create order
                    break;
                case 2:
                    // View orders
                    break;
                default:
                    Menus.ShowInvalidInputMessage();
                    break;
            }
        }

        private void LoadProductionWorkerMenu(OrderRepository orderRepository, Order order)
        {
            Console.WriteLine("Production Worker Menu");
            Console.WriteLine("1. View Orders");
            Console.WriteLine("2. Mark Order as Complete");

            int choice = Menus.GetMenuChoice(2);

            switch (choice)
            {
                case 1:
                    // View orders
                    break;
                case 2:
                    // Mark order as complete
                    break;
                default:
                    Menus.ShowInvalidInputMessage();
                    break;
            }
        }

        private void LoadQualityAssuranceMenu(OrderRepository orderRepository, Order order)
        {
            Console.WriteLine("Quality Assurance Menu");
            Console.WriteLine("1. View Orders");
            Console.WriteLine("2. Add Quality Assurance Stamp");

            int choice = Menus.GetMenuChoice(2);

            switch (choice)
            {
                case 1:
                    // View orders
                    break;
                case 2:
                    // Add quality assurance stamp
                    break;
                default:
                    Menus.ShowInvalidInputMessage();
                    break;
            }
        }
    }

}
