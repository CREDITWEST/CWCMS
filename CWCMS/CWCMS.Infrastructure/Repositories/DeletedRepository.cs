using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class DeletedRepository : IDeletedRepository
    {
        private Database _CWDB;

        public DeletedRepository()
        {
            this._CWDB = new Database("CWCMSConnSecVers");
        }

        public void Add(Core.Models.Deleted deletedRecord)
        {
            _CWDB.Insert("Deleted","DeletedID",true,deletedRecord);
        }

        public void Edit(Core.Models.Deleted deletedRecord)
        {
            _CWDB.Update("Deleted", "DeletedID",deletedRecord);
        }

        public Core.Models.Deleted FindDeletedByDocument(Guid documentGUID)
        {
            var record = _CWDB.Single<Core.Models.Deleted>("WHERE DocumentID = @0", documentGUID);
            return record;
        }

        public Core.Models.Deleted FindDeletedByID(int deletedID)
        {
            var record = _CWDB.Single<Core.Models.Deleted>(deletedID);
            return record;
        }

        public IEnumerable<dynamic> ListDeleted()
        {
            var list = _CWDB.Query<Core.Models.Deleted>("SELECT * FROM Deleted");
            return list;
        }

        public void Remove(int deletedRecordID)
        {
            _CWDB.Delete(deletedRecordID);
        }
    }
}