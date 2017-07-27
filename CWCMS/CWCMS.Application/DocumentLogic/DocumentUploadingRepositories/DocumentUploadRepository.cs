using CWCMS.Application.BusinessLogicInterfaces.DocumentUploadingLogic;
using CWCMS.Application.DocumentLogic.DocumentReferencingRepositories.AdditionReferencing;
using CWCMS.Core.Models;
using CWCMS.Infrastructure.Repositories;
using System;

namespace CWCMS.Application.DocumentLogic.DocumentUploadingRepositories
{
    public class DocumentUploadRepository : IDocumentUploadRepository
    {
        private DocumentRepository _documentRepository;
        private AdditionReferencingMainTypeLogic _additionMaintypeReferencing;
        private object[] _refCodeFileSeqObject;
        private FileSequence _fileSequenceGeneratedReferance;
        private FileSequenceRepository _fileSequenceRepository;

        // 28/07 demonstration constraint we assume all documents published when they added to the system
        private Active _activeRecord;

        private ActiveRepository _activeRepository;

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
            this._additionMaintypeReferencing = new AdditionReferencingMainTypeLogic();
            this._refCodeFileSeqObject = new object[2];
            this._fileSequenceGeneratedReferance = new FileSequence();
            this._fileSequenceRepository = new FileSequenceRepository();

            // 28/07 demonstration constraint we assume all documents published when they added to the system
            this._activeRecord = new Active();
            this._activeRepository = new ActiveRepository();
        }

        public Guid UploadToServerDocument(Document createdRecord)
        {
            // Adding GUID to the Document as a primary key
            createdRecord.DocumentID = Guid.NewGuid();

            // This part will be come from API but for now we add GUID also PublisherID
            createdRecord.PublisherID = Guid.NewGuid();
            // We reference to the necessary logic part for generating logic
            _refCodeFileSeqObject = _additionMaintypeReferencing.GenerateReferenceForAddingMainType(createdRecord.DocumentTypeID, createdRecord.PublisherID);

            createdRecord.ReferenceNumber = (string)_refCodeFileSeqObject[0];
            _fileSequenceGeneratedReferance = (FileSequence)_refCodeFileSeqObject[1];
            // Initially we do it false
            createdRecord.isSigned = false;

            createdRecord.SystemUpdateDate = DateTime.Now;
            /* Thats Bug*/
            createdRecord.PublishDate = DateTime.Now;
            // 28/07 demonstration constraint we assume all documents published when they added to the system
            _activeRecord.DocumentID = createdRecord.DocumentID;

            // In these part we add our document to the DocumentTable
            _documentRepository.Add(createdRecord);

            // 28/07 demonstration constraint we assume all documents published when they added to the system
            _activeRepository.Add(_activeRecord);

            /* This part is the required modification for referencing logic that prevents increasing
             * the SequenceNumber when unsuccessful file upload occured
             */

            // If Sequence number is two that means there is no record exist in DB for these type
            // Then we create initial one for that
            if (_fileSequenceGeneratedReferance.SequenceNumber == 2)
            {
                _fileSequenceRepository.Add(_fileSequenceGeneratedReferance);
            }

            // If it is more than two we should add it to the increment one
            else
            {
                _fileSequenceGeneratedReferance.SequenceNumber++;
                _fileSequenceRepository.Edit(_fileSequenceGeneratedReferance);
            }

            return createdRecord.DocumentID;
        }
    }
}