using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budweg.Models;
using Budweg.Views;

namespace Budweg.Repositories
{
    public class OrderRepository
    {

        private List<Order> orders;

        public OrderRepository()
        {
            orders = new List<Order>();
        }
  
        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public void UpdateOrder(Order order)
        {
            
            int index = orders.FindIndex(o => o.OrderId == order.OrderId);
            if (index != -1)
            {
                orders[index] = order;
            }
        }

        public void DeleteOrder(Order order)
        {
            orders.Remove(order);

        }

        public Order GetOrderById(int id)
        {
            return orders.Find(o => o.OrderId == id);
        }

        public List<Order> GetAllOrders()
        {
            return orders;
        }

        public Order CreateOrder(string name, string description, int OrderId)
        {
            Order order = new Order()
            {
                Name = name,
                Description = description,
                OrderId = OrderId,
                IsCompleted = false,
                QualityAssuranceStamp = false

            };

            AddOrder(order);

            return order;
        }
       


    }
    
}
