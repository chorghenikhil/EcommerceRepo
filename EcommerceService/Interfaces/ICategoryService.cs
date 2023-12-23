using EcommerceDAL.Models;

namespace EcommerceService.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategories();
        Task<bool> AddCategories(Category category);
        Task<bool> UpdateCategory(Category category);
        Task<bool> DeletCategory(Category category);
    }
}
