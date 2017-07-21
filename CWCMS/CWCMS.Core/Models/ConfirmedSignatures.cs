using System;

namespace CWCMS.Core.Models
{
    public class ConfirmedSignatures
    {
        // That's the ID of the table which is Primary Key and Auto-Incremental
        public int ConfirmedSignatureID { get; set; }

        // That is the Guid uniqueidentifier of the document that signed
        public Guid DocumentID { get; set; }

        // That is the ID of the user that we get from API resource which signs the document
        public Guid UserID { get; set; }

        // That is the date of the confirming signature
        public DateTime SignDate { get; set; }
    }
}