using CWCMS.Application.BusinessLogicInterfaces.DocumentReferencingLogic.AdditionReferencing;
using CWCMS.Core.Models;
using CWCMS.Infrastructure.Repositories;
using System;

namespace CWCMS.Application.DocumentLogic.DocumentReferencingRepositories.AdditionReferencing
{
    public class AdditionReferencingMainTypeLogic : IAdditionReferencingMainTypeLogic
    {

        private string _referenceCode;
        private FileSequence _revisionedSequence;
        private int _categoryCode;
        private FileSequenceRepository _fileSequenceRepository;

        public AdditionReferencingMainTypeLogic()
        {
            this._referenceCode = "";
            this._revisionedSequence = new FileSequence();
            this._categoryCode = 0;
            this._fileSequenceRepository = new FileSequenceRepository();
        }


        public void FileSequenceInitilizer()
        {
            _revisionedSequence.SequenceNumber = 2;


            switch (_categoryCode)
            {
                case 1:
                    _revisionedSequence.FileType = "Y";
                    break;
                case 2:
                    _revisionedSequence.FileType = "G";
                    break;
                default:
                    _revisionedSequence.FileType = "G";
                    break;


            }
        }

        public string GenerateCategoryCode()
        {
            switch (_categoryCode)
            {
                case 1:
                    return "Y";

                case 2:
                    return "G";

                default:
                    return "D";
            }
        }

        public string GenerateDepartmentCode(Guid userGuid)
        {
            /* This part is under construction until settin up User Info API's
             * because department code will be achieved by userinfo
             * wrt user's Guid
             */

            // For the good of test records initially I set it up as a IT Department code

            return "11";
        }

        public string GenerateReferenceForAddingMainType(int docType, Guid userGuid)
        {

            _categoryCode = docType;

            _referenceCode += GenerateDepartmentCode(userGuid);
            _referenceCode += ".";

            _referenceCode += GenerateCategoryCode();

            _referenceCode += GenerateSequentialLineNumber(GenerateCategoryCode());

            _referenceCode += ".";

            _referenceCode += GenerateRevisionCode();

            return _referenceCode;


        }

        public string GenerateRevisionCode()
        {
            return _categoryCode == 1 ? "V0" : "R0";
        }

        public string GenerateSequentialLineNumber(string categoryLetter)
        {
            int sequenceNumber;
            string _sequentialNumber="";

            if(_fileSequenceRepository.LastSequenceNumberOfSpecificType(categoryLetter) == 0 )
            {
                _sequentialNumber = "001";
                //FileSequenceInitilizer();
                //_fileSequenceRepository.Add(_revisionedSequence);
            }
            else
            {
                string numberRepresentation = "";
                sequenceNumber = _fileSequenceRepository.LastSequenceNumberOfSpecificType(categoryLetter);

                //_revisionedSequence = _fileSequenceRepository.FindFileSequenceByDocumentType(categoryLetter);

                //_revisionedSequence.SequenceNumber++;

                //_fileSequenceRepository.Edit(_revisionedSequence);


                if(sequenceNumber < 10)
                {
                    _sequentialNumber += "00";
                    numberRepresentation = sequenceNumber.ToString();
                    _sequentialNumber += numberRepresentation;

                }else if(sequenceNumber < 100)
                {
                    _sequentialNumber += "0";
                    numberRepresentation = sequenceNumber.ToString();
                    _sequentialNumber += numberRepresentation;
                }
                else
                {
                    _sequentialNumber = sequenceNumber.ToString();
                }
            }

            return _sequentialNumber;
        }

        
    }
}