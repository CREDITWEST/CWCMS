using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class LinkUserFileRepository : ILinkUserFileRepository
    {
        private Database _CWDB;

        public LinkUserFileRepository()
        {
            this._CWDB = new Database("CWCMSConnSecVers");
        }

        public void Add(Core.Models.LinkUserFile linkUserFileRecord)
        {
            _CWDB.Insert("LinkUserFile", "LinkUserFileID" ,true, linkUserFileRecord);
        }

        public void Edit(Core.Models.LinkUserFile linkUserFileRecord)
        {
            _CWDB.Update("LinkUserFile", "LinkUserFileID",linkUserFileRecord);
        }

        public Core.Models.LinkUserFile FindLinkUserFileByID(int linkUserFileRecordID)
        {
            var record = _CWDB.Single<Core.Models.LinkUserFile>(linkUserFileRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListLinkUserFile()
        {
            var list = _CWDB.Query<Core.Models.LinkUserFile>("SELECT * FROM LinkUserFile");
            return list;
        }

        public IEnumerable<dynamic> ListLinkUserFileByFile(Guid documentId)
        {
            var list = _CWDB.Fetch<Core.Models.LinkUserFile>("WHERE DocumentID = @0", documentId);
            return list;
        }

        public IEnumerable<dynamic> ListLinkUserFileByUser(Guid userId)
        {
            var list = _CWDB.Fetch<Core.Models.LinkUserFile>("WHERE UserID = @0", userId);
            return list;
        }

        public void Remove(int linkUserFileRecordID)
        {
            _CWDB.Delete(linkUserFileRecordID);
        }
    }
}