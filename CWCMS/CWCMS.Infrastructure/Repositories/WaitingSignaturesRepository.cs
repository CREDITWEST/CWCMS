using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class WaitingSignaturesRepository : IWaitingSignaturesRepository
    {
        private Database _CWDB;

        public WaitingSignaturesRepository()
        {
            this._CWDB = new Database("CWCMSConnSecVers");
        }

        public void Add(Core.Models.WaitingSignatures waitingSignaturesRecord)
        {
            _CWDB.Insert(waitingSignaturesRecord);
        }

        public void Edit(Core.Models.WaitingSignatures waitingSignaturesRecord)
        {
            _CWDB.Update(waitingSignaturesRecord);
        }

        public IEnumerable<dynamic> FindWaitingSignaturesByDocument(Guid documentGUID)
        {
            var list = _CWDB.Fetch<Core.Models.WaitingSignatures>("WHERE DocumentID = @0", documentGUID);
            return list;
        }

        public Core.Models.WaitingSignatures FindWaitingSignaturesByID(int waitingSignatureID)
        {
            var record = _CWDB.Single<Core.Models.WaitingSignatures>(waitingSignatureID);
            return record;
        }

        public IEnumerable<dynamic> ListWaitingSignatures()
        {
            var list = _CWDB.Query<Core.Models.WaitingSignatures>("SELECT * FROM WaitingSignatures");
            return list;
        }

        public void Remove(int waitingSignatureRecordID)
        {
            _CWDB.Delete(waitingSignatureRecordID);
        }
    }
}