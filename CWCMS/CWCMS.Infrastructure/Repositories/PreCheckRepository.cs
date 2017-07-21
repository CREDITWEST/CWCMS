using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class PreCheckRepository : IPreCheckRepository
    {
        public Database CWDB = new Database("CWCMSConnection");

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
            var record = CWDB.Single<CWCMS.Core.Models.PreCheck>("WHERE DocumentID = @0", documentGUID);
            return record;
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