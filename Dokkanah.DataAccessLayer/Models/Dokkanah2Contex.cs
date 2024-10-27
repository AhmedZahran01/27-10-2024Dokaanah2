using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Dokaanah.Models
{
    public class Dokkanah2Contex: IdentityDbContext<Customer>
    {

        #region Constractor  Region
       
        public Dokkanah2Contex()
        {

        }

        public Dokkanah2Contex(DbContextOptions<Dokkanah2Contex> options)
        : base(options)
        {
        } 
        #endregion


        #region for identity

        //public virtual DbSet<Customer> Users { get; set; }
        //public virtual DbSet<IdentityRole> Roles { get; set; } 


        #endregion


        #region Dbsets Region
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customer1s { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Product_Category> Product_Categories { get; set; }
        public virtual DbSet<Cart_Product> Cart_Products { get; set; }



        #endregion

       
        #region   On Configuring Region

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        =>
        //UseSqlServer("Server=DESKTOP-0HPU58A\\SQLEXPRESS;Database=DokkanahDataBase_2fff;Encrypt=false;Trusted_Connection=True;TrustServerCertificate=True");

        optionsBuilder.UseMySQL(
            "server=localhost;database=DokkanahDataBas2e;uid=root;pwd=new_password;"
            );


        #endregion


        #region  On Model Creating Region
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product_Category>()
                .HasKey(e => new { e.Pid, e.Cid });

            modelBuilder.Entity<Cart_Product>()
                .HasKey(e => new { e.Prid, e.Caid });

        } 
        #endregion

 
    }
}
