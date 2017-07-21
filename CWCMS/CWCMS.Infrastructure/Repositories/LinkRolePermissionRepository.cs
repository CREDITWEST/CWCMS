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
    class LinkRolePermissionRepository : ILinkRolePermissionRepository
    {


        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

        public void Add(CWCMS.Core.Models.LinkRolePermission linkRolePermissionRecord)
        {
            CWDB.Insert(linkRolePermissionRecord);
        }

        public void Edit(CWCMS.Core.Models.LinkRolePermission linkRolePermissionRecord)
        {
            CWDB.Update(linkRolePermissionRecord);
        }

        public CWCMS.Core.Models.LinkRolePermission FindLinkRolePermissionByID(int linkRolePermissionRecordID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.LinkRolePermission>(linkRolePermissionRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListLinkRolePermission()
        {
            var list = CWDB.Query<CWCMS.Core.Models.LinkRolePermission>("SELECT * FROM LinkRolePermission");
            return list;
        }

        public IEnumerable<dynamic> ListLinkRolePermissionByPermission(int permissionId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<dynamic> ListLinkRolePermissionByRole(int roleId)
        {
            throw new NotImplementedException();
        }

        public void Remove(int linkRolePermissionRecordID)
        {
            CWDB.Delete(linkRolePermissionRecordID);
        }
    }
}
