using Dokaanah.Models;
using Dokaanah.Repositories.RepoInterfaces;
using Microsoft.EntityFrameworkCore;

namespace Dokaanah.Repositories.RepoClasses
{
    public class Product_CategoryRepo : GenericRepository<Product_Category, int>, IProduct_CategoryRepo
    { 
        public Product_CategoryRepo(Dokkanah2Contex c1ontex10):base(c1ontex10)
        { 
        } 
           
    }

}
