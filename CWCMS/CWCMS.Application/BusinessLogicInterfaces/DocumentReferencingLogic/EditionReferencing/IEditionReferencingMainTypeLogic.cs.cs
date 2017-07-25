using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWCMS.Application.BusinessLogicInterfaces.DocumentReferencingLogic.EditionReferencing
{
    public interface IEditionReferencingMainTypeLogic
    {

        // Generation of Reference Code while Revising Actual Document in these types -> Legislation , Circular , Announcement
        string GenerateReferenceCodeForRevisedMainTypeDocument(string categoryCode, int sequenceNumber);
    }
}
