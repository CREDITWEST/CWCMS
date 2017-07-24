using CWCMS.Core.Models;
using System.Collections.Generic;

namespace CWCMS.Application.BusinessLogicInterfaces
{
    public interface IDocumentViewingRepository
    {
        // Listing documents according to their catgories which is active
        IEnumerable<Document> ListActiveDocumentsByCategory(int documentTypeID);

        // Listing documents according to their catgories which is cancelled
        IEnumerable<Document> ListCancelledDocumentsByCategory(int documentTypeID);

        // Listing documents according to their catgories which is revised
        IEnumerable<Document> ListRevisedDocumentsByCategory(int documentTypeID);

        // Retrieving document by its reference code
        Document searchDocumentByReferenceCode(string referenceNumber);
    }
}