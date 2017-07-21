using CWCMS.Core.Interfaces;
using PetaPoco;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class SubFileRevisionsRepository : ISubFileRevisionsRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(Core.Models.SubFileRevisions subFileRevisionRecord)
        {
            CWDB.Insert(subFileRevisionRecord);
        }

        public void Edit(Core.Models.SubFileRevisions subFileRevisionRecord)
        {
            CWDB.Update(subFileRevisionRecord);
        }

        public Core.Models.SubFileRevisions FindSubFileRevisionsByID(int subFileRevisionsRecordID)
        {
            var record = CWDB.Single<Core.Models.SubFileRevisions>(subFileRevisionsRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListSubFileRevisions()
        {
            var list = CWDB.Query<Core.Models.SubFileRevisions>("SELECT * FROM SubFileRevisions");
            return list;
        }

        public IEnumerable<dynamic> ListSubFileRevisionsByDocumentType(string documentTypeCode)
        {
            var list = CWDB.Fetch<Core.Models.SubFileRevisions>("WHERE SubFileType = @0", documentTypeCode);
            return list;
        }

        public void Remove(int subFileRevisionRecordID)
        {
            CWDB.Delete(subFileRevisionRecordID);
        }
    }
}