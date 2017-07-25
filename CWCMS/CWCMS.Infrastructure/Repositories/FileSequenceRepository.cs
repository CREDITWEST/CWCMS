using CWCMS.Core.Interfaces;
using PetaPoco;

namespace CWCMS.Infrastructure.Repositories
{
    public class FileSequenceRepository : IFileSequenceRepository
    {
        private Database _CWDB;

        public FileSequenceRepository()
        {
            this._CWDB = new Database("CWCMSConnection");
        }

        public void Add(Core.Models.FileSequence fileSequenceRecord)
        {
            _CWDB.Insert(fileSequenceRecord);
        }

        public void Edit(Core.Models.FileSequence fileSequenceRecord)
        {
            _CWDB.Update(fileSequenceRecord);
        }

        public Core.Models.FileSequence FindFileSequenceByID(int fileSequenceRecordID)
        {
            var record = _CWDB.Single<Core.Models.FileSequence>(fileSequenceRecordID);
            return record;
        }

        public int LastSequenceNumberOfSpecificType(string typeCode)
        {
            int sequenceNumber = _CWDB.ExecuteScalar<int>("SELECT fs.SequenceNumber FROM FileSequence AS fs WHERE fs.FileType = '" + typeCode + "'");

            return sequenceNumber;
        }

        public System.Collections.Generic.IEnumerable<dynamic> ListFileSequence()
        {
            var list = _CWDB.Query<Core.Models.FileSequence>("SELECT * FROM FileSequence");
            return list;
        }

        public System.Collections.Generic.IEnumerable<dynamic> ListFileSequenceByDocumentType(string documentTypeCode)
        {
            var list = _CWDB.Fetch<Core.Models.FileSequence>("WHERE FileType = @0", documentTypeCode);
            return list;
        }

        public void Remove(int fileSequenceRecordID)
        {
            _CWDB.Delete(fileSequenceRecordID);
        }
    }
}