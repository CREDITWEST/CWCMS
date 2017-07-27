using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CWCMS.UI.DTO
{
    public class GetDocumentDto
    {
        // Title of the document
        [JsonProperty("Title")]
        public String Title { get; set; }
        // Content of the document
        [JsonProperty("Content")]
        public String Content { get; set; }
        // Path of the file which will be attached to the record in pdf form
        [JsonProperty("FilePath")]
        public String FilePath { get; set; }
        // Type of the Document
        [JsonProperty("DocumentTypeID")]
        public int DocumentTypeID { get; set; }
    }
}