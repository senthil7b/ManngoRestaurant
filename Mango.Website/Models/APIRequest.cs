using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Mango.Website.Constants;

namespace Mango.Website.Models
{
    public class APIRequest
    {
        public APIType aPIType { get; set; } = APIType.GET;

        public string URL { get; set; }

        public Object Data { get; set; }

        public string AccessToken { get; set; }
    }
}
