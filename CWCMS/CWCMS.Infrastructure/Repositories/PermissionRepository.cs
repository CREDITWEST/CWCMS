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
    class PermissionRepository : IPermissionRepository
    {


        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

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
