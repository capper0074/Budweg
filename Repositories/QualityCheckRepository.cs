﻿using Budweg.Models;
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

        public void Save()
        {

        }

        public void Load()
        {

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
                    qualityCheck.LinkedOrderId = linkedOrderId;
                }
            }
        }

    }
}
