using System;

namespace CWCMS.Core.Models
{
    public class EndDate
    {
        // Auto-Increment integer variable and Primary Key of the date record
        public int EndDateID { get; set; }

        // Guid type uniqueidentifier of the document which has this expiration date
        public Guid DocumentID { get; set; }

        // Date of the expiration of the document
        public DateTime ExpirationDate { get; set; }
    }
}