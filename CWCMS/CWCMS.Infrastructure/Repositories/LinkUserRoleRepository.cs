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
            throw new NotImplementedException();
        }

        public IEnumerable<dynamic> ListLinkUserRoleByUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public void Remove(int linkUserRoleRecordID)
        {
            CWDB.Delete(linkUserRoleRecordID);
        }
    }
}