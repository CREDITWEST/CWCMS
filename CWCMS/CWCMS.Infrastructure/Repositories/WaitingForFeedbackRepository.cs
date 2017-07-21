using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class WaitingForFeedbackRepository : IWaitingForFeedbackRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(CWCMS.Core.Models.WaitingForFeedback waitingForFeedbackRecord)
        {
            CWDB.Insert(waitingForFeedbackRecord);
        }

        public void Edit(CWCMS.Core.Models.WaitingForFeedback waitingForFeedbackRecord)
        {
            CWDB.Update(waitingForFeedbackRecord);
        }

        public CWCMS.Core.Models.WaitingForFeedback FindWaitingForFeedbackByDocument(Guid documentGUID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.WaitingForFeedback>("WHERE DocumentID = @0", documentGUID);
            return record;
        }

        public CWCMS.Core.Models.WaitingForFeedback FindWaitingForFeedbackByID(int waitingForFeedbackID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.WaitingForFeedback>(waitingForFeedbackID);
            return record;
        }

        public IEnumerable<dynamic> ListWaitingForFeedback()
        {
            var list = CWDB.Query<CWCMS.Core.Models.WaitingForFeedback>("SELECT * FROM WaitingForFeedback");
            return list;
        }

        public void Remove(int waitingForFeedbackRecordID)
        {
            CWDB.Delete(waitingForFeedbackRecordID);
        }
    }
}