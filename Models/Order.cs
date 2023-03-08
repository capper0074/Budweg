using Budweg.Repositories;
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
            public int EmplyoeeId { get; set; }
            public bool EndControlStatus { get; set; }
            public bool Assigned { get; set; }
            public int NumberOfCaliber { get; set; }
            public string Comment { get; set; }
            

        public Order(Employee owner, int numberOfCaliber, string comment)
        {
            Owner = owner;
            EndControlStatus = false;
            NumberOfCaliber = numberOfCaliber;
            Comment = comment;
        }
     }
}

