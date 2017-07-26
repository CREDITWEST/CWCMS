using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private Database _CWDB;

        public FeedbackRepository()
        {
            this._CWDB = new Database("CWCMSConnSecVers");
        }

        public void Add(Core.Models.Feedback feedbackRecord)
        {
            _CWDB.Insert("Feedback","FeedbackID",true,feedbackRecord);
        }

        public void Edit(Core.Models.Feedback feedbackRecord)
        {
            _CWDB.Update("Feedback", "FeedbackID",feedbackRecord);
        }

        public Core.Models.Feedback FindFeedbackByID(int feedbackRecordID)
        {
            var record = _CWDB.Single<Core.Models.Feedback>(feedbackRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListFeedback()
        {
            var list = _CWDB.Query<Core.Models.Feedback>("SELECT * FROM Feedback");
            return list;
        }

        public IEnumerable<dynamic> ListFeedbackRecordsByDocumentID(Guid documentRecordID)
        {
            var list = _CWDB.Fetch<Core.Models.Feedback>("WHERE DocumentID = @0", documentRecordID);
            return list;
        }

        public IEnumerable<dynamic> ListFeedbackRecordsBySendDate(DateTime sendingDate)
        {
            var list = _CWDB.Fetch<Core.Models.Feedback>("WHERE SendDate = @0", sendingDate);
            return list;
        }

        public IEnumerable<dynamic> ListFeedbackRecordsByUserID(Guid userRecordID)
        {
            var list = _CWDB.Fetch<Core.Models.Feedback>("WHERE UserID = @0", userRecordID);
            return list;
        }

        public void Remove(int feedbackRecordID)
        {
            _CWDB.Delete(feedbackRecordID);
        }
    }
}