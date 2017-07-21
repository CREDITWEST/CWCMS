using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class LinkUserFileRepository : ILinkUserFileRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(CWCMS.Core.Models.LinkUserFile linkUserFileRecord)
        {
            CWDB.Insert(linkUserFileRecord);
        }

        public void Edit(CWCMS.Core.Models.LinkUserFile linkUserFileRecord)
        {
            CWDB.Update(linkUserFileRecord);
        }

        public CWCMS.Core.Models.LinkUserFile FindLinkUserFileByID(int linkUserFileRecordID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.LinkUserFile>(linkUserFileRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListLinkUserFile()
        {
            var list = CWDB.Query<CWCMS.Core.Models.LinkUserFile>("SELECT * FROM LinkUserFile");
            return list;
        }

        public IEnumerable<dynamic> ListLinkUserFileByFile(Guid documentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<dynamic> ListLinkUserFileByUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public void Remove(int linkUserFileRecordID)
        {
            CWDB.Delete(linkUserFileRecordID);
        }
    }
}