using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Budweg.Models;
using Budweg.Repositories;

namespace Budweg.ViewModels
{
    public class OrderController
    {
        public List<Order> RetrieveAllOrders()
        {
            OrderRepository repository = new OrderRepository();

            repository.Load();
            List<Order> orders = repository.GetOrders();
            return orders;

        }
    }
}
