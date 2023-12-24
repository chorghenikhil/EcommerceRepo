using EcommerceDAL.Models;
using EcommerceDAL.Repositories;

namespace EcommerceService.Services
{
    public class ProductService:IProductService
    {
        private readonly IDbRepository _dbRepository;
        private readonly IProductService productService;
        public ProductService(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }
        public async Task< IEnumerable<Product>> GetProducts()
        {
            return await _dbRepository.FetchProducts();
        }


        public async Task<bool> AddProducts(Product product)
        {
            product.Id = Guid.NewGuid();
            return await _dbRepository.AddProducts(product);
        }

        public async Task<bool> UpdateProduct(Product product)
        {
           
            return await _dbRepository.UpdateProduct(product);
        }

        public async Task<bool> DeleteProduct(Product product)
        {
          
            return await _dbRepository.DeleteProduct(product);
        }

    }
}
