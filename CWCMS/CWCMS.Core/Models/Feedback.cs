using System;

namespace CWCMS.Core.Models
{
    public class Feedback
    {
        // Auto-Increment int type variable and Primary Key of the entity
        public int FeedbackID { get; set; }

        // Guid type uniqueidentifier of the document which is needed to take supervision about it
        public Guid DocumentID { get; set; }

        // Integer type id of the user who will comment about document, which cames from API resource
       public Guid UserID { get; set; }

        // Comment of the user about the document that discussed
        public String Comment { get; set; }

        // Sending date of the feedback request
        public DateTime SendDate { get; set; }

        // Feedbacks has time to send reply and this is the variable that represents the expiration date
        public DateTime EndDate { get; set; }

        // Every feedback logged with the date which is responded and at the latest this date could be equal to EndDate if supervisor doesn't comment on time
        public DateTime ResponseDate { get; set; }
    }
}