namespace CWCMS.Core.Models
{
    public class CompletedFeedback
    {
        // The Auto-Increment integer type variable which is primary key for the entity
        public int CompletedFeedID { get; set; }

        // The id of the feedback record that has responded to the its requester
        public int FeedbackID { get; set; }
    }
}