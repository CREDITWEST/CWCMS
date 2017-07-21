using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class WaitingSignaturesRepository : IWaitingSignaturesRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(Core.Models.WaitingSignatures waitingSignaturesRecord)
        {
            CWDB.Insert(waitingSignaturesRecord);
        }

        public void Edit(Core.Models.WaitingSignatures waitingSignaturesRecord)
        {
            CWDB.Update(waitingSignaturesRecord);
        }

        public IEnumerable<dynamic> FindWaitingSignaturesByDocument(Guid documentGUID)
        {
            var list = CWDB.Fetch<Core.Models.WaitingSignatures>("WHERE DocumentID = @0", documentGUID);
            return list;
        }

        public Core.Models.WaitingSignatures FindWaitingSignaturesByID(int waitingSignatureID)
        {
            var record = CWDB.Single<Core.Models.WaitingSignatures>(waitingSignatureID);
            return record;
        }

        public IEnumerable<dynamic> ListWaitingSignatures()
        {
            var list = CWDB.Query<Core.Models.WaitingSignatures>("SELECT * FROM WaitingSignatures");
            return list;
        }

        public void Remove(int waitingSignatureRecordID)
        {
            CWDB.Delete(waitingSignatureRecordID);
        }
    }
}