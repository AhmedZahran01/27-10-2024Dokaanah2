using Dokaanah.Models;

namespace Dokaanah.Repositories.RepoInterfaces
{
    public interface ICategoriesRepo : IGenericRepository<Category, int>
    {
        List<Product> GetAllProductsForAllCategories();

        List<Product> GetProductsForCategory(int categoryId);
         
    }
}
