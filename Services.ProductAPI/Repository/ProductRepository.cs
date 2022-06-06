using AutoMapper;
using Mango.MessageBus;
using Microsoft.EntityFrameworkCore;
using Services.ProductAPI.DBContext;
using Services.ProductAPI.Models;
using Services.ProductAPI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDBContext _dbContext;
        private IMapper _mapper;
        private IMessageBus _azureMessageBus;
        private BaseMessage _baseMessage { get; set; }

        public ProductRepository(ApplicationDBContext dbContext, IMapper mapper, IMessageBus azureMessageBus)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
            this._azureMessageBus = azureMessageBus;
            _baseMessage = new BaseMessage();
        }
        public async Task<ProductDTO> CreateUpdateProduct(ProductDTO productDTO)
        {
            try
            {
                if(productDTO != null)
                {
                    var product = _mapper.Map<ProductDTO, Product>(productDTO);

                    if(product.ProductId > 0)
                    {
                        _dbContext.Update(product);
                    }
                    else
                    {
                        _dbContext.Add(product);
                    }
                    await _dbContext.SaveChangesAsync();

                    
                    
                }
            }
            catch(Exception ex)
            {
                
            }
            return productDTO;
        }

        public async Task<bool> DeleteProduct(int productID)
        {
            try
            {
               var result =  await _dbContext.Products.Where(x => x.ProductId == productID).FirstOrDefaultAsync();
                if(result == null)
                {
                    return false;
                }
                _dbContext.Products.Remove(result);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public async Task<ProductDTO> GetProductByID(int ProductID)
        {
            Product product = await _dbContext.Products.Where(x => x.ProductId == ProductID).FirstOrDefaultAsync();
            _baseMessage.Id = ProductID;
            _baseMessage.MessageTime = DateTime.Now;

            await _azureMessageBus.PublishMessage(_baseMessage, "createproductmessagetopic");
            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            IEnumerable<Product> products = await _dbContext.Products.ToListAsync();
            _baseMessage.Id = 1;
            _baseMessage.MessageTime = DateTime.Now;

            await _azureMessageBus.PublishMessage(_baseMessage, "createproductmessagetopic");
            return _mapper.Map<List<ProductDTO>>(products);
        }
    }
}
