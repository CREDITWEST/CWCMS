using System;

namespace CWCMS.Core.Models
{
    public class Revised
    {
        // Auto-Increment integer type and Primary Key of the entity
        public int RevisedID { get; set; }

        // The Guid type uniqueidentifier of the document which has cancelled by the admin
        public Guid DocumentID { get; set; }
    }
}