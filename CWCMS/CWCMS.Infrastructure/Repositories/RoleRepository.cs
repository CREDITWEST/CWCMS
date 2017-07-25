using CWCMS.Core.Interfaces;
using PetaPoco;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private Database _CWDB;

        public RoleRepository()
        {
            this._CWDB = new Database("CWCMSConnection");
        }

        public void Add(Core.Models.Role roleRecord)
        {
            _CWDB.Insert(roleRecord);
        }

        public void Edit(Core.Models.Role roleRecord)
        {
            _CWDB.Update(roleRecord);
        }

        public Core.Models.Role FindRoleByID(int roleID)
        {
            var record = _CWDB.Single<Core.Models.Role>(roleID);
            return record;
        }

        public IEnumerable<dynamic> ListRole()
        {
            var list = _CWDB.Query<Core.Models.Role>("SELECT * FROM Role");
            return list;
        }

        public void Remove(int roleRecordID)
        {
            _CWDB.Delete(roleRecordID);
        }
    }
}