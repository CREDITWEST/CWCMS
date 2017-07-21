using System;

namespace CWCMS.Core.Models
{
    public class SubFileRevisions
    {
        // Incremental Primary Key of the Entity
        public int SubFileRevID { get; set; }

        // Type of the linked main file
        public String FileType { get; set; }

        // Thats the column we keep the incremental line number of the main type which linked to the file
        public int SequenceNumber { get; set; }

        // Type of the sub type
        public String SubFileType { get; set; }

        // Thats the column we keep the incremental line number of the sub file
        public int SubFileSequence { get; set; }

        // That column for keeping the last revised edition's revisition count
        public int RevisionNumber { get; set; }
    }
}