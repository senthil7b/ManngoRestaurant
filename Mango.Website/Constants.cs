using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Website
{
    public static class Constants
    {
        public static string ProductAPIBase { get; set; }

        public enum APIType
        {
            GET,
            PUT,
            POST,
            DELETE
        }
    }
}
