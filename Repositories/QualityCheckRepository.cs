using Budweg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budweg.Repositories
{
    public class QualityCheckRepository
    {
        private List<QualityCheck> qualityChecks = new List<QualityCheck>();
        private string connectionString = "Server=10.56.8.36; database=DB_2023_62; user id=STUDENT_62; password=OPENDB_62";

        public void Save()
        {

        }

        public void Load()
        {

        }

        public QualityCheck CreateQualityCheck(int orderId, string doneBy, bool passed, bool assigned, string remark)
        {
            QualityCheck qualityCheck = new QualityCheck(orderId, doneBy, passed, assigned, remark);
            AddQualityCheck(qualityCheck);
            return qualityCheck;
        }

        public void AddQualityCheck(QualityCheck qualityCheck)
        {
            qualityChecks.Add(qualityCheck);
        }

        public void UpdateQualityCheck(QualityCheck qualityCheck)
        {

        }

        public void DeleteQualityCheck(int id)
        {
            for (int i = 0; i < qualityChecks.Count; i++)
            {
                if (qualityChecks[i].QualityCheckId == id)
                {
                    qualityChecks.Remove(qualityChecks[i]);
                }
            }
        }

        public QualityCheck GetQualityCheckById(int id)
        {
            if (id > 0)
            {
                for (int i = id; i < qualityChecks.Count(); i++)
                {
                    if (qualityChecks[i].QualityCheckId == id)
                    {
                        return qualityChecks[i];
                    }
                }
            }
            return null;
        }

        public void LinkQualityCheck(int id, int linkedOrderId)
        {
            foreach (QualityCheck qualityCheck in qualityChecks)
            {
                if (qualityCheck.QualityCheckId == id)
                {
                    qualityCheck.OrderId = linkedOrderId;
                }
            }
        }

    }
}
