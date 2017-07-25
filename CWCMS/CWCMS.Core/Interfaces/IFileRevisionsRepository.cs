using CWCMS.Core.Models;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IFileRevisionsRepository
    {
        // Adding new File Revision record to the table
        void Add(FileRevisions fileRevisionRecord);

        // Editing File Revisions record which is actually on the table
        void Edit(FileRevisions fileRevisionRecord);

        // Removing File Revision record by ID
        void Remove(int fileRevisionRecordID);

        // Getting the all File Revision Records from the DB
        IEnumerable<dynamic> ListFileRevisions();

        // Finding specific record by ID
        FileRevisions FindFileRevisionsByID(int fileRevisionsRecordID);

        // Listing File Revisions same type documents
        IEnumerable<dynamic> ListFileRevisionsByDocumentType(string documentTypeCode);

        // Getting the last sequence number of specific type
        int LastRevisionNumberOfSpecificDocument(string typeCode, int sequenceNumber);
    }
}