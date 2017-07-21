using System;

namespace CWCMS.Core.Models
{
    public class SubFileSequence
    {
        // Incremental Primary Key of the Entity
        public int SubFileSeqID { get; set; }

        // Type of the linked main file
        public String FileType { get; set; }

        // Thats the column we keep the incremental line number of the main type which linked to the file
        public int SequenceNumber { get; set; }

        // Type of the sub type
        public String SubFileType { get; set; }

        // Thats the column we keep the incremental line number of the sub file
        public int SubFileSequenceNumber { get; set; }
    }
}