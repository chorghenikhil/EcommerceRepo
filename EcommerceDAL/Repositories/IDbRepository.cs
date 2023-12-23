using EcommerceDAL.Models;

namespace EcommerceDAL.Repositories
{
    public interface IDbRepository
    {
        Task<IEnumerable<Product>> FetchProducts();
        Task<bool> AddProducts(Product product);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(Product product);


        Task<IEnumerable<Category>> FetchCategories();
        Task<bool> AddCategories(Category category);
        Task<bool> UpdateCategory(Category category);
        Task<bool> DeletCategory(Category category);
    }

}
