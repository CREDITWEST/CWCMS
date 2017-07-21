using CWCMS.Core.Interfaces;
using PetaPoco;
using System;

namespace CWCMS.Infrastructure.Repositories
{
    public class ConfirmedSignaturesRepository : IConfirmedSignaturesRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(Core.Models.ConfirmedSignatures confirmedSignaturesRecord)
        {
            CWDB.Insert(confirmedSignaturesRecord);
        }

        public void Edit(Core.Models.ConfirmedSignatures confirmedSignaturesRecord)
        {
            CWDB.Update(confirmedSignaturesRecord);
        }

        public System.Collections.Generic.IEnumerable<dynamic> FindConfirmedSignaturesByDocument(Guid documentGUID)
        {
            var list = CWDB.Fetch<Core.Models.ConfirmedSignatures>("WHERE DocumentID = @0", documentGUID);
            return list;
        }

        public Core.Models.ConfirmedSignatures FindConfirmedSignaturesByID(int confirmedSignatureID)
        {
            var record = CWDB.Single<Core.Models.ConfirmedSignatures>(confirmedSignatureID);
            return record;
        }

        public System.Collections.Generic.IEnumerable<dynamic> ListConfirmedSignatures()
        {
            var list = CWDB.Query<Core.Models.ConfirmedSignatures>("SELECT * FROM ConfirmedSignatures");
            return list;
        }

        public void Remove(int confirmedSignatureRecordID)
        {
            CWDB.Delete(confirmedSignatureRecordID);
        }
    }
}