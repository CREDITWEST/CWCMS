using CWCMS.Core.Interfaces;
using PetaPoco;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class RoleRepository : IRoleRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(CWCMS.Core.Models.Role roleRecord)
        {
            CWDB.Insert(roleRecord);
        }

        public void Edit(CWCMS.Core.Models.Role roleRecord)
        {
            CWDB.Update(roleRecord);
        }

        public CWCMS.Core.Models.Role FindRoleByID(int roleID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.Role>(roleID);
            return record;
        }

        public IEnumerable<dynamic> ListRole()
        {
            var list = CWDB.Query<CWCMS.Core.Models.Role>("SELECT * FROM Role");
            return list;
        }

        public void Remove(int roleRecordID)
        {
            CWDB.Delete(roleRecordID);
        }
    }
}