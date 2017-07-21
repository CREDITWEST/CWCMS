using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class LinkRolePermissionRepository : ILinkRolePermissionRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

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
            var list = CWDB.Fetch<CWCMS.Core.Models.LinkRolePermission>("WHERE PersmissionID = @0", permissionId);
            return list;
        }

        public IEnumerable<dynamic> ListLinkRolePermissionByRole(int roleId)
        {
            var list = CWDB.Fetch<CWCMS.Core.Models.LinkRolePermission>("WHERE RoleID = @0", roleId);
            return list;
        }

        public void Remove(int linkRolePermissionRecordID)
        {
            CWDB.Delete(linkRolePermissionRecordID);
        }
    }
}