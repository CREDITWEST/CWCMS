using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class FileRevisionsRepository : IFileRevisionsRepository
    {
        private Database CWDB = new Database(Properties.Settings.CWCMS);

        public void Add(CWCMS.Core.Models.FileRevisions fileRevisionRecord)
        {
            CWDB.Insert(fileRevisionRecord);
        }

        public void Edit(CWCMS.Core.Models.FileRevisions fileRevisionRecord)
        {
            CWDB.Update(fileRevisionRecord);
        }

        public CWCMS.Core.Models.FileRevisions FindFileRevisionsByID(int fileRevisionsRecordID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.FileRevisions>(fileRevisionsRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListFileRevisions()
        {
            var list = CWDB.Query<CWCMS.Core.Models.FileRevisions>("SELECT * FROM FileRevisions");
            return list;
        }

        public IEnumerable<dynamic> ListFileRevisionsByDocumentType(string documentTypeCode)
        {
            throw new NotImplementedException();
        }

        public void Remove(int fileRevisionRecordID)
        {
            CWDB.Delete(fileRevisionRecordID);
        }
    }
}