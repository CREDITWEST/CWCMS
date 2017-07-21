using System;

namespace CWCMS.Core.Models
{
    public class WaitingForFeedback
    {
        // Auto-Increment integer type variable and Primary Key of the entity
        public int WFFID { get; set; }

        // Guid type uniqueidentifier of the document which is waiting feedback to send signature sequence
        public Guid DocumentID { get; set; }
    }
}