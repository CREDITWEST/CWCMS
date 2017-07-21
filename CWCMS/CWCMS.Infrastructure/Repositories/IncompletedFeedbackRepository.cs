﻿using CWCMS.Core.Interfaces;
using PetaPoco;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class IncompletedFeedbackRepository : IIncompletedFeedbackRepository
    {
        private Database CWDB = new Database(Properties.Settings.CWCMS);

        public void Add(CWCMS.Core.Models.IncompletedFeedback incompletedFeedbackRecord)
        {
            CWDB.Insert(incompletedFeedbackRecord);
        }

        public void Edit(CWCMS.Core.Models.IncompletedFeedback incompletedFeedbackRecord)
        {
            CWDB.Update(incompletedFeedbackRecord);
        }

        public CWCMS.Core.Models.IncompletedFeedback FindIncompletedRecordByID(int incompletedFeedbackID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.IncompletedFeedback>(incompletedFeedbackID);
            return record;
        }

        public IEnumerable<dynamic> ListIncompletedFeedback()
        {
            var list = CWDB.Query<CWCMS.Core.Models.IncompletedFeedback>("SELECT * FROM IncompletedFeedback");
            return list;
        }

        public void Remove(int incompletedFeedbackRecordID)
        {
            CWDB.Delete(incompletedFeedbackRecordID);
        }
    }
}