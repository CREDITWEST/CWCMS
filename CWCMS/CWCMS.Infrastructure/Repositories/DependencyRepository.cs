using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class DependencyRepository : IDependencyRepository
    {
        private Database _CWDB;

        public DependencyRepository()
        {
            this._CWDB = new Database("CWCMSConnSecVers");
        }

        public void Add(Core.Models.Dependency dependencyRecord)
        {
            _CWDB.Insert(dependencyRecord);
        }

        public void Edit(Core.Models.Dependency dependencyRecord)
        {
            _CWDB.Update(dependencyRecord);
        }

        public Core.Models.Dependency FindRecordByID(int dependencyId)
        {
            var record = _CWDB.Single<Core.Models.Dependency>(dependencyId);
            return record;
        }

        public IEnumerable<dynamic> ListDependency()
        {
            var list = _CWDB.Query<Core.Models.Dependency>("SELECT * FROM Dependency");
            return list;
        }

        public IEnumerable<dynamic> ListDependencyByDependedID(Guid dependedDocID)
        {
            var list = _CWDB.Fetch<Core.Models.ConfirmedSignatures>("WHERE DocumentID1 = @0", dependedDocID);
            return list;
        }

        public IEnumerable<dynamic> ListDependencyByDependingID(Guid dependingDocID)
        {
            var list = _CWDB.Fetch<Core.Models.ConfirmedSignatures>("WHERE DocumentID2 = @0", dependingDocID);
            return list;
        }

        public void Remove(int dependencyRecordID)
        {
            _CWDB.Delete(dependencyRecordID);
        }
    }
}