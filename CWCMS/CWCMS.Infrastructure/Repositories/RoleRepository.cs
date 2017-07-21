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
    class RoleRepository : IRoleRepository
    {


        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

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
