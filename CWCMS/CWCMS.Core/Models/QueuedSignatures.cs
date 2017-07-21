using System;

namespace CWCMS.Core.Models
{
    public class QueuedSignatures
    {
        // Auto-Increment integer type and Primary Key for the entity
        public int QueuedSignatureID { get; set; }

        // Guid type uniqueidentifier of the signed document
        public Guid DocumentID { get; set; }

        // Integer type identifier for user that will sign the document, which will come from API
        public Guid UserID { get; set; }

        // Integer number that shows that the line number of the signature give us the order of it
        public int LineNumber { get; set; }
    }
}