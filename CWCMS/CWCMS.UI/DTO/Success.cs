using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CWCMS.UI.DTO
{
    public class Success
    {
        //return message 
        [JsonProperty("success")]
        public bool success;
    }
}