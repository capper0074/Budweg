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
            public string Name { get; set; }
            public string Description { get; set; }
            public bool IsCompleted { get; set; }

            public Order (int OrderId, string Name, string Description, bool IsCompleted)
            {
                this.OrderId = OrderId;
                this.Name = Name;
                this.Description = Description;
                this.IsCompleted = IsCompleted;
            }
            
            public Order() : this (0, null, null, false)
            {

            }

        public void CreateOrdre (int OrderId, string Name, string Description, bool IsCompleted)
            {
                
                Order Order1 = new Order(OrderId, Name, Description, IsCompleted);

            } 



     }
}

