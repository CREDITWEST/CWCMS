using CWCMS.Core.Models;
using System.Collections.Generic;

namespace CWCMS.Application.BusinessLogicInterfaces.DocumentRetrievingLogic
{
    public interface IBulkDocumentRetrievingRepository
    {
        /* Getting data as a whole */

        // Get Active Documents as a Whole -> Done , Not Tested
        IEnumerable<Document> GetWholeActiveList();

        // Get Revised Documents as a Whole -> Done , Not Tested
        IEnumerable<Document> GetWholeRevisedList();

        // Get Cancelled Documents as a Whole -> Done , Not Tested
        IEnumerable<Document> GetWholeCancelledList();
    }
}