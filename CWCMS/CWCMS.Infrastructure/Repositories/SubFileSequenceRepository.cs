using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class SubFileSequenceRepository : ISubFileSequenceRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(CWCMS.Core.Models.SubFileSequence subFileSequenceRecord)
        {
            CWDB.Insert(subFileSequenceRecord);
        }

        public void Edit(CWCMS.Core.Models.SubFileSequence subFileSequenceRecord)
        {
            CWDB.Insert(subFileSequenceRecord);
        }

        public CWCMS.Core.Models.SubFileSequence FindSubFileSequenceByID(int subFileSequenceRecordID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.SubFileSequence>(subFileSequenceRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListSubFileSequence()
        {
            var list = CWDB.Query<CWCMS.Core.Models.SubFileSequence>("SELECT * FROM SubFileSequence");
            return list;
        }

        public IEnumerable<dynamic> ListSubFileSequenceByDocumentType(string documentTypeCode)
        {
            var list = CWDB.Fetch<CWCMS.Core.Models.SubFileSequence>("WHERE SubFileType = @0", documentTypeCode);
            return list;
        }

        public void Remove(int subFileSequenceRecordID)
        {
            CWDB.Delete(subFileSequenceRecordID);
        }
    }
}