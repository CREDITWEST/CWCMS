using CWCMS.Core.Models;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IDocumentTypeRepository
    {
        // Adding new Role record to the table
        void Add(DocumentType documentTypeRecord);

        // Editing Role record which is actually on the table
        void Edit(DocumentType documentTypeRecord);

        // Removing Role record by ID
        void Remove(int documentTypeRecordID);

        // Getting the all Role Records from the DB
        IEnumerable<dynamic> ListDocumentType();

        // Finding specific record by ID
        DocumentType FindDocumentTypeByID(int documentTypeID);
    }
}