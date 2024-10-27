using Dokaanah.Models;
using Dokaanah.Repositories.RepoInterfaces;
using Microsoft.EntityFrameworkCore;

namespace Dokaanah.Repositories.RepoClasses
{
    public class CategoriesRepo : GenericRepository<Category , int>, ICategoriesRepo
    {
         public CategoriesRepo(Dokkanah2Contex c1ontex10):base(c1ontex10)
         {
         }

        // Get Products From all Categories
        public List<Product> GetAllProductsForAllCategories()
         =>  dokkanah2.Categories.SelectMany(c => c.Product_Categories).Select(p => p.P).ToList();
       
        // Get Products From Special Category
        public List<Product> GetProductsForCategory(int categoryId)
         => dokkanah2.Categories.Where(c => c.Id == categoryId).SelectMany(c => c.Product_Categories).Select(p => p.P).ToList();
 
    }
}
