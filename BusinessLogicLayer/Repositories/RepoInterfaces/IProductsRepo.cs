using Dokaanah.Models;

namespace Dokaanah.Repositories.RepoInterfaces
{
    public interface IProductsRepo : IGenericRepository<Product, int>
    {


        List<Product> GetRandomProducts(int count);

        void AddProductToCart(int productId, int cartId);

        List<Product> GetProductsWithItsCategories();
        
        public IQueryable<Product> SearchByName(string Name);
         

        //public IEnumerable<Product> GetPrdCat();
        //public IQueryable<Product> SearchByPrice(float startRange, float endRange);
        //public IEnumerable<Product> GetTopRate();
        //public List<string> GetAllImgURL();
        //public Product GetById(int id); 
    }
}
