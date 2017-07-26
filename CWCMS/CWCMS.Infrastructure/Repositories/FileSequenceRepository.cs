using CWCMS.Core.Interfaces;
using CWCMS.Core.Models;
using PetaPoco;
using System;

namespace CWCMS.Infrastructure.Repositories
{
    public class FileSequenceRepository : IFileSequenceRepository
    {
        private Database _CWDB;

        public FileSequenceRepository()
        {
            this._CWDB = new Database("CWCMSConnSecVers");
        }

        public void Add(FileSequence fileSequenceRecord)
        {
            int a = Convert.ToInt32(_CWDB.Insert(fileSequenceRecord));
        }

        public void Edit(Core.Models.FileSequence fileSequenceRecord)
        {
            _CWDB.Update(fileSequenceRecord);
        }

        public FileSequence FindFileSequenceByDocumentType(string documentType)
        {
            FileSequence record = _CWDB.Single<FileSequence>("SELECT * FROM FileSequence AS fs WHERE fs.FileType = @0" , documentType);
            return record;
        }

        public Core.Models.FileSequence FindFileSequenceByID(int fileSequenceRecordID)
        {
            var record = _CWDB.Single<Core.Models.FileSequence>(fileSequenceRecordID);
            return record;
        }

        public int LastSequenceNumberOfSpecificType(string typeCode)
        {
            int sequenceNumber;
            if (_CWDB.ExecuteScalar<Object>("SELECT fs.SequenceNumber FROM FileSequence AS fs WHERE fs.FileType = '" + typeCode + "'") == null)
            {
                sequenceNumber = 0;
            }
            else
            {
                sequenceNumber = _CWDB.ExecuteScalar<int>("SELECT fs.SequenceNumber FROM FileSequence AS fs WHERE fs.FileType = '" + typeCode + "'");
            }

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