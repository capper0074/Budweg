using Budweg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budweg.Views
{
    public class Menus
    {
        public void LoadMenu(User user)
        {
            switch (user.Role)
            {
                case Role.Foreman:
                    Console.WriteLine("Foreman Menu:");
                    Console.WriteLine("1. View all orders");
                    Console.WriteLine("2. Create a new order");
                    Console.WriteLine("3. Update an existing order");
                    Console.WriteLine("4. Delete an order");
                    Console.ReadLine();
                    break;

                case Role.ProductionWorker:
                    Console.WriteLine("Production Worker Menu:");
                    Console.WriteLine("1. View my assigned orders");
                    Console.WriteLine("2. Mark an order as completed");
                    Console.ReadLine();
                    break;

                case Role.QualityAssurance:
                    Console.WriteLine("Quality Assurance Menu:");
                    Console.WriteLine("1. View all orders");
                    Console.WriteLine("2. Approve an order");
                    Console.WriteLine("3. Reject an order");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Unknown role.");
                    break;
            }
        }

    }
}
