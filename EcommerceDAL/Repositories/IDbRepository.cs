using EcommerceDAL.Models;

namespace EcommerceDAL.Repositories
{
    public interface IDbRepository
    {
        Task<IEnumerable<Product>> FetchProducts();
    }
}
