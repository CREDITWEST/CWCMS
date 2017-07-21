using CWCMS.Core.Interfaces;
using PetaPoco;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class SubFileSequenceRepository : ISubFileSequenceRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(Core.Models.SubFileSequence subFileSequenceRecord)
        {
            CWDB.Insert(subFileSequenceRecord);
        }

        public void Edit(Core.Models.SubFileSequence subFileSequenceRecord)
        {
            CWDB.Insert(subFileSequenceRecord);
        }

        public Core.Models.SubFileSequence FindSubFileSequenceByID(int subFileSequenceRecordID)
        {
            var record = CWDB.Single<Core.Models.SubFileSequence>(subFileSequenceRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListSubFileSequence()
        {
            var list = CWDB.Query<Core.Models.SubFileSequence>("SELECT * FROM SubFileSequence");
            return list;
        }

        public IEnumerable<dynamic> ListSubFileSequenceByDocumentType(string documentTypeCode)
        {
            var list = CWDB.Fetch<Core.Models.SubFileSequence>("WHERE SubFileType = @0", documentTypeCode);
            return list;
        }

        public void Remove(int subFileSequenceRecordID)
        {
            CWDB.Delete(subFileSequenceRecordID);
        }
    }
}