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
    class WaitSignatureRepository : IWaitSignatureRepository
    {


        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

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
