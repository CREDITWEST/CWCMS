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
    class LinkUserFileRepository : ILinkUserFileRepository
    {


        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

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
