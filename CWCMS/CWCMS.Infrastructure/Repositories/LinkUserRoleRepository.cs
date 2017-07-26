using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class LinkUserRoleRepository : ILinkUserRoleRepository
    {
        private Database _CWDB;

        public LinkUserRoleRepository()
        {
            this._CWDB = new Database("CWCMSConnSecVers");
        }

        public void Add(Core.Models.LinkUserRole linkUserRoleRecord)
        {
            _CWDB.Insert(linkUserRoleRecord);
        }

        public void Edit(Core.Models.LinkUserRole linkUserRoleRecord)
        {
            _CWDB.Update(linkUserRoleRecord);
        }

        public Core.Models.LinkUserRole FindLinkUserRoleByID(int linkUserRoleRecordID)
        {
            var record = _CWDB.Single<Core.Models.LinkUserRole>(linkUserRoleRecordID);
            return record;
        }

        public IEnumerable<dynamic> ListLinkUserRole()
        {
            var list = _CWDB.Query<Core.Models.LinkUserRole>("SELECT * FROM LinkUserRole");
            return list;
        }

        public IEnumerable<dynamic> ListLinkUserRoleByRole(int roleId)
        {
            var list = _CWDB.Fetch<Core.Models.LinkUserRole>("WHERE RoleID = @0", roleId);
            return list;
        }

        public IEnumerable<dynamic> ListLinkUserRoleByUser(Guid userId)
        {
            var list = _CWDB.Fetch<Core.Models.LinkUserRole>("WHERE UserID = @0", userId);
            return list;
        }

        public void Remove(int linkUserRoleRecordID)
        {
            _CWDB.Delete(linkUserRoleRecordID);
        }
    }
}