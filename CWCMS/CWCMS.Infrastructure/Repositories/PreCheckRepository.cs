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
    class PreCheckRepository : IPreCheckRepository
    {


        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

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
