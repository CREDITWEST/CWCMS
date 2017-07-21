using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class QueuedSignaturesRepository : IQueuedSignaturesRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(Core.Models.QueuedSignatures queuedSignaturesRecord)
        {
            CWDB.Insert(queuedSignaturesRecord);
        }

        public void Edit(Core.Models.QueuedSignatures queuedSignaturesRecord)
        {
            CWDB.Update(queuedSignaturesRecord);
        }

        public IEnumerable<dynamic> FindQueuedSignaturesByDocument(Guid documentGUID)
        {
            var list = CWDB.Fetch<Core.Models.QueuedSignatures>("WHERE DocumentID = @0", documentGUID);
            return list;
        }

        public Core.Models.QueuedSignatures FindQueuedSignaturesByID(int queuedSignatureID)
        {
            var record = CWDB.Single<Core.Models.QueuedSignatures>(queuedSignatureID);
            return record;
        }

        public IEnumerable<dynamic> ListQueuedSignatures()
        {
            var list = CWDB.Query<Core.Models.QueuedSignatures>("SELECT * FROM QueuedSignatures");
            return list;
        }

        public void Remove(int queuedSignatureRecordID)
        {
            CWDB.Delete(queuedSignatureRecordID);
        }
    }
}