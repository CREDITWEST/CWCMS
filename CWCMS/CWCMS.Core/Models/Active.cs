using System;

namespace CWCMS.Core.Models
{
    public class Active
    {
        // Auto-Increment integer type variable and Primary Key of the entity
        public int ActiveID { get; set; }

        // The Guid type uniqueidentifier of the document which has active and controlled by the admin
        public Guid DocumentID { get; set; }
    }
}