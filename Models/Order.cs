using Budweg.Models;
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
        public User Owner { get; set; }

        private bool completed;
        public bool QualityAssuranceStamp { get; set; }

        public Order(string name, string description, User owner)
        {
            Name = name;
            Description = description;
            Owner = owner;
            completed = false;
            QualityAssuranceStamp = false;
        }

        public void MarkCompleted(User currentUser)
        {
            if (currentUser.Role == Role.QualityAssurance)
            {
                Console.WriteLine("Has the order been completed? (Y/N)");
                string input = Console.ReadLine();
                if (input.ToLower() == "y")
                {
                    completed = true;
                }
            }
            else
            {
                Console.WriteLine("You do not have permission to mark orders as completed.");
            }
        }

        public bool IsCompleted()
        {
            return completed;
        }
    }

}

