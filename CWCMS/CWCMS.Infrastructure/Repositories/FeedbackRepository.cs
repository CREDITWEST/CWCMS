using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class FeedbackRepository : IFeedbackRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(CWCMS.Core.Models.Feedback feedbackRecord)
        {
            CWDB.Insert(feedbackRecord);
        }

        public void Edit(CWCMS.Core.Models.Feedback feedbackRecord)
        {
            CWDB.Update(feedbackRecord);
        }

        public CWCMS.Core.Models.Feedback FindFeedbackByID(int feedbackRecordID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.Feedback>(feedbackRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListFeedback()
        {
            var list = CWDB.Query<CWCMS.Core.Models.Feedback>("SELECT * FROM Feedback");
            return list;
        }

        public IEnumerable<dynamic> ListFeedbackRecordsByDocumentID(Guid documentRecordID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<dynamic> ListFeedbackRecordsBySendDate(DateTime sendingDate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<dynamic> ListFeedbackRecordsByUserID(Guid userRecordID)
        {
            throw new NotImplementedException();
        }

        public void Remove(int feedbackRecordID)
        {
            CWDB.Delete(feedbackRecordID);
        }
    }
}