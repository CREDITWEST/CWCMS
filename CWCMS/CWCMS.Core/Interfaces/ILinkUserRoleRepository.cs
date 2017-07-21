using CWCMS.Core.Models;
using System;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface ILinkUserRoleRepository
    {
        // Adding new Link-User-Role record to the table
        void Add(LinkUserRole linkUserRoleRecord);

        // Editing Link-User-Role record which is actually on the table
        void Edit(LinkUserRole linkUserRoleRecord);

        // Removing Link-User-Role record by ID
        void Remove(int linkUserRoleRecordID);

        // Getting the all Link-User-Role Records from the DB
        IEnumerable<dynamic> ListLinkUserRole();

        // Find specific Link-User-Role Record by ID
        LinkUserRole FindLinkUserRoleByID(int linkUserRoleRecordID);

        // List Link-User-Role Records by UserID
        IEnumerable<dynamic> ListLinkUserRoleByUser(Guid userId);

        // List Link-User-Role Records by RoleID
        IEnumerable<dynamic> ListLinkUserRoleByRole(int roleId);
    }
}