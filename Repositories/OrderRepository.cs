using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budweg.Models;

namespace Budweg.Repositories
{
    public class OrderRepository
    {

        private List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public void UpdateOrder(Order order)
        {
            var index = orders.FindIndex(o => o.OrderId == order.OrderId);
            if (index != -1)
            {
                orders[index] = order;
            }
        }

        public void DeleteOrder(int id)
        {
            orders.RemoveAll(o => o.OrderId == id);

        }

        public Order GetOrderById(int id)
        {
            return orders.FirstOrDefault(o => o.OrderId == id);
        }

        public List<Order> GetAllOrders()
        {
            return orders;
        }

    }
}
