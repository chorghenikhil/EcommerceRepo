using EcommerceDAL.Models;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace EcommerceDAL.Repositories
{
    public class DbRepository : IDbRepository
    {
        private readonly RepositoryDbContext _dbContext;
        public DbRepository(RepositoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Product>> FetchProducts()
        {
            return await _dbContext.Products.ToListAsync();
        }
        public async Task<bool> AddProducts(Product product)
        {
            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateProduct(Product product)
        {
           _dbContext.Update(product);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteProduct(Product product)
        {
            product.IsDeleted= false;
            _dbContext.Update(product);
            await _dbContext.SaveChangesAsync();
            return true;
        }



        public async Task<IEnumerable<Category>> FetchCategories()
        {
            return await _dbContext.Categories.ToListAsync();
        }

        public async Task<bool> AddCategories(Category category)
        {
            await _dbContext.Categories.AddAsync(category);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateCategory(Category category)
        {
            _dbContext.Update(category);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeletCategory(Category category)
        {
            category.IsDeleted = false;
            _dbContext.Update(category);
            await _dbContext.SaveChangesAsync();
            return true;
        }



    }
}

