using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class DeletedRepository : IDeletedRepository
    {
        private Database CWDB = new Database(Properties.Settings.CWCMS);

        public void Add(CWCMS.Core.Models.Deleted deletedRecord)
        {
            CWDB.Insert(deletedRecord);
        }

        public void Edit(CWCMS.Core.Models.Deleted deletedRecord)
        {
            CWDB.Update(deletedRecord);
        }

        public CWCMS.Core.Models.Deleted FindDeletedByDocument(Guid documentGUID)
        {
            throw new NotImplementedException();
        }

        public CWCMS.Core.Models.Deleted FindDeletedByID(int deletedID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.Deleted>(deletedID);
            return record;
        }

        public IEnumerable<dynamic> ListDeleted()
        {
            var list = CWDB.Query<CWCMS.Core.Models.Deleted>("SELECT * FROM Deleted");
            return list;
        }

        public void Remove(int deletedRecordID)
        {
            CWDB.Delete(deletedRecordID);
        }
    }
}