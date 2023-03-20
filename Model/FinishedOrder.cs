using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budweg2._1.Model
{
    public class FinishedOrder
    {
        public int FinishedOrderId { get; set; }
        public int OrderId { get; set; }
        public int QualityCheckId { get; set; }

        public FinishedOrder(int qualityCheckId, int orderId)
        {
            OrderId = orderId;
            QualityCheckId = qualityCheckId;
        }
    }
}
