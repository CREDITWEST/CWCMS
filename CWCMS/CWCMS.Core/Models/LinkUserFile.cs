using System;

namespace CWCMS.Core.Models
{
    public class LinkUserFile
    {
        // Auto-increment int also primary key of the entity
        public int LinkUserFileID { get; set; }

        // The Guid type uniqueidentifier of the document which is linked to the user
        public Guid DocumentID { get; set; }

        // That is the ID of the user that we get from API resource which is related to the document
        public Guid UserID { get; set; }
    }
}