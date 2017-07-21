using CWCMS.Core.Models;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface ISubFileRevisionsRepository
    {
        // Adding new Sub File Revision record to the table
        void Add(SubFileRevisions subFileRevisionRecord);

        // Editing Sub File Revisions record which is actually on the table
        void Edit(SubFileRevisions subFileRevisionRecord);

        // Removing Sub File Revision record by ID
        void Remove(int subFileRevisionRecordID);

        // Getting the all Sub File Revision Records from the DB
        IEnumerable<dynamic> ListSubFileRevisions();

        // Finding specific record by ID
        SubFileRevisions FindSubFileRevisionsByID(int subFileRevisionsRecordID);

        // Listing Sub File Revisions same type documents
        IEnumerable<dynamic> ListSubFileRevisionsByDocumentType(string documentTypeCode);
    }
}