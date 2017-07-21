using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class WaitSignatureRepository : IWaitSignatureRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(CWCMS.Core.Models.WaitSignature waitSignatureRecord)
        {
            CWDB.Insert(waitSignatureRecord);
        }

        public void Edit(CWCMS.Core.Models.WaitSignature waitSignatureRecord)
        {
            CWDB.Update(waitSignatureRecord);
        }

        public CWCMS.Core.Models.WaitSignature FindWaitSignatureByDocument(Guid documentGUID)
        {
            throw new NotImplementedException();
        }

        public CWCMS.Core.Models.WaitSignature FindWaitSignatureByID(int waitSignatureID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.WaitSignature>(waitSignatureID);
            return record;
        }

        public IEnumerable<dynamic> ListWaitSignature()
        {
            var list = CWDB.Query<CWCMS.Core.Models.WaitSignature>("SELECT * FROM WaitSignature");
            return list;
        }

        public void Remove(int waitSignatureRecordID)
        {
            CWDB.Delete(waitSignatureRecordID);
        }
    }
}