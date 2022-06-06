using AutoMapper;
using Services.ProductAPI.Models;
using Services.ProductAPI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.ProductAPI
{
    public class MapperConfig
    {
        public static MapperConfiguration ConfigureMapping()
        {
            var mapperConfig = new MapperConfiguration(config => {
                config.CreateMap<ProductDTO, Product>().ReverseMap();
            });

            return mapperConfig;
        }
    }
}
