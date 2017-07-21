using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class DependencyRepository : IDependencyRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

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
            var list = CWDB.Fetch<CWCMS.Core.Models.ConfirmedSignatures>("WHERE DocumentID1 = @0", dependedDocID);
            return list;
        }

        public IEnumerable<dynamic> ListDependencyByDependingID(Guid dependingDocID)
        {
            var list = CWDB.Fetch<CWCMS.Core.Models.ConfirmedSignatures>("WHERE DocumentID2 = @0", dependingDocID);
            return list;
        }

        public void Remove(int dependencyRecordID)
        {
            CWDB.Delete(dependencyRecordID);
        }
    }
}