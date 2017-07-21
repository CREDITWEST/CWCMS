using CWCMS.Core.Interfaces;
using PetaPoco;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class IncompletedFeedbackRepository : IIncompletedFeedbackRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(Core.Models.IncompletedFeedback incompletedFeedbackRecord)
        {
            CWDB.Insert(incompletedFeedbackRecord);
        }

        public void Edit(Core.Models.IncompletedFeedback incompletedFeedbackRecord)
        {
            CWDB.Update(incompletedFeedbackRecord);
        }

        public Core.Models.IncompletedFeedback FindIncompletedRecordByID(int incompletedFeedbackID)
        {
            var record = CWDB.Single<Core.Models.IncompletedFeedback>(incompletedFeedbackID);
            return record;
        }

        public IEnumerable<dynamic> ListIncompletedFeedback()
        {
            var list = CWDB.Query<Core.Models.IncompletedFeedback>("SELECT * FROM IncompletedFeedback");
            return list;
        }

        public void Remove(int incompletedFeedbackRecordID)
        {
            CWDB.Delete(incompletedFeedbackRecordID);
        }
    }
}