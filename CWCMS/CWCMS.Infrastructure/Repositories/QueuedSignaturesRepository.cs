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
    class QueuedSignaturesRepository : IQueuedSignaturesRepository
    {


        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

        public void Add(CWCMS.Core.Models.QueuedSignatures queuedSignaturesRecord)
        {
            CWDB.Insert(queuedSignaturesRecord);
        }

        public void Edit(CWCMS.Core.Models.QueuedSignatures queuedSignaturesRecord)
        {
            CWDB.Update(queuedSignaturesRecord);
        }

        public IEnumerable<dynamic> FindQueuedSignaturesByDocument(Guid documentGUID)
        {
            throw new NotImplementedException();
        }

        public CWCMS.Core.Models.QueuedSignatures FindQueuedSignaturesByID(int queuedSignatureID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.QueuedSignatures>(queuedSignatureID);
            return record;
        }

        public IEnumerable<dynamic> ListQueuedSignatures()
        {
            var list = CWDB.Query<CWCMS.Core.Models.QueuedSignatures>("SELECT * FROM QueuedSignatures");
            return list;
        }

        public void Remove(int queuedSignatureRecordID)
        {
            CWDB.Delete(queuedSignatureRecordID);
        }
    }
}
