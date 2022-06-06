using Services.ProductAPI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDTO>> GetProducts();

        Task<ProductDTO> GetProductByID(int ProductID);

        Task<ProductDTO> CreateUpdateProduct(ProductDTO product);

        Task<bool> DeleteProduct(int productID);
    }
}
