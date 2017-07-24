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

        // Listing Documents according to their category
        IEnumerable<dynamic> ListDocumentByDocumentTypeID(int documentTypeID);

        // Listing Documents with publish date
        IEnumerable<dynamic> ListDocumentByPublishDate(DateTime publishDateTime);



        /* Bulk Data Listings */

        // Get Active Documents as a Whole -> Done , Not Tested
        IEnumerable<Document> GetWholeActiveList();

        // Get Revised Documents as a Whole -> Done , Not Tested
        IEnumerable<Document> GetWholeRevisedList();

        // Get Cancelled Documents as a Whole -> Done , Not Tested
        IEnumerable<Document> GetWholeCancelledList();



        /* Categorised Data Listings */

        // Active Document Listing By Category -> Under Construction
        IEnumerable<Document> GetActiveListByCategory(int categoryCode);

        // Revised Document Listing By Category -> Under Construction
        IEnumerable<Document> GetRevisedListByCategory(int categoryCode);

        // Cancelled Document Listing By Category -> Under Construction
        IEnumerable<Document> GetCancelledListByCategory(int categoryCode);



        /* Specific Document Listing */

        //------------------------------------//
        // Get Document By Reference Number

        // Active Documents -> Under Construction
        Document GetActiveDocumentByReferenceCode(string referenceCode);

        // Revised Documents -> Under Construction
        Document GetRevisedDocumentByReferenceCode(string referenceCode);

        // Cancelled Documents -> Under Construction
        Document GetCancelledDocumentByReferenceCode(string referenceCode);

        //------------------------------------//
        // Get Document By Guid Number

        // Active Documents -> Under Construction
        Document GetActiveDocumentByGuid(Guid documentGuid);

        // Revised Documents -> Under Construction
        Document GetRevisedDocumentByGuid(Guid documentGuid);

        // Cancelled Documents -> Under Construction
        Document GetCancelledDocumentByGuid(Guid documentGuid);
    }
}