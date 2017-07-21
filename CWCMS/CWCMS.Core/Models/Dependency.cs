using System;

namespace CWCMS.Core.Models
{
    public class Dependency
    {
        // The Auto-Increment primary key of the entity
        public int DependID { get; set; }

        // The Guid type uniqueidentifier of the document which is the main type and links to other document to itself
        public Guid DocumentID1 { get; set; }

        // The Guid type uniqueidentifier of the document which is depened to the other document and related with it
        public Guid DocumentID2 { get; set; }
    }
}