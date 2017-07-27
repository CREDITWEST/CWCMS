using CWCMS.Core.Interfaces;
using PetaPoco;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class IncompletedFeedbackRepository : IIncompletedFeedbackRepository
    {
        private Database _CWDB;

        public IncompletedFeedbackRepository()
        {
            this._CWDB = new Database("CWCMSConnSecVers");
        }

        public void Add(Core.Models.IncompletedFeedback incompletedFeedbackRecord)
        {
            _CWDB.Insert("IncompletedFEedback", "IncFeedID",true,incompletedFeedbackRecord);
        }

        public void Edit(Core.Models.IncompletedFeedback incompletedFeedbackRecord)
        {
            _CWDB.Update("IncompletedFeedback","IncFeedID",incompletedFeedbackRecord);
        }

        public Core.Models.IncompletedFeedback FindIncompletedRecordByID(int incompletedFeedbackID)
        {
            var record = _CWDB.Single<Core.Models.IncompletedFeedback>(incompletedFeedbackID);
            return record;
        }

        public IEnumerable<dynamic> ListIncompletedFeedback()
        {
            var list = _CWDB.Query<Core.Models.IncompletedFeedback>("SELECT * FROM IncompletedFeedback");
            return list;
        }

        public void Remove(int incompletedFeedbackRecordID)
        {
            _CWDB.Delete(incompletedFeedbackRecordID);
        }
    }
}