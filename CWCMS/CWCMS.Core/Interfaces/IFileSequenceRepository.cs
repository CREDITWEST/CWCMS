using CWCMS.Core.Models;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IFileSequenceRepository
    {
        // Adding new File Sequence record to the table
        void Add(FileSequence fileSequenceRecord);

        // Editing File Sequence record which is actually on the table
        void Edit(FileSequence fileSequenceRecord);

        // Removing File Sequence record by ID
        void Remove(int fileSequenceRecordID);

        // Getting the all File Sequence Records from the DB
        IEnumerable<dynamic> ListFileSequence();

        // Finding specific record by ID
        FileSequence FindFileSequenceByID(int fileSequenceRecordID);

        // Listing File Sequence same type documents
        IEnumerable<dynamic> ListFileSequenceByDocumentType(string documentTypeCode);
    }
}