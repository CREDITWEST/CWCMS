using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class WaitingForFeedbackRepository : IWaitingForFeedbackRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(Core.Models.WaitingForFeedback waitingForFeedbackRecord)
        {
            CWDB.Insert(waitingForFeedbackRecord);
        }

        public void Edit(Core.Models.WaitingForFeedback waitingForFeedbackRecord)
        {
            CWDB.Update(waitingForFeedbackRecord);
        }

        public Core.Models.WaitingForFeedback FindWaitingForFeedbackByDocument(Guid documentGUID)
        {
            var record = CWDB.Single<Core.Models.WaitingForFeedback>("WHERE DocumentID = @0", documentGUID);
            return record;
        }

        public Core.Models.WaitingForFeedback FindWaitingForFeedbackByID(int waitingForFeedbackID)
        {
            var record = CWDB.Single<Core.Models.WaitingForFeedback>(waitingForFeedbackID);
            return record;
        }

        public IEnumerable<dynamic> ListWaitingForFeedback()
        {
            var list = CWDB.Query<Core.Models.WaitingForFeedback>("SELECT * FROM WaitingForFeedback");
            return list;
        }

        public void Remove(int waitingForFeedbackRecordID)
        {
            CWDB.Delete(waitingForFeedbackRecordID);
        }
    }
}