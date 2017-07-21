using System;
using CWCMS.Core.Interfaces;
using CWCMS.Core.Models;
using PetaPoco;

namespace CWCMS.Infrastructure.Repositories
{
    public class ConfirmedSignaturesRepository : IConfirmedSignaturesRepository
    {

        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

        public void Add(CWCMS.Core.Models.ConfirmedSignatures confirmedSignaturesRecord)
        {
            CWDB.Insert(confirmedSignaturesRecord);
        }

        public void Edit(CWCMS.Core.Models.ConfirmedSignatures confirmedSignaturesRecord)
        {
            CWDB.Update(confirmedSignaturesRecord);
        }

        public System.Collections.Generic.IEnumerable<dynamic> FindConfirmedSignaturesByDocument(Guid documentGUID)
        {
            throw new NotImplementedException();
        }

        public CWCMS.Core.Models.ConfirmedSignatures FindConfirmedSignaturesByID(int confirmedSignatureID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.ConfirmedSignatures>(confirmedSignatureID);
            return record;
        }

        public System.Collections.Generic.IEnumerable<dynamic> ListConfirmedSignatures()
        {
            var list = CWDB.Query<CWCMS.Core.Models.ConfirmedSignatures>("SELECT * FROM ConfirmedSignatures");
            return list;
        }

        public void Remove(int confirmedSignatureRecordID)
        {
            CWDB.Delete(confirmedSignatureRecordID);
        }
    }
}