using System;

namespace CWCMS.Core.Models
{
    public class WaitSignature
    {
        // Auto-Increment integer type variable and Primary Key of the entity
        public int WaitSignID { get; set; }

        // Guid type uniqueidentifier for document that waiting to be signed
        public Guid DocumentID { get; set; }

        // Count of the signature that is need to be signed for publishing document
        public int SignatureCount { get; set; }
    }
}