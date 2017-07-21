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
    class WaitingForFeedbackRepository : IWaitingForFeedbackRepository
    {


        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

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
            throw new NotImplementedException();
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
