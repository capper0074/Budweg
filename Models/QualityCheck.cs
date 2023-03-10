using Budweg.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budweg.Models
{
    public class QualityCheck
    {
        public float QualityCheckId { get; set; }
        public int OrderId { get; set; }
        public string DoneBy { get; set; }
        public bool Passed { get; set; }
        public bool Assigned { get; set; }
        public string Remark { get; set; }

        public QualityCheck(int orderId,string doneBy, bool passed, bool assigned, string remark) //linked id in constructor?
        {
            OrderId = orderId;
            DoneBy = doneBy;
            Passed = passed;
            Assigned = assigned;
            Remark = remark;
        }
    }
}
