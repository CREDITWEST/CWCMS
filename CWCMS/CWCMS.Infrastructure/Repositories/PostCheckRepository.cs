using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class PostCheckRepository : IPostCheckRepository
    {
        private Database _CWDB;

        public PostCheckRepository()
        {
            this._CWDB = new Database("CWCMSConnSecVers");
        }

        public void Add(Core.Models.PostCheck postCheckRecord)
        {
            _CWDB.Insert("PostCheck", "PostID",true,postCheckRecord);
        }

        public void Edit(Core.Models.PostCheck postCheckRecord)
        {
            _CWDB.Update("PostCheck", "PostID", postCheckRecord);
        }

        public Core.Models.PostCheck FindPostCheckByDocument(Guid documentGUID)
        {
            var record = _CWDB.Single<Core.Models.PostCheck>("WHERE DocumentID = @0", documentGUID);
            return record;
        }

        public Core.Models.PostCheck FindPostCheckByID(int postCheckID)
        {
            var record = _CWDB.Single<Core.Models.PostCheck>(postCheckID);
            return record;
        }

        public IEnumerable<dynamic> ListPostCheck()
        {
            var list = _CWDB.Query<Core.Models.PostCheck>("SELECT * FROM PostCheck");
            return list;
        }

        public void Remove(int postCheckRecordID)
        {
            _CWDB.Delete(postCheckRecordID);
        }
    }
}