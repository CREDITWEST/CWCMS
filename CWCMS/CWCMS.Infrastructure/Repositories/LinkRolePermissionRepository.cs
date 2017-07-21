using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class LinkRolePermissionRepository : ILinkRolePermissionRepository
    {
        private Database CWDB = new Database(Properties.Settings.CWCMS);

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