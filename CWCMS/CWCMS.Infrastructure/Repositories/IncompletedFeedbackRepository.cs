using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CWCMS.Core.Interfaces;
using CWCMS.Core.Models;
using PetaPoco;

namespace CWCMS.Infrastructure.Repositories
{
    class IncompletedFeedbackRepository : IIncompletedFeedbackRepository
    {


        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

        public void Add(CWCMS.Core.Models.IncompletedFeedback incompletedFeedbackRecord)
        {
            CWDB.Insert(incompletedFeedbackRecord);
        }

        public void Edit(CWCMS.Core.Models.IncompletedFeedback incompletedFeedbackRecord)
        {
            CWDB.Update(incompletedFeedbackRecord);
        }

        public CWCMS.Core.Models.IncompletedFeedback FindIncompletedRecordByID(int incompletedFeedbackID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.IncompletedFeedback>(incompletedFeedbackID);
            return record;
        }

        public IEnumerable<dynamic> ListIncompletedFeedback()
        {
            var list = CWDB.Query<CWCMS.Core.Models.IncompletedFeedback>("SELECT * FROM IncompletedFeedback");
            return list;
        }

        public void Remove(int incompletedFeedbackRecordID)
        {
            CWDB.Delete(incompletedFeedbackRecordID);
        }
    }
}
