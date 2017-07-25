using CWCMS.Application.BusinessLogicInterfaces.DocumentUploadingLogic;
using CWCMS.Core.Models;
using CWCMS.Infrastructure.Repositories;

namespace CWCMS.Application.DocumentLogic.DocumentUploadingRepositories
{
    internal class DocumentUploadRepository : IDocumentUploadRepository
    {
        private DocumentRepository _documentRepository;

        /* Normally this part contains much more detail
         * but for getting ready to 07/28 Demonstration
         * includes only simple crud op content
         * In normal circumstances this class should do
         * getting Created Doc model adding reference and guid
         * checking is this reference is in SQL
         * Filling necessary part and saving its GUID to the wait signature table
        */

        private Document _document;

        public DocumentUploadRepository()
        {
            this._documentRepository = new DocumentRepository();
            this._document = new Document();
        }

        public void UploadToServerDocument(Document createdRecord)
        {
            _documentRepository.Add(createdRecord);
        }
    }
}