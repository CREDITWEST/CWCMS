using System;

namespace CWCMS.Application.BusinessLogicInterfaces.DocumentReferencingLogic.AdditionReferencing
{
    public interface IAdditionReferencingMainTypeLogic
    {
        // Generation of Reference Code while Adding New Document in these types -> Legislation , Circular , Announcement
        string GenerateReferenceForAddingMainType(int categoryCode, Guid userGuid);

        // For generating 3-digit departmen code from User Info
        string GenerateDepartmentCode(Guid userGuid);

        // For generateng Document CategoryLetter wrt its category code
        string GenerateCategoryCode();

        // For generating 3-digit sequence code wrt related look-up tables
        string GenerateSequentialLineNumber(string categoryLetter);

        // 000 for new addition always
        string GenerateRevisionCode();

        // If its first time we add in these type of document we should also create a record at DB
        void FileSequenceInitilizer();
    }
}