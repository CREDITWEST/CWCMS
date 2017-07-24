using CWCMS.Application.BusinessLogicInterfaces.DocumentRetrievingLogic;
using CWCMS.Core.Models;
using CWCMS.Infrastructure.Repositories;
using System;

namespace CWCMS.Application.DocumentLogic.DocumentRetrievingRepositories
{
    internal class SpecificDocumentReturnRepository : ISpecificDocumentReturnRepository
    {
        private DocumentRepository _documentRepository;

        public SpecificDocumentReturnRepository()
        {
            this._documentRepository = new DocumentRepository();
        }

        public Document GetActiveDocumentByGuid(Guid documentGuid)
        {
            return _documentRepository.GetActiveDocumentByGuid(documentGuid);
        }

        public Document GetActiveDocumentByReferenceCode(string referenceCode)
        {
            return _documentRepository.GetActiveDocumentByReferenceCode(referenceCode);
        }

        public Document GetCancelledDocumentByGuid(Guid documentGuid)
        {
            return _documentRepository.GetCancelledDocumentByGuid(documentGuid);
        }

        public Document GetCancelledDocumentByReferenceCode(string referenceCode)
        {
            return _documentRepository.GetCancelledDocumentByReferenceCode(referenceCode);
        }

        public Document GetRevisedDocumentByGuid(Guid documentGuid)
        {
            return _documentRepository.GetRevisedDocumentByGuid(documentGuid);
        }

        public Document GetRevisedDocumentByReferenceCode(string referenceCode)
        {
            return _documentRepository.GetRevisedDocumentByReferenceCode(referenceCode);
        }
    }
}