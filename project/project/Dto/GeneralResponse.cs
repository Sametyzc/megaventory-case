using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace project.Dto
{
    public class GeneralResponse
    {
        private HttpStatusCode code;

        public HttpStatusCode Code
        {
            get { return code; }
            set
            {
                code = value;
            }
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object Data { get; set; }

        public GeneralResponse()
        {
            Code = HttpStatusCode.Forbidden;
        }

        public GeneralResponse(HttpStatusCode code)
        {
            Code = code;
        }
    }
}
