using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class PostCheckRepository : IPostCheckRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

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
            var record = CWDB.Single<CWCMS.Core.Models.PostCheck>("WHERE DocumentID = @0", documentGUID);
            return record;
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