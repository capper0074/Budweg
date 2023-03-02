using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Budweg.Models

{
     public class Order
     {
            public int OrderId { get; set; }
            public Employee Owner { get; set; }
            public string WorkerName { get; set; }
            public bool EndControlStatus { get; set; }
            public bool Assigned { get; set; }
            public int NumberOfCaliber { get; set; }
            public string Comment { get; set; }
            

        public Order(int orderId, Employee owner, string workerName, bool endControlStatus, bool assigned, int numberOfCaliber, string comment)
        {
            OrderId = orderId;
            Owner = owner;
            WorkerName = workerName;
            EndControlStatus = endControlStatus;
            Assigned = assigned;
            NumberOfCaliber = numberOfCaliber;
            Comment = comment;
        }
     }
}

