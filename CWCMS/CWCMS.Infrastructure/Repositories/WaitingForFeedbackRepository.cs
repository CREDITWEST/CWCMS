using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class WaitingForFeedbackRepository : IWaitingForFeedbackRepository
    {
        private Database _CWDB;

        public WaitingForFeedbackRepository()
        {
            this._CWDB = new Database("CWCMSConnSecVers");
        }

        public void Add(Core.Models.WaitingForFeedback waitingForFeedbackRecord)
        {
            _CWDB.Insert("WaitingForFeedback", "WFFID",true,waitingForFeedbackRecord);
        }

        public void Edit(Core.Models.WaitingForFeedback waitingForFeedbackRecord)
        {
            _CWDB.Update("WaitingForFeedback", "WFFID",waitingForFeedbackRecord);
        }

        public Core.Models.WaitingForFeedback FindWaitingForFeedbackByDocument(Guid documentGUID)
        {
            var record = _CWDB.Single<Core.Models.WaitingForFeedback>("WHERE DocumentID = @0", documentGUID);
            return record;
        }

        public Core.Models.WaitingForFeedback FindWaitingForFeedbackByID(int waitingForFeedbackID)
        {
            var record = _CWDB.Single<Core.Models.WaitingForFeedback>(waitingForFeedbackID);
            return record;
        }

        public IEnumerable<dynamic> ListWaitingForFeedback()
        {
            var list = _CWDB.Query<Core.Models.WaitingForFeedback>("SELECT * FROM WaitingForFeedback");
            return list;
        }

        public void Remove(int waitingForFeedbackRecordID)
        {
            _CWDB.Delete(waitingForFeedbackRecordID);
        }
    }
}