using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budweg.Models;

namespace Budweg.Repositories
{
    public class OrderRepository
    {
        private List<Order> orders = new List<Order>();

        public void Save()
        {

        }

        public void Load()
        {

        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public Order GetOrders()
        {
            return null;
        }

        public void GetUnassignedOrders(Order order)
        {
            for (int i = 0; i < orders.Count(); i++)
            {
                if (orders[i].Assigned != true)
                {
                    List<Order> UnAssignedOrders = new List<Order>();
                    UnAssignedOrders.Add(orders[i]);
                }
            }
        }

        public void GetassignedOrders(Order order)
        {
            for (int i = 0; i < orders.Count(); i++)
            {
                if (orders[i].Assigned == true)
                {
                    List<Order> AssignedOrders = new List<Order>();
                    AssignedOrders.Add(orders[i]);
                }
            }
        }

        public void UpdateOrderStatus(int orderId, bool status)
        {

        }

        public void AssignOrder(int orderId, string AssemblyWorker)
        {

        }
    }
}
