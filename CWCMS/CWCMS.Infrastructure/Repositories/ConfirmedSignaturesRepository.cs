using CWCMS.Core.Interfaces;
using PetaPoco;
using System;

namespace CWCMS.Infrastructure.Repositories
{
    public class ConfirmedSignaturesRepository : IConfirmedSignaturesRepository
    {
        private Database _CWDB;

        public ConfirmedSignaturesRepository()
        {
            this._CWDB = new Database("CWCMSConnSecVers");
        }

        public void Add(Core.Models.ConfirmedSignatures confirmedSignaturesRecord)
        {
            _CWDB.Insert(confirmedSignaturesRecord);
        }

        public void Edit(Core.Models.ConfirmedSignatures confirmedSignaturesRecord)
        {
            _CWDB.Update(confirmedSignaturesRecord);
        }

        public System.Collections.Generic.IEnumerable<dynamic> FindConfirmedSignaturesByDocument(Guid documentGUID)
        {
            var list = _CWDB.Fetch<Core.Models.ConfirmedSignatures>("WHERE DocumentID = @0", documentGUID);
            return list;
        }

        public Core.Models.ConfirmedSignatures FindConfirmedSignaturesByID(int confirmedSignatureID)
        {
            var record = _CWDB.Single<Core.Models.ConfirmedSignatures>(confirmedSignatureID);
            return record;
        }

        public System.Collections.Generic.IEnumerable<dynamic> ListConfirmedSignatures()
        {
            var list = _CWDB.Query<Core.Models.ConfirmedSignatures>("SELECT * FROM ConfirmedSignatures");
            return list;
        }

        public void Remove(int confirmedSignatureRecordID)
        {
            _CWDB.Delete(confirmedSignatureRecordID);
        }
    }
}