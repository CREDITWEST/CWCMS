using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(Core.Models.Feedback feedbackRecord)
        {
            CWDB.Insert(feedbackRecord);
        }

        public void Edit(Core.Models.Feedback feedbackRecord)
        {
            CWDB.Update(feedbackRecord);
        }

        public Core.Models.Feedback FindFeedbackByID(int feedbackRecordID)
        {
            var record = CWDB.Single<Core.Models.Feedback>(feedbackRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListFeedback()
        {
            var list = CWDB.Query<Core.Models.Feedback>("SELECT * FROM Feedback");
            return list;
        }

        public IEnumerable<dynamic> ListFeedbackRecordsByDocumentID(Guid documentRecordID)
        {
            var list = CWDB.Fetch<Core.Models.Feedback>("WHERE DocumentID = @0", documentRecordID);
            return list;
        }

        public IEnumerable<dynamic> ListFeedbackRecordsBySendDate(DateTime sendingDate)
        {
            var list = CWDB.Fetch<Core.Models.Feedback>("WHERE SendDate = @0", sendingDate);
            return list;
        }

        public IEnumerable<dynamic> ListFeedbackRecordsByUserID(Guid userRecordID)
        {
            var list = CWDB.Fetch<Core.Models.Feedback>("WHERE UserID = @0", userRecordID);
            return list;
        }

        public void Remove(int feedbackRecordID)
        {
            CWDB.Delete(feedbackRecordID);
        }
    }
}