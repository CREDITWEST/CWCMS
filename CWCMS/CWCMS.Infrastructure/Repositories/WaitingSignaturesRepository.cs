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
    class WaitingSignaturesRepository : IWaitingSignaturesRepository
    {


        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

        public void Add(CWCMS.Core.Models.WaitingSignatures waitingSignaturesRecord)
        {
            CWDB.Insert(waitingSignaturesRecord);
        }

        public void Edit(CWCMS.Core.Models.WaitingSignatures waitingSignaturesRecord)
        {
            CWDB.Update(waitingSignaturesRecord);
        }

        public IEnumerable<dynamic> FindWaitingSignaturesByDocument(Guid documentGUID)
        {
            throw new NotImplementedException();
        }

        public CWCMS.Core.Models.WaitingSignatures FindWaitingSignaturesByID(int waitingSignatureID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.WaitingSignatures>(waitingSignatureID);
            return record;
        }

        public IEnumerable<dynamic> ListWaitingSignatures()
        {
            var list = CWDB.Query<CWCMS.Core.Models.WaitingSignatures>("SELECT * FROM WaitingSignatures");
            return list;
        }

        public void Remove(int waitingSignatureRecordID)
        {
            CWDB.Delete(waitingSignatureRecordID);
        }
    }
}
