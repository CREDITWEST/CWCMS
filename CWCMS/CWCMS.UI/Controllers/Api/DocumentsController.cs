using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CWCMS.Core.Models;
using CWCMS.Application.BLServices;
using CWCMS.UI.DTO;
using System.Web.Http.Results;

namespace CWCMS.UI.Controllers.Api
{
    public class DocumentsController : ApiController
    {

        //GET /api/documents/{id}
        //gets active documents by its category id
        //check documentID table for type id's
        [HttpGet]
        public IEnumerable<DocumentDTO> ActiveDocumentsbyCategory(int id)
        {
            DocumentServices activeDocuments = new DocumentServices();
            var x = activeDocuments.CategorisedRetrievingActiveDocuments(id).ToList();
            List<DocumentDTO> y = new List<DocumentDTO>();
            foreach (var a in x)
            {
                DocumentDTO b = new DocumentDTO();
                b.Content = a.Content;
                b.PublishDate = a.PublishDate;
                b.PublisherID = a.PublisherID;
                b.Title = a.Title;
                b.SystemUpdateDate = a.SystemUpdateDate;
                b.ReferenceNumber = a.ReferenceNumber;
                Infrastructure.Repositories.EndDateRepository temp = new Infrastructure.Repositories.EndDateRepository();
                try
                {
                    EndDate c = temp.ListEndDateByGuid(a.DocumentID).Single();
                    b.ExpirationDate = c.ExpirationDate.ToString();
                }
                catch
                {
                    b.ExpirationDate = "Süresiz";
                }
                y.Add(b);
            }
            return y;
        }
        [HttpPost]
        public DocumentDTO getDocuments([FromBody]Document getDocument)
        {
            var tempDoc = new DocumentDTO();
            tempDoc.Content = getDocument.Content;
            tempDoc.Title = getDocument.Title;
            //tempDoc.FilePath = getDocument.FilePath;
           // tempDoc.DocumentTypeID = getDocument.DocumentTypeID;
            return tempDoc;
        }

    }
}
