using CWCMS.Core.Interfaces;
using PetaPoco;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class FileRevisionsRepository : IFileRevisionsRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(Core.Models.FileRevisions fileRevisionRecord)
        {
            CWDB.Insert(fileRevisionRecord);
        }

        public void Edit(Core.Models.FileRevisions fileRevisionRecord)
        {
            CWDB.Update(fileRevisionRecord);
        }

        public Core.Models.FileRevisions FindFileRevisionsByID(int fileRevisionsRecordID)
        {
            var record = CWDB.Single<Core.Models.FileRevisions>(fileRevisionsRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListFileRevisions()
        {
            var list = CWDB.Query<Core.Models.FileRevisions>("SELECT * FROM FileRevisions");
            return list;
        }

        public IEnumerable<dynamic> ListFileRevisionsByDocumentType(string documentTypeCode)
        {
            var list = CWDB.Fetch<Core.Models.FileRevisions>("WHERE FileType = @0", documentTypeCode);
            return list;
        }

        public void Remove(int fileRevisionRecordID)
        {
            CWDB.Delete(fileRevisionRecordID);
        }
    }
}