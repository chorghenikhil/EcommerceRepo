using EcommerceDAL.Models;

namespace EcommerceService.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<bool> AddProducts(Product product);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(Product product);

    }
}
