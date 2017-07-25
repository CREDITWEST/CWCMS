namespace CWCMS.Application.BusinessLogicInterfaces.DocumentReferencingLogic.AdditionReferencing
{
    public interface IAdditionReferencingMainTypeLogic
    {
        // Generation of Reference Code while Adding New Document in these types -> Legislation , Circular , Announcement
        string GenerateReferenceForAddingMainType(string categoryCode);
    }
}