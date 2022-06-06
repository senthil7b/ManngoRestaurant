using Mango.MessageBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.ProductAPI.Models.DTO
{
    public class ProductDTO : BaseMessage
    {
       
        public int ProductId { get; set; }


        public string Name { get; set; }

     
        public double Price { get; set; }

        public string Description { get; set; }

        public string CategoryName { get; set; }

        public string ImageURL { get; set; }
    }
}
