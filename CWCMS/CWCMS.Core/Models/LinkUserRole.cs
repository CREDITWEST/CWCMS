using System;

namespace CWCMS.Core.Models
{
    public class LinkUserRole
    {
        // Auto-Increment integer type variable and Primary Key of the entity
        public int LurlID { get; set; }

        // Integer type unique identifier of the role that asssigned
        public int RoleID { get; set; }

        // Integer type unique identifier of the user that asssigned
        public Guid UserID { get; set; }
    }
}