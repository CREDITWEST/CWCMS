using System;
using CWCMS.Core.Interfaces;
using CWCMS.Core.Models;
using PetaPoco;

namespace CWCMS.Infrastructure.Repositories
{
    public class FileSequenceRepository : IFileSequenceRepository
    {


        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

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
            throw new NotImplementedException();
        }

        public void Remove(int fileSequenceRecordID)
        {
            CWDB.Delete(fileSequenceRecordID);
        }
    }
}