
using EcommerceDAL.Models;
using Microsoft.EntityFrameworkCore;
namespace Entities
{
    public class RepositoryDbContext : DbContext
    {
        public RepositoryDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<EcommerceDAL.Models.Attribute>? Attributes { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Category>? Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          //  optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test");


        }
       
    }
   
}