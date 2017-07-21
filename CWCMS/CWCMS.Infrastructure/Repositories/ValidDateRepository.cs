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
    class ValidDateRepository : IValidDateRepository
    {


        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

        public void Add(CWCMS.Core.Models.ValidDate validDateRecord)
        {
            CWDB.Insert(validDateRecord);
        }

        public void Edit(CWCMS.Core.Models.ValidDate validDateRecord)
        {
            CWDB.Update(validDateRecord);
        }

        public CWCMS.Core.Models.ValidDate FindValidDateRecordByID(int validDateRecordID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.ValidDate>(validDateRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListValidDate()
        {
            var list = CWDB.Query<CWCMS.Core.Models.ValidDate>("SELECT * FROM ValidDate");
            return list;
        }

        public IEnumerable<dynamic> ListValidDateByDate(DateTime validDate)
        {
            throw new NotImplementedException();
        }

        public void Remove(int validDateRecordID)
        {
            CWDB.Delete(validDateRecordID);
        }
    }
}
