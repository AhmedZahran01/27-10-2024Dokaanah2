using Dokaanah.Models;
using Dokaanah.Repositories.RepoInterfaces;
using Microsoft.EntityFrameworkCore;

namespace Dokaanah.Repositories.RepoClasses
{
    public class ProductsRepo : GenericRepository<Product, int>,  IProductsRepo
    {
        #region constroctor
 
        public ProductsRepo(Dokkanah2Contex context):base(context) 
        {
         
        }
        #endregion
           
        public List<Product> GetRandomProducts(int count)
         => dokkanah2.Products.OrderBy(p => Guid.NewGuid()).Take(count).ToList();
         
        public List<Product> GetProductsWithItsCategories()
         =>   dokkanah2.Products.
                Include(x=>x.Product_Categories).ToList();
         
        public IQueryable<Product> SearchByName(string name)
          => dokkanah2.Products.Where(p => p.Name.ToLower().Contains(name));

        public void AddProductToCart(int productId, int cartId)
        {
            var cartProduct = new Cart_Product
            {
                Prid = productId,
                Caid = cartId
            }; 
            dokkanah2.Cart_Products.Add(cartProduct);
            dokkanah2.SaveChanges();
        }
   
    }
}
