using Budweg.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budweg.Models
{
    public class FinishedOrder
    {
        public int OrderId { get; set; }
        public int QualityCheckId { get; set; }
        public bool EndComplete { get; set; }

        public FinishedOrder(int qualityCheckId, bool endComplete)
        {
            QualityCheckId = qualityCheckId;
            EndComplete = endComplete;
        }
    }
}
