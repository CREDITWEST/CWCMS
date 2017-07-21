using CWCMS.Core.Models;
using System;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IDocumentRepository
    {
        // Adding new Document record to the table
        void Add(Document documentRecord);

        // Editing Document record which is actually on the table
        void Edit(Document documentRecord);

        // Removing Document record by ID
        void Remove(Guid documentRecordID);

        // Getting the all Document Records from the DB
        IEnumerable<dynamic> ListDocument();

        // Finding specific record by ID
        Document FindDocumentByID(Guid documentRecordID);

        // Finding specific record by Reference Number
        Document FindDocumentByReferenceNumber(string referenceNumber);

        // Listing Documents from the same publisher
        IEnumerable<dynamic> ListDocumentByPublisherID(Guid publisherId);

        // Listing Documents with publish date
        IEnumerable<dynamic> ListDocumentByPublishDate(DateTime publishDateTime);
    }
}