using CWCMS.Core.Interfaces;
using PetaPoco;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class SubFileSequenceRepository : ISubFileSequenceRepository
    {
        private Database _CWDB;

        public SubFileSequenceRepository()
        {
            this._CWDB = new Database("CWCMSConnSecVers");
        }

        public void Add(Core.Models.SubFileSequence subFileSequenceRecord)
        {
            _CWDB.Insert(subFileSequenceRecord);
        }

        public void Edit(Core.Models.SubFileSequence subFileSequenceRecord)
        {
            _CWDB.Insert(subFileSequenceRecord);
        }

        public Core.Models.SubFileSequence FindSubFileSequenceByID(int subFileSequenceRecordID)
        {
            var record = _CWDB.Single<Core.Models.SubFileSequence>(subFileSequenceRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListSubFileSequence()
        {
            var list = _CWDB.Query<Core.Models.SubFileSequence>("SELECT * FROM SubFileSequence");
            return list;
        }

        public IEnumerable<dynamic> ListSubFileSequenceByDocumentType(string documentTypeCode)
        {
            var list = _CWDB.Fetch<Core.Models.SubFileSequence>("WHERE SubFileType = @0", documentTypeCode);
            return list;
        }

        public void Remove(int subFileSequenceRecordID)
        {
            _CWDB.Delete(subFileSequenceRecordID);
        }
    }
}