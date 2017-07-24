using CWCMS.Core.Models;
using System.Collections.Generic;

namespace CWCMS.Application.BusinessLogicInterfaces
{
    internal interface IDocumentRetrievingRepository
    {

        /* Getting data as a whole */

        // Get Active Documents as a Whole -> Under Construction
        IEnumerable<Document> GetWholeActiveList(int categoryCode);

        // Get Revised Documents as a Whole -> Under Construction
        IEnumerable<Document> GetWholeRevisedList(int categoryCode);

        // Get Cancelled Documents as a Whole -> Under Construction
        IEnumerable<Document> GetWholeCancelledList(int categoryCode);




        /* Getting categorised grouped data */

        // Active Document Listing By Category -> Under Construction
        IEnumerable<Document> GetActiveListByCategory(int categoryCode);

        // Revised Document Listing By Category -> Under Construction
        IEnumerable<Document> GetRevisedListByCategory(int categoryCode);

        // Cancelled Document Listing By Category -> Under Construction
        IEnumerable<Document> GetCancelledListByCategory(int categoryCode);

        /* Get specific data */

        //------------------------------------//
        // Get Document By Reference Number

        // Active Documents -> Under Construction
        Document GetActiveDocumentByReferenceCode(string referenceCode);
        // Revised Documents -> Under Construction
        Document GetRevisedDocumentByReferenceCode(string referenceCode);
        // Cancelled Documents -> Under Construction
        Document GetCancelledDocumentByReferenceCode(string referenceCode);
        //------------------------------------//
        // Get Document By Reference Number

        // Active Documents

        // Revised Documents

        // Cancelled Documents
    }
}