using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class DependencyRepository : IDependencyRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(Core.Models.Dependency dependencyRecord)
        {
            CWDB.Insert(dependencyRecord);
        }

        public void Edit(Core.Models.Dependency dependencyRecord)
        {
            CWDB.Update(dependencyRecord);
        }

        public Core.Models.Dependency FindRecordByID(int dependencyId)
        {
            var record = CWDB.Single<Core.Models.Dependency>(dependencyId);
            return record;
        }

        public IEnumerable<dynamic> ListDependency()
        {
            var list = CWDB.Query<Core.Models.Dependency>("SELECT * FROM Dependency");
            return list;
        }

        public IEnumerable<dynamic> ListDependencyByDependedID(Guid dependedDocID)
        {
            var list = CWDB.Fetch<Core.Models.ConfirmedSignatures>("WHERE DocumentID1 = @0", dependedDocID);
            return list;
        }

        public IEnumerable<dynamic> ListDependencyByDependingID(Guid dependingDocID)
        {
            var list = CWDB.Fetch<Core.Models.ConfirmedSignatures>("WHERE DocumentID2 = @0", dependingDocID);
            return list;
        }

        public void Remove(int dependencyRecordID)
        {
            CWDB.Delete(dependencyRecordID);
        }
    }
}