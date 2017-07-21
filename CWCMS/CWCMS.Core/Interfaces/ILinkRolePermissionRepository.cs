using CWCMS.Core.Models;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface ILinkRolePermissionRepository
    {
        // Adding new Link-Role-Permisson record to the table
        void Add(LinkRolePermission linkRolePermissionRecord);

        // Editing Link-Role-Permisson record which is actually on the table
        void Edit(LinkRolePermission linkRolePermissionRecord);

        // Removing Link-Role-Permisson record by ID
        void Remove(int linkRolePermissionRecordID);

        // Getting the all Link-Role-Permisson Records from the DB
        IEnumerable<dynamic> ListLinkRolePermission();

        // Find specific Link-Role-Permission Record by ID
        LinkRolePermission FindLinkRolePermissionByID(int linkRolePermissionRecordID);

        // List Link-Role-Permission Records by RoleID
        IEnumerable<dynamic> ListLinkRolePermissionByRole(int roleId);

        // List Link-Role-Permission Records by PermissionID
        IEnumerable<dynamic> ListLinkRolePermissionByPermission(int permissionId);
    }
}