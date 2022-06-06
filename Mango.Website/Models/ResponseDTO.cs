using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Website.Models
{
    public class ResponseDTO
    {
        public List<string> ErrorMessages { get; set; }

        public string DisplayMessage { get; set; }

        public bool IsSuccess { get; set; }

        public object Result { get; set; }
    }
}
