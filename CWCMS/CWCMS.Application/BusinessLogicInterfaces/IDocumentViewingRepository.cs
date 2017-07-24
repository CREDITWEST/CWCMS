using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CWCMS.Core.Models;

namespace CWCMS.Application.BusinessLogicInterfaces
{
    interface IDocumentViewingRepository
    {
        IEnumerable<Document> ListDocuments();





    }
}
