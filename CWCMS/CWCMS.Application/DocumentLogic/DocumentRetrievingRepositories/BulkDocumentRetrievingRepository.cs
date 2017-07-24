using CWCMS.Application.BusinessLogicInterfaces.DocumentRetrievingLogic;
using CWCMS.Core.Models;
using CWCMS.Infrastructure.Repositories;
using System.Collections.Generic;

namespace CWCMS.Application.DocumentLogic.DocumentRetrievingRepositories
{
    public class BulkDocumentRetrievingRepository : IBulkDocumentRetrievingRepository
    {
        private DocumentRepository _documentRepository;

        public BulkDocumentRetrievingRepository()
        {
            this._documentRepository = new DocumentRepository();
        }

        public IEnumerable<Document> GetWholeActiveList()
        {
            return _documentRepository.GetWholeActiveList();
        }

        public IEnumerable<Document> GetWholeCancelledList()
        {
            return _documentRepository.GetWholeCancelledList();
        }

        public IEnumerable<Document> GetWholeRevisedList()
        {
            return _documentRepository.GetWholeRevisedList();
        }
    }
}