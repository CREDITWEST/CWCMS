using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class ValidDateRepository : IValidDateRepository
    {
        private Database CWDB = new Database(Properties.Settings.CWCMS);

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