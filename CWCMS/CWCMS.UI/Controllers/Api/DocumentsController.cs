using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CWCMS.Core.Models;
using CWCMS.Application.BLServices;
using CWCMS.UI.DTO;
using System;

namespace CWCMS.UI.Controllers.Api
{
    public class DocumentsController : ApiController
    {

        //GET /api/documents/{id}
        //gets active documents by its category id
        //check documentID table for type id's
        //tested & done
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
                if (a.PublishDate != System.Data.SqlTypes.SqlDateTime.MinValue.Value)
                {
                    b.PublishDate = a.PublishDate.ToString();
                }
                else
                {
                    b.PublishDate = "Yayında Değil";
                }
                b.PublisherID = a.PublisherID.ToString();
                b.Title = a.Title;
                b.SystemUpdateDate = a.SystemUpdateDate.ToString();
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

        //POST /api/documents/
        //this api accepts Document class type
        //responds with either saved file's info or error message (will be developed)
        [HttpPost]
        public DocumentDTO getDocuments([FromBody]Document getDocument)
        {
            Guid fileID;
            DocumentServices x=new DocumentServices();
            fileID=x.UploadDocument(getDocument);
            Infrastructure.Repositories.DocumentRepository interfaceVar = new Infrastructure.Repositories.DocumentRepository();
            var uploadedFile = interfaceVar.FindDocumentByID(fileID);
            DocumentDTO b = new DocumentDTO();
            b.Content = uploadedFile.Content;
            if (uploadedFile.PublishDate != System.Data.SqlTypes.SqlDateTime.MinValue.Value)
            {
                b.PublishDate = uploadedFile.PublishDate.ToString();
            }
            else
            {
                b.PublishDate = "Yayında Değil";
            }
            b.PublisherID = uploadedFile.PublisherID.ToString();
            b.Title = uploadedFile.Title;
            b.SystemUpdateDate = uploadedFile.SystemUpdateDate.ToString();
            b.ReferenceNumber = uploadedFile.ReferenceNumber;
            Infrastructure.Repositories.EndDateRepository temp = new Infrastructure.Repositories.EndDateRepository();
            try
            {
                EndDate c = temp.ListEndDateByGuid(uploadedFile.DocumentID).Single();
                b.ExpirationDate = c.ExpirationDate.ToString();
            }
            catch
            {
                b.ExpirationDate = "Süresiz";
            }
            return b;

        }

    }
}
