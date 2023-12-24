using EcommerceDAL.Models;
using EcommerceDAL.Repositories;

namespace EcommerceService.Services
{
    public class CategoryService :ICategoryService
    {

        private readonly IDbRepository _dbRepository;
        private readonly CategoryService categoryService;
        public CategoryService(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }
        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _dbRepository.FetchCategories();
        }


        public async Task<bool> AddCategories(Category category)
        {
            category.Id = Guid.NewGuid();
            return await _dbRepository.AddCategories(category);
        }

        public async Task<bool> UpdateCategory(Category category)
        {
          
            return await _dbRepository.UpdateCategory(category);
        }

        public async Task<bool> DeletCategory(Category category)
        {
          
            return await _dbRepository.DeletCategory(category);
        }


    }
}
