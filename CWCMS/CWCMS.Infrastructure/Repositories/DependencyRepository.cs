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
    class DependencyRepository : IDependencyRepository
    {

        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

        public void Add(CWCMS.Core.Models.Dependency dependencyRecord)
        {
            CWDB.Insert(dependencyRecord);
        }

        public void Edit(CWCMS.Core.Models.Dependency dependencyRecord)
        {
            CWDB.Update(dependencyRecord);
        }

        public CWCMS.Core.Models.Dependency FindRecordByID(int dependencyId)
        {
            var record = CWDB.Single<CWCMS.Core.Models.Dependency>(dependencyId);
            return record;
        }

        public IEnumerable<dynamic> ListDependency()
        {
            var list = CWDB.Query<CWCMS.Core.Models.Dependency>("SELECT * FROM Dependency");
            return list;
        }

        public IEnumerable<dynamic> ListDependencyByDependedID(Guid dependedDocID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<dynamic> ListDependencyByDependingID(Guid dependingDocID)
        {
            throw new NotImplementedException();
        }

        public void Remove(int dependencyRecordID)
        {
            CWDB.Delete(dependencyRecordID);
        }
    }
}
