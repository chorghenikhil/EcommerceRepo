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
        public async Task<bool> AddProduct(Product product)
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
    }
}

