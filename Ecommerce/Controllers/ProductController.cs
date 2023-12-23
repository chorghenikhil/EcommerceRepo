using EcommerceDAL.Models;
using EcommerceService.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    [ApiController]
    [Route("v1/Ecommerce")]
    public class ProductController : ControllerBase
    {
      
        private readonly ILogger<ProductController> _logger;

        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;

        }

        //get

        //add/update

        //delete



        [HttpGet]
        [Route("GetProducts")]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _productService.GetProducts();
        }


        [HttpPost]
        [Route("AddProducts")]
        public async Task<bool> Post([FromBody] Product product)
        {
            return await  _productService.AddProducts(product);
        }

        [HttpPost]
        [Route("UpdateProducts")]
        public async Task<bool> Update([FromBody] Product product)
        {
            return await _productService.UpdateProduct(product);
        }

        [HttpPost]
        [Route("DeleteProducts")]
        public async Task<bool> Delete([FromBody] Product product)
        {
            return await _productService.DeleteProduct(product);
        }

    }
}
