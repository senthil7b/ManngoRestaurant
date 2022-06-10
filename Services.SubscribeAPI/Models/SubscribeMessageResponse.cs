using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.SubscribeAPI.Models
{
    public class SubscribeMessageResponse
    {
        public string MessageId { get; set; }

        public bool IsSuccess { get; set; }

        public object Result { get; set; }

        public string DisplayMessage { get; set; } = "";

        public List<string> ErrorMessages { get; set; }
    }
}
