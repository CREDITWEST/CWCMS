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
    class PostCheckRepository : IPostCheckRepository
    {


        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

        public void Add(CWCMS.Core.Models.PostCheck postCheckRecord)
        {
            CWDB.Insert(postCheckRecord);
        }

        public void Edit(CWCMS.Core.Models.PostCheck postCheckRecord)
        {
            CWDB.Update(postCheckRecord);
        }

        public CWCMS.Core.Models.PostCheck FindPostCheckByDocument(Guid documentGUID)
        {
            throw new NotImplementedException();
        }

        public CWCMS.Core.Models.PostCheck FindPostCheckByID(int postCheckID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.PostCheck>(postCheckID);
            return record;
        }

        public IEnumerable<dynamic> ListPostCheck()
        {
            var list = CWDB.Query<CWCMS.Core.Models.PostCheck>("SELECT * FROM PostCheck");
            return list;
        }

        public void Remove(int postCheckRecordID)
        {
            CWDB.Delete(postCheckRecordID);
        }
    }
}
