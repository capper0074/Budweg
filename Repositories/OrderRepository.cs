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

        public List<Order> GetOrders()
        {
            return orders;
        }

        public Order GetOrderById(int id) 
        {
            foreach (Order order in orders) 
            {   
                if (order.OrderId == id)
                {
                    return order;
                }
            }
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

        public List<Order> GetAssignedOrders()
        {
            return orders.FindAll(o => o.Assigned != false);
        }

        public void UpdateOrder(int id, int choice, int newData)
        {
            if (id > 0 && id < 2)
            {
                switch (choice)
                {
                    case 1:
                        GetOrderById(id).NumberOfCaliber = newData;
                        break;
                    case 2:
                        GetOrderById(id).EmplyoeeId = newData;
                        break;
                }

            }
        }
        public void UpdateOrder(int id, string newData)
        {
          GetOrderById(id).Comment = newData;
        }

        public void UpdateOrder(int id, Employee emp)
        {
            GetOrderById(id).Owner = emp;
        }

        public void AssignOrder(int orderId, int emplyoeeId)
        {
            foreach (Order order in orders)
            {
                if (order.OrderId == orderId)
                {
                    order.EmplyoeeId = emplyoeeId;
                }
            }
        }
    }
}
