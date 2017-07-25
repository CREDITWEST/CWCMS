using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWCMS.Application.BusinessLogicInterfaces.DocumentReferencingLogic.EditionReferencing
{
    public interface IEditionReferencingSubTypeLogic
    {
        // Generation of Reference Code while Revisiting Actual Document in other types listed here -> Legislation , Circular , Announcement
        string GenerateReferenceCodeForRevisedSubTypeDocument(string mainCategoryCode, string subCategoryCode, int sequenceCode);
    }
}
