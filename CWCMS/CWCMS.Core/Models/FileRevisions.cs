using System;

namespace CWCMS.Core.Models
{
    public class FileRevisions
    {
        // Incremental Primary Key of the Entity
        public int FileReID { get; set; }

        // Type of the file
        public String FileType { get; set; }

        // Thats the column we keep the incremental line number of the file
        public int SequenceNumber { get; set; }

        // Thats the column we keep the revision count of the last revised version
        public int RevisionNumber { get; set; }

    }
}