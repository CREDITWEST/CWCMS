namespace CWCMS.Core.Models
{
    public class IncompletedFeedback
    {
        // Auto-Increment int type attribute which is the primary key of the entity
        public int IncFeedID { get; set; }

        // ID of the feedback record which is in incomplete state
        public int FeedbackID { get; set; }
    }
}