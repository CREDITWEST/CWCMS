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
    class FileRevisionsRepository : IFileRevisionsRepository
    {

        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

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
