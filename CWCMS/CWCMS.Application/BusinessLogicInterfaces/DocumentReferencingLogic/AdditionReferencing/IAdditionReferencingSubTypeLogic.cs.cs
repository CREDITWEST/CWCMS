namespace CWCMS.Application.BusinessLogicInterfaces.DocumentReferencingLogic.AdditionReferencing
{
    public interface IAdditionReferencingSubTypeLogic
    {
        // Generation of Reference Code while Adding New Document in other types not ordered here -> Legislation , Circular , Announcement
        string GenerateReferenceForAddingSubType(string mainCategoryCode, string subCategoryCode, int mainSequenceCode);
    }
}