using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class EndDateRepository : IEndDateRepository
    {
        private Database _CWDB;

        public EndDateRepository()
        {
            this._CWDB = new Database("CWCMSConnSecVers");
        }

        public void Add(Core.Models.EndDate endDateRecord)
        {
            _CWDB.Insert("EndDate","EndDateID",true,endDateRecord);
        }

        public void Edit(Core.Models.EndDate endDateRecord)
        {
            _CWDB.Update("EndDate", "EndDateID",endDateRecord);
        }

        public Core.Models.EndDate FindEndDateRecordByID(int endDateRecordID)
        {
            var record = _CWDB.Single<Core.Models.EndDate>(endDateRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListEndDate()
        {
            var list = _CWDB.Query<Core.Models.EndDate>("SELECT * FROM EndDate");
            return list;
        }

        public IEnumerable<dynamic> ListEndDateByDate(DateTime endDate)
        {
            var list = _CWDB.Fetch<Core.Models.EndDate>("WHERE ExpirationDate = @0", endDate);
            return list;
        }

        public IEnumerable<dynamic> ListEndDateByGuid(Guid documentID)
        {
            var list = _CWDB.Fetch<Core.Models.EndDate>("WHERE DocumentID = @0", documentID);
            return list;
        }

        public void Remove(int endDateRecordID)
        {
            _CWDB.Delete(endDateRecordID);
        }
    }
}