using CWCMS.Core.Models;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface ISubFileSequenceRepository
    {
        // Adding new Sub File Sequence record to the table
        void Add(SubFileSequence subFileSequenceRecord);

        // Editing Sub File Sequence record which is actually on the table
        void Edit(SubFileSequence subFileSequenceRecord);

        // Removing Sub File Sequence record by ID
        void Remove(int subFileSequenceRecordID);

        // Getting the all Sub File Sequence Records from the DB
        IEnumerable<dynamic> ListSubFileSequence();

        // Finding specific record by ID
        SubFileSequence FindSubFileSequenceByID(int subFileSequenceRecordID);

        // Listing Sub File Sequence same type documents
        IEnumerable<dynamic> ListSubFileSequenceByDocumentType(string documentTypeCode);
    }
}