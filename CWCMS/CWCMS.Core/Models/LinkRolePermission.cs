namespace CWCMS.Core.Models
{
    public class LinkRolePermission
    {
        //Auto-Increment integer type variable and Primary Key of the entity
        public int LinkRolePermissionID { get; set; }

        // Integer type unique identifier of the role that asssigned
        public int RoleID { get; set; }

        // Integer type unique identifier of the permission that asssigned
        public int PermissionID { get; set; }
    }
}