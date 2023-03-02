using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budweg.Models
{
    public class QualityCheck
    {
        public int ID { get; set; }
        public int LinkedId { get; set; }
        public string DoneBy { get; set; }
        public bool Passed { get; set; }
        public bool Assigned { get; set; }
        public string Forwarding{ get; set; }
        public string Remark { get; set; }

        public QualityCheck(int iD, int linkedId, string doneBy, bool passed, bool assigned, string forwarding, string remark)
        {
            ID = iD;
            LinkedId = linkedId;
            DoneBy = doneBy;
            Passed = passed;
            Assigned = assigned;
            Forwarding = forwarding;
            Remark = remark;
        }
    }
}
