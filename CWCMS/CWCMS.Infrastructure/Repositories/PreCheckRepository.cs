using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class PreCheckRepository : IPreCheckRepository
    {
        private Database CWDB = new Database(Properties.Settings.CWCMS);

        public void Add(CWCMS.Core.Models.PreCheck preCheckRecord)
        {
            CWDB.Insert(preCheckRecord);
        }

        public void Edit(CWCMS.Core.Models.PreCheck preCheckRecord)
        {
            CWDB.Update(preCheckRecord);
        }

        public CWCMS.Core.Models.PreCheck FindPreCheckByDocument(Guid documentGUID)
        {
            throw new NotImplementedException();
        }

        public CWCMS.Core.Models.PreCheck FindPreCheckByID(int preCheckID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.PreCheck>(preCheckID);
            return record;
        }

        public IEnumerable<dynamic> ListPreCheck()
        {
            var list = CWDB.Query<CWCMS.Core.Models.PreCheck>("SELECT * FROM PreCheck");
            return list;
        }

        public void Remove(int preCheckRecordID)
        {
            CWDB.Delete(preCheckRecordID);
        }
    }
}