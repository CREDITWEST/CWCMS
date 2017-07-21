using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class WaitSignatureRepository : IWaitSignatureRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(Core.Models.WaitSignature waitSignatureRecord)
        {
            CWDB.Insert(waitSignatureRecord);
        }

        public void Edit(Core.Models.WaitSignature waitSignatureRecord)
        {
            CWDB.Update(waitSignatureRecord);
        }

        public Core.Models.WaitSignature FindWaitSignatureByDocument(Guid documentGUID)
        {
            var record = CWDB.Single<Core.Models.WaitSignature>("WHERE DocumentID = @0", documentGUID);
            return record;
        }

        public Core.Models.WaitSignature FindWaitSignatureByID(int waitSignatureID)
        {
            var record = CWDB.Single<Core.Models.WaitSignature>(waitSignatureID);
            return record;
        }

        public IEnumerable<dynamic> ListWaitSignature()
        {
            var list = CWDB.Query<Core.Models.WaitSignature>("SELECT * FROM WaitSignature");
            return list;
        }

        public void Remove(int waitSignatureRecordID)
        {
            CWDB.Delete(waitSignatureRecordID);
        }
    }
}