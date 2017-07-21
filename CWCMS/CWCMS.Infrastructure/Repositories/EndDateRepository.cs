using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CWCMS.Core.Interfaces;
using CWCMS.Core.Models;
using PetaPoco;

namespace CWCMS.Infrastructure.Repositories
{
    class EndDateRepository : IEndDateRepository
    {


        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

        public void Add(CWCMS.Core.Models.EndDate endDateRecord)
        {
            CWDB.Insert(endDateRecord);
        }

        public void Edit(CWCMS.Core.Models.EndDate endDateRecord)
        {
            CWDB.Update(endDateRecord);
        }

        public CWCMS.Core.Models.EndDate FindEndDateRecordByID(int endDateRecordID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.EndDate>(endDateRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListEndDate()
        {
            var list = CWDB.Query<CWCMS.Core.Models.EndDate>("SELECT * FROM EndDate");
            return list;
        }

        public IEnumerable<dynamic> ListEndDateByDate(DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public void Remove(int endDateRecordID)
        {
            CWDB.Delete(endDateRecordID);
        }
    }
}
