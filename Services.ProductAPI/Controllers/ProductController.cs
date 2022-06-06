using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.ProductAPI.Models.DTO;
using Services.ProductAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        protected ProductResponseDTO _response;
        private IProductRepository _repository;

        public ProductController(IProductRepository productRepository)
        {
            this._repository = productRepository;
            this._response = new ProductResponseDTO();
        }

        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<ProductDTO> response = await _repository.GetProducts();
                _response.IsSuccess = true;
                _response.Result = response;
                
            }
            catch(Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>()
                {
                    ex.ToString()
                };
            }
            return _response;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<object> Get(int id)
        {
            try
            {
                ProductDTO response = await _repository.GetProductByID(id);
                _response.IsSuccess = true;
                _response.Result = response;

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>()
                {
                    ex.ToString()
                };
            }
            return _response;
        }

        [HttpPost]
        public async Task<object> Post([FromBody] ProductDTO product)
        {
            try
            {
                ProductDTO response = await _repository.CreateUpdateProduct(product);
                _response.IsSuccess = true;
                _response.Result = response;

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>()
                {
                    ex.ToString()
                };
            }
            return _response;
        }

        [HttpDelete]
        public async Task<object> Delete(int id)
        {
            try
            {
                _response.Result =_response.IsSuccess = await _repository.DeleteProduct(id);

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>()
                {
                    ex.ToString()
                };
            }
            return _response;
        }
    }
}
