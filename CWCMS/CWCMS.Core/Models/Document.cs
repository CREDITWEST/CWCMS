using System;

namespace CWCMS.Core.Models
{
    public class Document
    {
        // Guid type uniqueidentifier of the document which is also Primary Key of the entity
        public Guid DocumentID { get; set; }

        // Title of the document
        public String Title { get; set; }

        // Content of the document
        public String Content { get; set; }

        // Path of the file which will be attached to the record in pdf form
        public String FilePath { get; set; }

        // ID of the Personel who originally publish the document
        public Guid PublisherID { get; set; }

        // Date of the publishing operation
        public DateTime PublishDate { get; set; }

        // Date of the Loading system
        public DateTime SystemUpdateDate { get; set; }

        // Another Unique Identifier of the document which keep record at Bank System and regulated by legislation
        public String ReferenceNumber { get; set; }

        // Boolean that keeps the document is signed or not
        public Boolean isSigned { get; set; }
    }
}