﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        private List<Order> displayOrders = new List<Order>();

        private string connectionString = "Server=10.56.8.36; database=DB_2023_62; user id=STUDENT_62; password=OPENDB_62";

        public void Save()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                foreach (Order orders in orders)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO ORDERS(EmployeeId, EndControl, NumberOfCalibers, Comment)" +
                                                 "VALUES(@EmployeeId, @EndControl, @NumberOfCalibers, @Comment);", con);
                    cmd.Parameters.AddWithValue("@EmployeeId", orders.EmployeeId);
                    cmd.Parameters.AddWithValue("@EndControl", orders.EndControl);
                    cmd.Parameters.AddWithValue("@NumberOfCalibers", orders.NumberOfCalibers);
                    cmd.Parameters.AddWithValue("@Comment", orders.Comment);
                    cmd.ExecuteNonQuery();
                }
                orders.Clear();
            }
        }

        public void Load()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT OrderId, EmployeeId, NumberOfCalibers, EndControl, Comment FROM ORDERS", con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Order order = new Order(Convert.ToInt32(reader["OrderId"]),Convert.ToInt32(reader["EmployeeId"]), Convert.ToInt32
                            (reader["NumberOfCalibers"]), Convert.ToBoolean(reader["EndControl"]), reader["Comment"].ToString());
                            displayOrders.Add(order);
                    }
                }
            }
        }


        public Order CreateOrder(int employeeId, int numberOfCalibers, bool assigned, string comment)
        {
            Order order = new Order(employeeId, numberOfCalibers, comment, assigned);
            AddOrder(order);
            return order;
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
            if (choice > 0 && choice < 2)
            {
                switch (choice)
                {
                    case 1:
                        GetOrderById(id).NumberOfCalibers = newData;
                        break;
                    case 2:
                        GetOrderById(id).EmployeeId = newData;
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
                    order.EmployeeId = emplyoeeId;
                }
            }
        }
    }
}
