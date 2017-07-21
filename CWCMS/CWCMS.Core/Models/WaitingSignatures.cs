using System;

namespace CWCMS.Core.Models
{
    public class WaitingSignatures
    {
        // Auto-Increment integer type variable and Primary Key of the entity
        public int WaitingSignatureID { get; set; }

        // Guid type uniqueidentifier of the document that will be signed
        public Guid DocumentID { get; set; }

        // ID of the user that will come from API resource who will sign the document
        public Guid UserID { get; set; }

        // Line number of the signature in which order it will be shown
        public int LineNumber { get; set; }
    }
}