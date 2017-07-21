using CWCMS.Core.Interfaces;
using PetaPoco;

namespace CWCMS.Infrastructure.Repositories
{
    public class FileSequenceRepository : IFileSequenceRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(Core.Models.FileSequence fileSequenceRecord)
        {
            CWDB.Insert(fileSequenceRecord);
        }

        public void Edit(Core.Models.FileSequence fileSequenceRecord)
        {
            CWDB.Update(fileSequenceRecord);
        }

        public Core.Models.FileSequence FindFileSequenceByID(int fileSequenceRecordID)
        {
            var record = CWDB.Single<Core.Models.FileSequence>(fileSequenceRecordID);
            return record;
        }

        public System.Collections.Generic.IEnumerable<dynamic> ListFileSequence()
        {
            var list = CWDB.Query<Core.Models.FileSequence>("SELECT * FROM FileSequence");
            return list;
        }

        public System.Collections.Generic.IEnumerable<dynamic> ListFileSequenceByDocumentType(string documentTypeCode)
        {
            var list = CWDB.Fetch<Core.Models.FileSequence>("WHERE FileType = @0", documentTypeCode);
            return list;
        }

        public void Remove(int fileSequenceRecordID)
        {
            CWDB.Delete(fileSequenceRecordID);
        }
    }
}