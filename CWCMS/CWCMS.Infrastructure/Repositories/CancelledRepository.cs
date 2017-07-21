using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class CancelledRepository : ICancelledRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(Core.Models.Cancelled cancelledRecord)
        {
            CWDB.Insert(cancelledRecord);
        }

        public void Edit(Core.Models.Cancelled cancelledRecord)
        {
            CWDB.Update(cancelledRecord);
        }

        Core.Models.Cancelled ICancelledRepository.FindCancelledByID(int cancelledID)
        {
            var record = CWDB.Single<Core.Models.Cancelled>(cancelledID);
            return record;
        }

        Core.Models.Cancelled ICancelledRepository.FindCancelledByDocument(Guid documentGUID)
        {
            var record = CWDB.Single<Core.Models.Cancelled>("WHERE DocumentID = @0", documentGUID);
            return record;
        }

        public void Remove(int cancelledRecordID)
        {
            CWDB.Delete(cancelledRecordID);
        }

        public IEnumerable<dynamic> ListCancelled()
        {
            var list = CWDB.Query<Core.Models.Cancelled>("SELECT * FROM Cancelled");
            return list;
        }
    }
}