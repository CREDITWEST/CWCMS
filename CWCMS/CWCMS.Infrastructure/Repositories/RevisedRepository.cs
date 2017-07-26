using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class RevisedRepository : IRevisedRepository
    {
        private Database _CWDB;

        public RevisedRepository()
        {
            this._CWDB = new Database("CWCMSConnSecVers");
        }

        public void Add(Core.Models.Revised revisedRecord)
        {
            _CWDB.Insert(revisedRecord);
        }

        public void Edit(Core.Models.Revised revisedRecord)
        {
            _CWDB.Update(revisedRecord);
        }

        public Core.Models.Revised FindRevisedByDocument(Guid documentGUID)
        {
            var record = _CWDB.Single<Core.Models.Revised>("WHERE DocumentID = @0", documentGUID);
            return record;
        }

        public Core.Models.Revised FindRevisedByID(int revisedID)
        {
            var record = _CWDB.Single<Core.Models.Revised>(revisedID);
            return record;
        }

        public IEnumerable<dynamic> ListRevised()
        {
            var list = _CWDB.Query<Core.Models.Revised>("SELECT * FROM Revised");
            return list;
        }

        public void Remove(int revisedRecordID)
        {
            _CWDB.Delete(revisedRecordID);
        }
    }
}