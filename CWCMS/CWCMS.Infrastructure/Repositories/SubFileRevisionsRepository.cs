using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class SubFileRevisionsRepository : ISubFileRevisionsRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(CWCMS.Core.Models.SubFileRevisions subFileRevisionRecord)
        {
            CWDB.Insert(subFileRevisionRecord);
        }

        public void Edit(CWCMS.Core.Models.SubFileRevisions subFileRevisionRecord)
        {
            CWDB.Update(subFileRevisionRecord);
        }

        public CWCMS.Core.Models.SubFileRevisions FindSubFileRevisionsByID(int subFileRevisionsRecordID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.SubFileRevisions>(subFileRevisionsRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListSubFileRevisions()
        {
            var list = CWDB.Query<CWCMS.Core.Models.SubFileRevisions>("SELECT * FROM SubFileRevisions");
            return list;
        }

        public IEnumerable<dynamic> ListSubFileRevisionsByDocumentType(string documentTypeCode)
        {
            var list = CWDB.Fetch<CWCMS.Core.Models.SubFileRevisions>("WHERE SubFileType = @0", documentTypeCode);
            return list;
        }

        public void Remove(int subFileRevisionRecordID)
        {
            CWDB.Delete(subFileRevisionRecordID);
        }
    }
}