using Dokaanah.Models;
using Dokaanah.Repositories.RepoInterfaces;
using Microsoft.EntityFrameworkCore;

namespace Dokaanah.Repositories.RepoClasses
{
    public class GenericRepository<T, V> : IGenericRepository<T, V> where T : class
    { 
        private protected readonly Dokkanah2Contex dokkanah2;
        public GenericRepository(Dokkanah2Contex c1ontex10)  =>  dokkanah2 = c1ontex10;
         
        public IEnumerable<T> GetAll()  => (from a in dokkanah2.Set<T>() select a).ToList();
            
        public T GetById(V id)   =>  dokkanah2.Find<T>(id);
             

        public int Insert(T order)
          {    dokkanah2.Add(order);  return dokkanah2.SaveChanges();  }

        public int Update(T order)     {  dokkanah2.Update(order);   return dokkanah2.SaveChanges();  }
   
        public int Delete(T order)
         {    dokkanah2.Remove(order); return dokkanah2.SaveChanges();   }
         

    }
}
