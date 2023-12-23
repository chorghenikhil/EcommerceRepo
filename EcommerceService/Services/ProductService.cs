using EcommerceDAL.Models;
using EcommerceDAL.Repositories;

namespace EcommerceService.Services
{
    public class ProductService:IProductService
    {
        private readonly IDbRepository _dbRepository;
        public ProductService(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }
        public async Task< IEnumerable<Product>> GetProducts()
        {
            return await _dbRepository.FetchProducts();
        }
    }
}
