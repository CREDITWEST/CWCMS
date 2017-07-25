using CWCMS.Core.Interfaces;
using PetaPoco;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class SubFileRevisionsRepository : ISubFileRevisionsRepository
    {
        private Database _CWDB;

        public SubFileRevisionsRepository()
        {
            this._CWDB = new Database("CWCMSConnection");
        }

        public void Add(Core.Models.SubFileRevisions subFileRevisionRecord)
        {
            _CWDB.Insert(subFileRevisionRecord);
        }

        public void Edit(Core.Models.SubFileRevisions subFileRevisionRecord)
        {
            _CWDB.Update(subFileRevisionRecord);
        }

        public Core.Models.SubFileRevisions FindSubFileRevisionsByID(int subFileRevisionsRecordID)
        {
            var record = _CWDB.Single<Core.Models.SubFileRevisions>(subFileRevisionsRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListSubFileRevisions()
        {
            var list = _CWDB.Query<Core.Models.SubFileRevisions>("SELECT * FROM SubFileRevisions");
            return list;
        }

        public IEnumerable<dynamic> ListSubFileRevisionsByDocumentType(string documentTypeCode)
        {
            var list = _CWDB.Fetch<Core.Models.SubFileRevisions>("WHERE SubFileType = @0", documentTypeCode);
            return list;
        }

        public void Remove(int subFileRevisionRecordID)
        {
            _CWDB.Delete(subFileRevisionRecordID);
        }
    }
}