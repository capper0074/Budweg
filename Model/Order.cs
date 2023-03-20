using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budweg2._1.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public Employee Owner { get; set; }
        public int EmployeeId { get; set; }
        public bool EndControl { get; set; }
        public int NumberOfCalibers { get; set; }
        public string CaliberType { get; set; }
        public string Comment { get; set; }

        public Order(int employeeId, string caliberType, int numberOfCalibers, string comment)
        {
            CaliberType = caliberType;
            EmployeeId = employeeId;
            EndControl = false;
            NumberOfCalibers = numberOfCalibers;
            Comment = comment;

        }
        public Order(int orderId, int employeeId, int numberOfCalibers, bool endControl, string comment, string caliberType)
        {
            CaliberType = caliberType;
            OrderId = orderId;
            EmployeeId = employeeId;
            EndControl = endControl;
            NumberOfCalibers = numberOfCalibers;
            Comment = comment;

        }
        public override string ToString()
        {
            return $"{OrderId}, {EmployeeId}, {CaliberType}, {NumberOfCalibers}, {EndControl}, {Comment}";
        }
    }
}
