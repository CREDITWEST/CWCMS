using CWCMS.Core.Interfaces;
using PetaPoco;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class PermissionRepository : IPermissionRepository
    {
        private Database _CWDB;

        public PermissionRepository()
        {
            this._CWDB = new Database("CWCMSConnSecVers");
        }

        public void Add(Core.Models.Permission permissionRecord)
        {
            _CWDB.Insert("Permission","PermissionID",true,permissionRecord);
        }

        public void Edit(Core.Models.Permission permissionRecord)
        {
            _CWDB.Update("Permission","PermissionID",permissionRecord);
        }

        public Core.Models.Permission FindPermissionByID(int permissionID)
        {
            var record = _CWDB.Single<Core.Models.Permission>(permissionID);
            return record;
        }

        public IEnumerable<dynamic> ListPermission()
        {
            var list = _CWDB.Query<Core.Models.Permission>("SELECT * FROM Permission");
            return list;
        }

        public void Remove(int permissionRecordID)
        {
            _CWDB.Delete(permissionRecordID);
        }
    }
}