using System;

namespace CWCMS.Core.Models
{
    public class FileSequence
    {
        //Incremental Primary Key of the Entity
        public int FileSeqID { get; set; }

        // Type of the file
        public String FileType { get; set; }

        // Thats the column we keep the incremental line number of the file
        public int SequenceNumber { get; set; }
    }
}