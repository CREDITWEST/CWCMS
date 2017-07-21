using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class LinkUserRoleRepository : ILinkUserRoleRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(CWCMS.Core.Models.LinkUserRole linkUserRoleRecord)
        {
            CWDB.Insert(linkUserRoleRecord);
        }

        public void Edit(CWCMS.Core.Models.LinkUserRole linkUserRoleRecord)
        {
            CWDB.Update(linkUserRoleRecord);
        }

        public CWCMS.Core.Models.LinkUserRole FindLinkUserRoleByID(int linkUserRoleRecordID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.LinkUserRole>(linkUserRoleRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListLinkUserRole()
        {
            var list = CWDB.Query<CWCMS.Core.Models.LinkUserRole>("SELECT * FROM LinkUserRole");
            return list;
        }

        public IEnumerable<dynamic> ListLinkUserRoleByRole(int roleId)
        {
            var list = CWDB.Fetch<CWCMS.Core.Models.LinkUserRole>("WHERE RoleID = @0", roleId);
            return list;
        }

        public IEnumerable<dynamic> ListLinkUserRoleByUser(Guid userId)
        {
            var list = CWDB.Fetch<CWCMS.Core.Models.LinkUserRole>("WHERE UserID = @0", userId);
            return list;
        }

        public void Remove(int linkUserRoleRecordID)
        {
            CWDB.Delete(linkUserRoleRecordID);
        }
    }
}