using System;

namespace CWCMS.Core.Models
{
    public class Cancelled
    {
        // Auto-Increment integer type variable and Primary Key of the document
        public int CancelledID { get; set; }

        // The Guid type uniqueidentifier of the document which has cancelled by the admin
        public Guid DocumentID { get; set; }

        // Reason of the cancellation
        public String Feedback { get; set; }
    }
}