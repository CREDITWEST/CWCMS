using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class ValidDateRepository : IValidDateRepository
    {
        private Database _CWDB;

        public ValidDateRepository()
        {
            this._CWDB = new Database("CWCMSConnection");
        }

        public void Add(Core.Models.ValidDate validDateRecord)
        {
            _CWDB.Insert(validDateRecord);
        }

        public void Edit(Core.Models.ValidDate validDateRecord)
        {
            _CWDB.Update(validDateRecord);
        }

        public Core.Models.ValidDate FindValidDateRecordByID(int validDateRecordID)
        {
            var record = _CWDB.Single<Core.Models.ValidDate>(validDateRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListValidDate()
        {
            var list = _CWDB.Query<Core.Models.ValidDate>("SELECT * FROM ValidDate");
            return list;
        }

        public IEnumerable<dynamic> ListValidDateByDate(DateTime validDate)
        {
            var list = _CWDB.Fetch<Core.Models.ValidDate>("WHERE ValidationDate = @0", validDate);
            return list;
        }

        public void Remove(int validDateRecordID)
        {
            _CWDB.Delete(validDateRecordID);
        }
    }
}