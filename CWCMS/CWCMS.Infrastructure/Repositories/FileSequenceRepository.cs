using CWCMS.Core.Interfaces;
using PetaPoco;
using System;

namespace CWCMS.Infrastructure.Repositories
{
    public class FileSequenceRepository : IFileSequenceRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(CWCMS.Core.Models.FileSequence fileSequenceRecord)
        {
            CWDB.Insert(fileSequenceRecord);
        }

        public void Edit(CWCMS.Core.Models.FileSequence fileSequenceRecord)
        {
            CWDB.Update(fileSequenceRecord);
        }

        public CWCMS.Core.Models.FileSequence FindFileSequenceByID(int fileSequenceRecordID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.FileSequence>(fileSequenceRecordID);
            return record;
        }

        public System.Collections.Generic.IEnumerable<dynamic> ListFileSequence()
        {
            var list = CWDB.Query<CWCMS.Core.Models.FileSequence>("SELECT * FROM FileSequence");
            return list;
        }

        public System.Collections.Generic.IEnumerable<dynamic> ListFileSequenceByDocumentType(string documentTypeCode)
        {
            var list = CWDB.Fetch<CWCMS.Core.Models.FileSequence>("WHERE FileType = @0", documentTypeCode);
            return list;
        }

        public void Remove(int fileSequenceRecordID)
        {
            CWDB.Delete(fileSequenceRecordID);
        }
    }
}