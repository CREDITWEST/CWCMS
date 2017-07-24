using CWCMS.Application.BusinessLogicInterfaces.DocumentRetrievingLogic;
using CWCMS.Core.Models;
using CWCMS.Infrastructure.Repositories;
using System.Collections.Generic;

namespace CWCMS.Application.DocumentLogic.DocumentRetrievingRepositories
{
    public class CategorisedDocumentRetrievingRepository : ICategorisedDocumentRetrievingRepository
    {
        private DocumentRepository _documentRepository;

        public CategorisedDocumentRetrievingRepository()
        {
            this._documentRepository = new DocumentRepository();
        }

        public IEnumerable<Document> GetActiveListByCategory(int categoryCode)
        {
            return _documentRepository.GetActiveListByCategory(categoryCode);
        }

        public IEnumerable<Document> GetCancelledListByCategory(int categoryCode)
        {
            return _documentRepository.GetCancelledListByCategory(categoryCode);
        }

        public IEnumerable<Document> GetRevisedListByCategory(int categoryCode)
        {
            return _documentRepository.GetRevisedListByCategory(categoryCode);
        }
    }
}