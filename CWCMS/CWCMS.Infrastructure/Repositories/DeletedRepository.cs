using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class DeletedRepository : IDeletedRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(Core.Models.Deleted deletedRecord)
        {
            CWDB.Insert(deletedRecord);
        }

        public void Edit(Core.Models.Deleted deletedRecord)
        {
            CWDB.Update(deletedRecord);
        }

        public Core.Models.Deleted FindDeletedByDocument(Guid documentGUID)
        {
            var record = CWDB.Single<Core.Models.Deleted>("WHERE DocumentID = @0", documentGUID);
            return record;
        }

        public Core.Models.Deleted FindDeletedByID(int deletedID)
        {
            var record = CWDB.Single<Core.Models.Deleted>(deletedID);
            return record;
        }

        public IEnumerable<dynamic> ListDeleted()
        {
            var list = CWDB.Query<Core.Models.Deleted>("SELECT * FROM Deleted");
            return list;
        }

        public void Remove(int deletedRecordID)
        {
            CWDB.Delete(deletedRecordID);
        }
    }
}