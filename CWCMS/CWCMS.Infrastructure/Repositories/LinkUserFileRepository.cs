using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class LinkUserFileRepository : ILinkUserFileRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(Core.Models.LinkUserFile linkUserFileRecord)
        {
            CWDB.Insert(linkUserFileRecord);
        }

        public void Edit(Core.Models.LinkUserFile linkUserFileRecord)
        {
            CWDB.Update(linkUserFileRecord);
        }

        public Core.Models.LinkUserFile FindLinkUserFileByID(int linkUserFileRecordID)
        {
            var record = CWDB.Single<Core.Models.LinkUserFile>(linkUserFileRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListLinkUserFile()
        {
            var list = CWDB.Query<Core.Models.LinkUserFile>("SELECT * FROM LinkUserFile");
            return list;
        }

        public IEnumerable<dynamic> ListLinkUserFileByFile(Guid documentId)
        {
            var list = CWDB.Fetch<Core.Models.LinkUserFile>("WHERE DocumentID = @0", documentId);
            return list;
        }

        public IEnumerable<dynamic> ListLinkUserFileByUser(Guid userId)
        {
            var list = CWDB.Fetch<Core.Models.LinkUserFile>("WHERE UserID = @0", userId);
            return list;
        }

        public void Remove(int linkUserFileRecordID)
        {
            CWDB.Delete(linkUserFileRecordID);
        }
    }
}