using CWCMS.Application.BusinessLogicInterfaces.DocumentReferencingLogic.AdditionReferencing;
using CWCMS.Core.Models;
using CWCMS.Infrastructure.Repositories;
using System;

namespace CWCMS.Application.DocumentLogic.DocumentReferencingRepositories.AdditionReferencing
{
    public class AdditionReferencingMainTypeLogic : IAdditionReferencingMainTypeLogic
    {
        // These will be our final reference code and will be returned in _returnArray with 0 index
        private string _referenceCode;

        // This is the record considered as a reference
        private FileSequence _revisionedSequence;

        /* This is the category of the reference number requesting document
         * 1 = > Legislation
         * 2 = > Circular
         * 3 = > Announcement
        */

        private int _categoryCode;

        // For doing operations about reference choosen FileSequence record
        private FileSequenceRepository _fileSequenceRepository;

        // This is the return array for carrying FileSequence object and reference code
        private object[] _returnArray;


        // Constructor
        public AdditionReferencingMainTypeLogic()
        {
            this._referenceCode = "";
            this._revisionedSequence = new FileSequence();
            this._categoryCode = 0;
            this._fileSequenceRepository = new FileSequenceRepository();
            this._returnArray = new object[2];
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

        public object[] GenerateReferenceForAddingMainType(int docType, Guid userGuid)
        {
            _categoryCode = docType;

            _referenceCode += GenerateDepartmentCode(userGuid);
            _referenceCode += ".";

            _referenceCode += GenerateCategoryCode();

            _referenceCode += GenerateSequentialLineNumber(GenerateCategoryCode());

            _referenceCode += ".";

            _referenceCode += GenerateRevisionCode();

            _returnArray[0] = _referenceCode;
            _returnArray[1] = _revisionedSequence;

            return _returnArray;
        }

        public string GenerateRevisionCode()
        {
            return _categoryCode == 1 ? "V0" : "R0";
        }

        public string GenerateSequentialLineNumber(string categoryLetter)
        {
            int sequenceNumber;
            string _sequentialNumber = "";

            if (_fileSequenceRepository.LastSequenceNumberOfSpecificType(categoryLetter) == 0)
            {
                _sequentialNumber = "001";
                FileSequenceInitilizer();
            }
            else
            {
                string numberRepresentation = "";
                sequenceNumber = _fileSequenceRepository.LastSequenceNumberOfSpecificType(categoryLetter);

                _revisionedSequence = _fileSequenceRepository.FindFileSequenceByDocumentType(categoryLetter);

                if (sequenceNumber < 10)
                {
                    _sequentialNumber += "00";
                    numberRepresentation = sequenceNumber.ToString();
                    _sequentialNumber += numberRepresentation;
                }
                else if (sequenceNumber < 100)
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