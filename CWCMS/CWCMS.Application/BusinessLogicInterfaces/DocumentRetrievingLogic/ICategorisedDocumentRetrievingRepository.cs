using CWCMS.Core.Models;
using System.Collections.Generic;

namespace CWCMS.Application.BusinessLogicInterfaces.DocumentRetrievingLogic
{
    public interface ICategorisedDocumentRetrievingRepository
    {
        /* Getting categorised grouped data */

        // Active Document Listing By Category -> Done , Not Tested
        IEnumerable<Document> GetActiveListByCategory(int categoryCode);

        // Revised Document Listing By Category -> Done , Not Tested
        IEnumerable<Document> GetRevisedListByCategory(int categoryCode);

        // Cancelled Document Listing By Category -> Done , Not Tested
        IEnumerable<Document> GetCancelledListByCategory(int categoryCode);
    }
}