using CWCMS.Core.Interfaces;
using PetaPoco;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class CompletedFeedbackRepository : ICompletedFeedbackRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(Core.Models.CompletedFeedback completedFeedbackRecord)
        {
            CWDB.Insert(completedFeedbackRecord);
        }

        public void Edit(Core.Models.CompletedFeedback completedFeedbackRecord)
        {
            CWDB.Update(completedFeedbackRecord);
        }

        public Core.Models.CompletedFeedback FindCompletedRecordByID(int completedFeedbackID)
        {
            var record = CWDB.Single<Core.Models.CompletedFeedback>(completedFeedbackID);
            return record;
        }

        public IEnumerable<dynamic> ListCompletedFeedback()
        {
            var list = CWDB.Query<Core.Models.CompletedFeedback>("SELECT * FROM CompletedFeedback");
            return list;
        }

        public void Remove(int completedFeedbackRecordID)
        {
            CWDB.Delete(completedFeedbackRecordID);
        }
    }
}