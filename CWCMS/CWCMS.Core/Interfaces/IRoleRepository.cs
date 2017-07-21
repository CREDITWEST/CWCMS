using CWCMS.Core.Models;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IRoleRepository
    {
        // Adding new Role record to the table
        void Add(Role roleRecord);

        // Editing Role record which is actually on the table
        void Edit(Role roleRecord);

        // Removing Role record by ID
        void Remove(int roleRecordID);

        // Getting the all Role Records from the DB
        IEnumerable<dynamic> ListRole();

        // Finding specific record by ID
        Role FindRoleByID(int roleID);
    }
}