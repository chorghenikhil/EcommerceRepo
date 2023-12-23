using EcommerceDAL.Models;

namespace EcommerceService.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
