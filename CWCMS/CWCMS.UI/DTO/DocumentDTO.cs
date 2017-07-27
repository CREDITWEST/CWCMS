using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CWCMS.Core.Models;
namespace CWCMS.UI.DTO
{
    public class DocumentDTO
    {
        public DocumentDTO()
        {

        }
        // Title of the document
        public String Title { get; set; }

        // Content of the document
        public String Content { get; set; }

        // ID of the Personel who originally publish the document
        public Guid PublisherID { get; set; }

        // Date of the publishing operation
        public DateTime PublishDate { get; set; }

        // Date of the Loading system
        public DateTime SystemUpdateDate { get; set; }

        // Another Unique Identifier of the document which keep record at Bank System and regulated by legislation
        public String ReferenceNumber { get; set; }

        // Date of the expiration of the document
        public string ExpirationDate { get; set; }
    }
}