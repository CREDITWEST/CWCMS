﻿using CWCMS.Core.Interfaces;
using PetaPoco;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class CompletedFeedbackRepository : ICompletedFeedbackRepository
    {
        private Database CWDB = new Database(Properties.Settings.CWCMS);

        public void Add(CWCMS.Core.Models.CompletedFeedback completedFeedbackRecord)
        {
            CWDB.Insert(completedFeedbackRecord);
        }

        public void Edit(CWCMS.Core.Models.CompletedFeedback completedFeedbackRecord)
        {
            CWDB.Update(completedFeedbackRecord);
        }

        public CWCMS.Core.Models.CompletedFeedback FindCompletedRecordByID(int completedFeedbackID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.CompletedFeedback>(completedFeedbackID);
            return record;
        }

        public IEnumerable<dynamic> ListCompletedFeedback()
        {
            var list = CWDB.Query<CWCMS.Core.Models.CompletedFeedback>("SELECT * FROM CompletedFeedback");
            return list;
        }

        public void Remove(int completedFeedbackRecordID)
        {
            CWDB.Delete(completedFeedbackRecordID);
        }
    }
}