using Dokaanah.Models;
using Dokaanah.Repositories.RepoInterfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Dokaanah.Repositories.RepoClasses
{

    public class CartProductRepository : GenericRepository<Cart_Product, int>, ICartProductRepo
    { 
        public CartProductRepository(Dokkanah2Contex context):base(context)
        {   
        }

        public Cart_Product GetAll(int productId, int cartId)
       => dokkanah2.Cart_Products
                .FirstOrDefault(cp => cp.Prid == productId && cp.Caid == cartId);
       
    }
}

