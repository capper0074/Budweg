using Budweg2._1.Model;
using Budweg2._1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budweg2._1.ViewModel
{
    public class OrderController
    {
        OrderRepository orderRepository = new OrderRepository();
        public List<Order> RetrieveAllOrders()
        {

            orderRepository.Load();
            List<Order> orders = orderRepository.GetOrders();
            return orders;
        }

        public void CreateOrder(int employeeId, string caliberType, int numberOfCalibers, string comment)
        {
            orderRepository.CreateOrder(employeeId, caliberType, numberOfCalibers, comment);
            orderRepository.Save();
        }

        public void DeleteOrder(int id)
        {
            orderRepository.DeleteOrder(id);
        }

        public void UpdateOrder(int id, string column, string newData)
        {
            OrderRepository or = new OrderRepository();
            if (column == "Kaliber mængde" || column == "Medarbejder Id" || column == "Kaliber type" || column == "Ende kontrol" || column == "Kommentar")
            {
                switch (column)
                {
                    case "Kaliber mændge":
                        or.GetOrderById(id).NumberOfCalibers = Convert.ToInt32(newData);
                        break;
                    case "Medarbejder Id":
                        or.GetOrderById(id).EmployeeId = Convert.ToInt32(newData);
                        break;
                    case "Kaliber type":
                        or.GetOrderById(id).CaliberType = newData;
                        break;
                    case "Ende kontrol":
                        or.GetOrderById(id).EndControl = Convert.ToBoolean(newData);
                        break;
                    case "Kommentar":
                        or.GetOrderById(id).Comment = newData;
                        break;
                }

                or.UpdateOrder(id, column, newData);
            }
        }
        //public void UpdateOrder(int id, string newData)
        //{
        //    GetOrderById(id).Comment = newData;
        //}

        //public void UpdateOrder(int id, Employee emp)
        //{
        //    GetOrderById(id).Owner = emp;
        //}
    }
}
