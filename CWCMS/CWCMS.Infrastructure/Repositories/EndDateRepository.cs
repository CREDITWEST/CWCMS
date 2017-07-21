using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class EndDateRepository : IEndDateRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(Core.Models.EndDate endDateRecord)
        {
            CWDB.Insert(endDateRecord);
        }

        public void Edit(Core.Models.EndDate endDateRecord)
        {
            CWDB.Update(endDateRecord);
        }

        public Core.Models.EndDate FindEndDateRecordByID(int endDateRecordID)
        {
            var record = CWDB.Single<Core.Models.EndDate>(endDateRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListEndDate()
        {
            var list = CWDB.Query<Core.Models.EndDate>("SELECT * FROM EndDate");
            return list;
        }

        public IEnumerable<dynamic> ListEndDateByDate(DateTime endDate)
        {
            var list = CWDB.Fetch<Core.Models.EndDate>("WHERE ExpirationDate = @0", endDate);
            return list;
        }

        public void Remove(int endDateRecordID)
        {
            CWDB.Delete(endDateRecordID);
        }
    }
}