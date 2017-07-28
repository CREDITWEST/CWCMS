using CWCMS.Application.DocumentLogic.DocumentRetrievingRepositories;
using CWCMS.Application.DocumentLogic.DocumentUploadingRepositories;
using CWCMS.Core.Models;
using System;
using System.Collections.Generic;

namespace CWCMS.Application.BLServices
{
    public class DocumentServices
    {
        // Bulk retrieving repository
        private BulkDocumentRetrievingRepository _bulkRetrieving;

        // Categorised retrieving repository
        private CategorisedDocumentRetrievingRepository _categorisedRetrieving;

        // Specific retrieving repository
        private SpecificDocumentReturnRepository _specificRetrieving;

        // Document adding repository
        private DocumentUploadRepository _uploadRepository;

        public DocumentServices()
        {
            this._bulkRetrieving = new BulkDocumentRetrievingRepository();

            this._categorisedRetrieving = new CategorisedDocumentRetrievingRepository();

            this._specificRetrieving = new SpecificDocumentReturnRepository();

            this._uploadRepository = new DocumentUploadRepository();
        }

        /*-------------------------------------------------------------------------------------*/
        /* Document Retrieving */

        // Retrieving uncategorised active documents

        public IEnumerable<Document> BulkRetrievingActiveDocuments()
        {
            return _bulkRetrieving.GetWholeActiveList();
        }

        // Retrieving uncategorised revised documents

        public IEnumerable<Document> BulkRetrievingRevisedDocuments()
        {
            return _bulkRetrieving.GetWholeRevisedList();
        }

        // Retrieving uncategorised cancelled documents

        public IEnumerable<Document> BulkRetrievingCancelledDocuments()
        {
            return _bulkRetrieving.GetWholeCancelledList();
        }

        // Retrieving categorised documents

        // Retrieving categorised active documents

        public IEnumerable<Document> CategorisedRetrievingActiveDocuments(int categoryCode)
        {
            return _categorisedRetrieving.GetActiveListByCategory(categoryCode);
        }

        // Retrieving categorised revised documents

        public IEnumerable<Document> CategorisedRetrievingRevisedDocuments(int categoryCode)
        {
            return _categorisedRetrieving.GetRevisedListByCategory(categoryCode);
        }

        // Retrieving categorised cancelled documents

        public IEnumerable<Document> CategorisedRetrievingCancelledDocuments(int categoryCode)
        {
            return _categorisedRetrieving.GetCancelledListByCategory(categoryCode);
        }

        /*-------------------------------------------------------------------------------------*/

        /* Document adding */

        // Uploading document to the system
        public Guid UploadDocument(Document userInput)
        {
            return _uploadRepository.UploadToServerDocument(userInput);
        }
    }
}