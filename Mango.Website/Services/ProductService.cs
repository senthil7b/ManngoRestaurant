using Mango.Website.Models;
using Mango.Website.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mango.Website.Services
{
    public class ProductService : BaseService, IProductService
    {
        private IHttpClientFactory _httpClientFactory { get; set; }

        public ProductService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory;
        }
        public async Task<T> CreateProductAsync<T>(ProductDTO productDTO)
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                aPIType = Constants.APIType.POST,
                Data = productDTO,
                URL = Constants.ProductAPIBase + "/api/Product",
                AccessToken = ""
            });
        }

        public async Task<T> DeleteProductAsync<T>(int id)
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                aPIType = Constants.APIType.DELETE,
                
                URL = Constants.ProductAPIBase + "/api/Product/" + id,
                AccessToken = ""
            });
        }

        public  async Task<T> GetAllProductsAsync<T>()
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                aPIType = Constants.APIType.GET,

                URL = Constants.ProductAPIBase + "/api/Product",
                AccessToken = ""
            });
        }

        public async Task<T> GetProductsByID<T>(int id)
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                aPIType = Constants.APIType.DELETE,

                URL = Constants.ProductAPIBase + "/api/Product/" + id,
                AccessToken = ""
            });
        }

        public async Task<T> UpdateProductAsync<T>(ProductDTO productDTO)
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                aPIType = Constants.APIType.PUT,
                Data = productDTO,
                URL = Constants.ProductAPIBase + "/api/Product",
                AccessToken = ""
            });
        }
    }
}
