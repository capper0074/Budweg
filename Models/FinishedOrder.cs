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
