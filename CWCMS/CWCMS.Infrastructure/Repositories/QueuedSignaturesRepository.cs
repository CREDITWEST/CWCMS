using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class QueuedSignaturesRepository : IQueuedSignaturesRepository
    {
        private Database _CWDB;

        public QueuedSignaturesRepository()
        {
            this._CWDB = new Database("CWCMSConnection");
        }

        public void Add(Core.Models.QueuedSignatures queuedSignaturesRecord)
        {
            _CWDB.Insert(queuedSignaturesRecord);
        }

        public void Edit(Core.Models.QueuedSignatures queuedSignaturesRecord)
        {
            _CWDB.Update(queuedSignaturesRecord);
        }

        public IEnumerable<dynamic> FindQueuedSignaturesByDocument(Guid documentGUID)
        {
            var list = _CWDB.Fetch<Core.Models.QueuedSignatures>("WHERE DocumentID = @0", documentGUID);
            return list;
        }

        public Core.Models.QueuedSignatures FindQueuedSignaturesByID(int queuedSignatureID)
        {
            var record = _CWDB.Single<Core.Models.QueuedSignatures>(queuedSignatureID);
            return record;
        }

        public IEnumerable<dynamic> ListQueuedSignatures()
        {
            var list = _CWDB.Query<Core.Models.QueuedSignatures>("SELECT * FROM QueuedSignatures");
            return list;
        }

        public void Remove(int queuedSignatureRecordID)
        {
            _CWDB.Delete(queuedSignatureRecordID);
        }
    }
}