using System;

namespace CWCMS.Core.Models
{
    public class PreCheck
    {
        // Auto-Increment integer type variable and Primary Key of the entity
        public int PrecheckID { get; set; }

        // Guid type uniqueidentifier of the document which is in the Pre Check state
        public Guid DocumentID { get; set; }

        // Count of the necessary signatures that required for publishing this document
        public int SignatureCount { get; set; }
    }
}