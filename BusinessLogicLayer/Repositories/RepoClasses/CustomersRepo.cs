using Dokaanah.Models;
using Dokaanah.Repositories.RepoInterfaces;
using Microsoft.EntityFrameworkCore;

namespace Dokaanah.Repositories.RepoClasses
{
    public class CustomersRepo: GenericRepository<Customer,String>,  ICustomersRepo
    {
        public CustomersRepo(Dokkanah2Contex dokkanah2):base(dokkanah2)
        {
        }
    }
}
