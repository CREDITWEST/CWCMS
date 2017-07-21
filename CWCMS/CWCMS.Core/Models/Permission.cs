using System;

namespace CWCMS.Core.Models
{
    public class Permission
    {
        // Auto-Increment integer type variable and Primary Key of the entity
        public int PermissionID { get; set; }

        // Name of the permission
        public String PermissionName { get; set; }
    }
}