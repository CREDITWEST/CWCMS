using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class CancelledRepository : ICancelledRepository
    {
        private Database CWDB = new Database(Properties.Settings.CWCMS);

        public void Add(CWCMS.Core.Models.Cancelled cancelledRecord)
        {
            CWDB.Insert(cancelledRecord);
        }

        public void Edit(CWCMS.Core.Models.Cancelled cancelledRecord)
        {
            CWDB.Update(cancelledRecord);
        }

        CWCMS.Core.Models.Cancelled ICancelledRepository.FindCancelledByID(int cancelledID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.Cancelled>(cancelledID);
            return record;
        }

        CWCMS.Core.Models.Cancelled ICancelledRepository.FindCancelledByDocument(Guid documentGUID)
        {
            throw new NotImplementedException();
        }

        public void Remove(int cancelledRecordID)
        {
            CWDB.Delete(cancelledRecordID);
        }

        public IEnumerable<dynamic> ListCancelled()
        {
            var list = CWDB.Query<CWCMS.Core.Models.Cancelled>("SELECT * FROM Cancelled");
            return list;
        }
    }
}