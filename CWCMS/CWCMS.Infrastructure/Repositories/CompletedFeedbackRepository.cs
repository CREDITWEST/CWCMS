using CWCMS.Core.Interfaces;
using PetaPoco;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class CompletedFeedbackRepository : ICompletedFeedbackRepository
    {
        private Database _CWDB;

        public CompletedFeedbackRepository()
        {
            this._CWDB = new Database("CWCMSConnSecVers");
        }

        public void Add(Core.Models.CompletedFeedback completedFeedbackRecord)
        {
            _CWDB.Insert(completedFeedbackRecord);
        }

        public void Edit(Core.Models.CompletedFeedback completedFeedbackRecord)
        {
            _CWDB.Update(completedFeedbackRecord);
        }

        public Core.Models.CompletedFeedback FindCompletedRecordByID(int completedFeedbackID)
        {
            var record = _CWDB.Single<Core.Models.CompletedFeedback>(completedFeedbackID);
            return record;
        }

        public IEnumerable<dynamic> ListCompletedFeedback()
        {
            var list = _CWDB.Query<Core.Models.CompletedFeedback>("SELECT * FROM CompletedFeedback");
            return list;
        }

        public void Remove(int completedFeedbackRecordID)
        {
            _CWDB.Delete(completedFeedbackRecordID);
        }
    }
}