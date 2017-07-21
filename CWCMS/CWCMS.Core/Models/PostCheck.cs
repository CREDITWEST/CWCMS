using System;

namespace CWCMS.Core.Models
{
    public class PostCheck
    {
        // Auto-Increment integer which is primary key of the entity
        public int PostID { get; set; }

        // The Guid type uniqueidentifier of the document which is in the post check level
        public Guid DocumentID { get; set; }
    }
}