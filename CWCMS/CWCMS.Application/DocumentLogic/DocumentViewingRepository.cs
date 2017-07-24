using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CWCMS.Application.BusinessLogicInterfaces;
using CWCMS.Core.Models;

namespace CWCMS.Application.DocumentRepositoryLogic
{
    class DocumentViewingRepository : IDocumentViewingRepository
    {
        public IEnumerable<Document> ListActiveDocumentsByCategory(int documentTypeID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Document> ListCancelledDocumentsByCategory(int documentTypeID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Document> ListRevisedDocumentsByCategory(int documentTypeID)
        {
            throw new NotImplementedException();
        }

        public Document searchDocumentByReferenceCode(string referenceNumber)
        {
            throw new NotImplementedException();
        }
    }
}
