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
    class SubFileSequenceRepository : ISubFileSequenceRepository
    {


        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

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
            throw new NotImplementedException();
        }

        public void Remove(int subFileSequenceRecordID)
        {
            CWDB.Delete(subFileSequenceRecordID);
        }
    }
}
