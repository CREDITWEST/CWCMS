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
    class SubFileRevisionsRepository : ISubFileRevisionsRepository
    {


        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

        public void Add(CWCMS.Core.Models.SubFileRevisions subFileRevisionRecord)
        {
            CWDB.Insert(subFileRevisionRecord);
        }

        public void Edit(CWCMS.Core.Models.SubFileRevisions subFileRevisionRecord)
        {
            CWDB.Update(subFileRevisionRecord);
        }

        public CWCMS.Core.Models.SubFileRevisions FindSubFileRevisionsByID(int subFileRevisionsRecordID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.SubFileRevisions>(subFileRevisionsRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListSubFileRevisions()
        {
            var list = CWDB.Query<CWCMS.Core.Models.SubFileRevisions>("SELECT * FROM SubFileRevisions");
            return list;
        }

        public IEnumerable<dynamic> ListSubFileRevisionsByDocumentType(string documentTypeCode)
        {
            throw new NotImplementedException();
        }

        public void Remove(int subFileRevisionRecordID)
        {
            CWDB.Delete(subFileRevisionRecordID);
        }
    }
}
