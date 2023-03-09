using Budweg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Budweg.Repositories
{
    public class FinishedOrderRepository
    {

        private List<FinishedOrder> finishedOrders= new List<FinishedOrder>();


        public void Load()
        {

        }

        public void Save() 
        {
            
        }

        public void AddFinishedOrder(FinishedOrder finishedOrder)
        {
            finishedOrders.Add(finishedOrder);
        }

        public void UpdateFinishedOrderQualityId(int id, int newQualityCheckId)
        {
            foreach (FinishedOrder finishedOrder in finishedOrders)
            {
                if (id == finishedOrder.FinishedOrderId)
                {
                    finishedOrder.QualityCheckId = newQualityCheckId;
                }
            }
        }

        public void UpdateFinishedOrderOrderId(int id, int newOrderId)
        {
            foreach (FinishedOrder finishedOrder in finishedOrders)
            {
                if (id == finishedOrder.FinishedOrderId)
                {
                    finishedOrder.OrderId = newOrderId;
                }
            }
        }

        public void DeleteFinishedOrder(int id)
        {
            foreach (FinishedOrder finishedOrder in finishedOrders)
            {
                if (id == finishedOrder.FinishedOrderId)
                {
                    finishedOrders.Remove(finishedOrder);
                }
            }

        }

        public List<FinishedOrder> GetFinishedOrders() 
        {
            return finishedOrders;
        }

        public FinishedOrder GetFinishedOrder(int id) 
        {
            foreach (FinishedOrder finishedOrder in finishedOrders)
            {
                if (id == finishedOrder.FinishedOrderId)
                {
                    return finishedOrder;
                }
            }
            return null;
        }
    }
}
