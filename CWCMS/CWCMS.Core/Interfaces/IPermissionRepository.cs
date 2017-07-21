using CWCMS.Core.Models;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IPermissionRepository
    {
        // Adding new Permission record to the table
        void Add(Permission permissionRecord);

        // Editing Permission record which is actually on the table
        void Edit(Permission permissionRecord);

        // Removing Permission record by ID
        void Remove(int permissionRecordID);

        // Getting the all Permission Records from the DB
        IEnumerable<dynamic> ListPermission();

        // Finding specific record by ID
        Permission FindPermissionByID(int permissionID);
    }
}