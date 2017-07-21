using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class PostCheckRepository : IPostCheckRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(Core.Models.PostCheck postCheckRecord)
        {
            CWDB.Insert(postCheckRecord);
        }

        public void Edit(Core.Models.PostCheck postCheckRecord)
        {
            CWDB.Update(postCheckRecord);
        }

        public Core.Models.PostCheck FindPostCheckByDocument(Guid documentGUID)
        {
            var record = CWDB.Single<Core.Models.PostCheck>("WHERE DocumentID = @0", documentGUID);
            return record;
        }

        public Core.Models.PostCheck FindPostCheckByID(int postCheckID)
        {
            var record = CWDB.Single<Core.Models.PostCheck>(postCheckID);
            return record;
        }

        public IEnumerable<dynamic> ListPostCheck()
        {
            var list = CWDB.Query<Core.Models.PostCheck>("SELECT * FROM PostCheck");
            return list;
        }

        public void Remove(int postCheckRecordID)
        {
            CWDB.Delete(postCheckRecordID);
        }
    }
}