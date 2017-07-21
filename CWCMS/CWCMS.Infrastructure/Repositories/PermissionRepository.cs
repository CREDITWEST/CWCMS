using CWCMS.Core.Interfaces;
using PetaPoco;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class PermissionRepository : IPermissionRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(CWCMS.Core.Models.Permission permissionRecord)
        {
            CWDB.Insert(permissionRecord);
        }

        public void Edit(CWCMS.Core.Models.Permission permissionRecord)
        {
            CWDB.Update(permissionRecord);
        }

        public CWCMS.Core.Models.Permission FindPermissionByID(int permissionID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.Permission>(permissionID);
            return record;
        }

        public IEnumerable<dynamic> ListPermission()
        {
            var list = CWDB.Query<CWCMS.Core.Models.Permission>("SELECT * FROM Permission");
            return list;
        }

        public void Remove(int permissionRecordID)
        {
            CWDB.Delete(permissionRecordID);
        }
    }
}