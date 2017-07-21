using System;

namespace CWCMS.Core.Models
{
    public class Deleted
    {
        // Auto-Increment integer type variable and primary key of the entity
        public int DeletedID { get; set; }

        // Guid type uniqueidentifier for document that is deleted by admin
        public Guid DocumentID { get; set; }
    }
}