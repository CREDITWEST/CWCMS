using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class RevisedRepository : IRevisedRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(CWCMS.Core.Models.Revised revisedRecord)
        {
            CWDB.Insert(revisedRecord);
        }

        public void Edit(CWCMS.Core.Models.Revised revisedRecord)
        {
            CWDB.Update(revisedRecord);
        }

        public CWCMS.Core.Models.Revised FindRevisedByDocument(Guid documentGUID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.Revised>("WHERE DocumentID = @0", documentGUID);
            return record;
        }

        public CWCMS.Core.Models.Revised FindRevisedByID(int revisedID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.Revised>(revisedID);
            return record;
        }

        public IEnumerable<dynamic> ListRevised()
        {
            var list = CWDB.Query<CWCMS.Core.Models.Revised>("SELECT * FROM Revised");
            return list;
        }

        public void Remove(int revisedRecordID)
        {
            CWDB.Delete(revisedRecordID);
        }
    }
}