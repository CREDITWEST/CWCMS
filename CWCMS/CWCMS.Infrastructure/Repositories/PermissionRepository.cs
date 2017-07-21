using CWCMS.Core.Interfaces;
using PetaPoco;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class PermissionRepository : IPermissionRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(Core.Models.Permission permissionRecord)
        {
            CWDB.Insert(permissionRecord);
        }

        public void Edit(Core.Models.Permission permissionRecord)
        {
            CWDB.Update(permissionRecord);
        }

        public Core.Models.Permission FindPermissionByID(int permissionID)
        {
            var record = CWDB.Single<Core.Models.Permission>(permissionID);
            return record;
        }

        public IEnumerable<dynamic> ListPermission()
        {
            var list = CWDB.Query<Core.Models.Permission>("SELECT * FROM Permission");
            return list;
        }

        public void Remove(int permissionRecordID)
        {
            CWDB.Delete(permissionRecordID);
        }
    }
}