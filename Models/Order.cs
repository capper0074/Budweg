using Budweg.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Budweg.Models

{
    public class Order
    {
        public int OrderId { get; set; }
        public Employee Owner { get; set; }
        public int EmployeeId { get; set; }
        public bool EndControl { get; set; }
        public bool Assigned { get; set; }
        public int NumberOfCalibers { get; set; }
        public string Comment { get; set; }

        public Order(int employeeId, int numberOfCalibers, string comment)
        {
            EmployeeId = employeeId;
            EndControl = false;
            NumberOfCalibers = numberOfCalibers;
            Comment = comment;
     
        }
        public Order(int orderId, int employeeId, int numberOfCalibers, bool endControl, string comment)
        {
            OrderId = orderId;
            EmployeeId = employeeId;
            EndControl = endControl;
            NumberOfCalibers = numberOfCalibers;
            Comment = comment;

        }
        public override string ToString()
        {
            return $"{OrderId}, {EmployeeId}, {NumberOfCalibers}, {EndControl}, {Comment}";
        }
    }
}

