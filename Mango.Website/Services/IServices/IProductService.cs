using Mango.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Website.Services.IServices
{
    public interface IProductService : IBaseService
    {
        Task<T> GetAllProductsAsync<T>();

        Task<T> GetProductsByID<T>(int id);

        Task<T> CreateProductAsync<T>(ProductDTO productDTO);

        Task<T> UpdateProductAsync<T>(ProductDTO productDTO);

        Task<T> DeleteProductAsync<T>(int id);
    }
}
