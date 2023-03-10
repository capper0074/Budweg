using Budweg.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Budweg.Repositories
{
    public class FinishedOrderRepository
    {

        private List<FinishedOrder> finishedOrders = new List<FinishedOrder>();
        private string connectionString = "Server=10.56.8.36; database=DB_2023_62; user id=STUDENT_62; password=OPENDB_62";

        public void Load()
        {
           
           
        }

        public void Save() 
        {
            
        }

        public FinishedOrder CreateFinishedOrder(int qualityCheckId, int orderId)
        {
            FinishedOrder fOrder = new FinishedOrder(qualityCheckId, orderId);
            AddFinishedOrder(fOrder);
            return fOrder;
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
