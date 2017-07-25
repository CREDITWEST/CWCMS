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
        IEnumerable<Document> ListDocument();

        // Finding specific record by ID
        Document FindDocumentByID(Guid documentRecordID);

        // Finding specific record by Reference Number
        Document FindDocumentByReferenceNumber(string referenceNumber);

        // Listing Documents from the same publisher
        IEnumerable<Document> ListDocumentByPublisherID(Guid publisherId);

        // Listing Documents according to their category
        IEnumerable<Document> ListDocumentByDocumentTypeID(int documentTypeID);

        // Listing Documents with publish date
        IEnumerable<Document> ListDocumentByPublishDate(DateTime publishDateTime);



        /* Bulk Data Listings */

        // Get Active Documents as a Whole -> Done , Not Tested
        IEnumerable<Document> GetWholeActiveList();

        // Get Revised Documents as a Whole -> Done , Not Tested
        IEnumerable<Document> GetWholeRevisedList();

        // Get Cancelled Documents as a Whole -> Done , Not Tested
        IEnumerable<Document> GetWholeCancelledList();



        /* Categorised Data Listings */

        // Active Document Listing By Category -> Done , Not Tested
        IEnumerable<Document> GetActiveListByCategory(int categoryCode);

        // Revised Document Listing By Category -> Done , Not Tested
        IEnumerable<Document> GetRevisedListByCategory(int categoryCode);

        // Cancelled Document Listing By Category -> Done , Not Tested
        IEnumerable<Document> GetCancelledListByCategory(int categoryCode);



        /* Specific Document Listing */

        //------------------------------------//
        // Get Document By Reference Number

        // Active Documents -> Done , Not Tested
        Document GetActiveDocumentByReferenceCode(string referenceCode);

        // Revised Documents -> Done , Not Tested
        Document GetRevisedDocumentByReferenceCode(string referenceCode);

        // Cancelled Documents -> Done , Not Tested
        Document GetCancelledDocumentByReferenceCode(string referenceCode);

        //------------------------------------//
        // Get Document By Guid Number

        // Active Documents -> Done , Not Tested
        Document GetActiveDocumentByGuid(Guid documentGuid);

        // Revised Documents -> Done , Not Tested
        Document GetRevisedDocumentByGuid(Guid documentGuid);

        // Cancelled Documents -> Done , Not Tested
        Document GetCancelledDocumentByGuid(Guid documentGuid);
    }
}