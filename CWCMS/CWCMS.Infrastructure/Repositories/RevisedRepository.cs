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
    class RevisedRepository : IRevisedRepository
    {


        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

        public void Add(CWCMS.Core.Models.Revised revisedRecord)
        {
            CWDB.Insert(revisedRecord);
        }

        public void Edit(CWCMS.Core.Models.Revised revisedRecord)
        {
            CWDB.Update(revisedRecord);
        }

        public CWCMS.Core.Models.Revised FindRevisedByDocument(Guid documentGUID)
        {
            throw new NotImplementedException();
        }

        public CWCMS.Core.Models.Revised FindRevisedByID(int revisedID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.Revised>(revisedID);
            return record;
        }

        public IEnumerable<dynamic> ListRevised()
        {
            var list = CWDB.Query<CWCMS.Core.Models.Revised>("SELECT * FROM Revised");
            return list;
        }

        public void Remove(int revisedRecordID)
        {
            CWDB.Delete(revisedRecordID);
        }
    }
}
