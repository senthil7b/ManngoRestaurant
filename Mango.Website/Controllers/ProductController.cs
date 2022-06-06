using Mango.Website.Models;
using Mango.Website.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Website.Controllers
{
    
    public class ProductController : Controller
    {
        private IProductService _productService { get; set; }
        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }
        public async Task<IActionResult> ProductIndex()
        {
            List<ProductDTO> list = null;
            var response = await _productService.GetAllProductsAsync<ResponseDTO>();
            if(response != null)
            {
                list = JsonConvert.DeserializeObject<List<ProductDTO>>(Convert.ToString(response.Result));
            }
            return View(list);
        }
    }
}
