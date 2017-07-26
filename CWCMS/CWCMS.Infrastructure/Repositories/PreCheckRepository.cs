using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class PreCheckRepository : IPreCheckRepository
    {
        private Database _CWDB;

        public PreCheckRepository()
        {
            this._CWDB = new Database("CWCMSConnSecVers");
        }

        public void Add(Core.Models.PreCheck preCheckRecord)
        {
            _CWDB.Insert(preCheckRecord);
        }

        public void Edit(Core.Models.PreCheck preCheckRecord)
        {
            _CWDB.Update(preCheckRecord);
        }

        public Core.Models.PreCheck FindPreCheckByDocument(Guid documentGUID)
        {
            var record = _CWDB.Single<Core.Models.PreCheck>("WHERE DocumentID = @0", documentGUID);
            return record;
        }

        public Core.Models.PreCheck FindPreCheckByID(int preCheckID)
        {
            var record = _CWDB.Single<Core.Models.PreCheck>(preCheckID);
            return record;
        }

        public IEnumerable<dynamic> ListPreCheck()
        {
            var list = _CWDB.Query<Core.Models.PreCheck>("SELECT * FROM PreCheck");
            return list;
        }

        public void Remove(int preCheckRecordID)
        {
            _CWDB.Delete(preCheckRecordID);
        }
    }
}