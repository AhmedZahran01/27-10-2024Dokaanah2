using Dokaanah.Models;
using Dokaanah.Repositories.RepoClasses;
using Dokaanah.Repositories.RepoInterfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Dokaanah
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<Dokkanah2Contex>(options =>
            {
                options.UseMySQL("server=localhost;database=DokkanahDataBase;uid=root;pwd=new_password;");

            });
            builder.Services.AddScoped<ICartRepo, CartRepo>();
            builder.Services.AddScoped<IProductsRepo, ProductsRepo>();
            builder.Services.AddScoped<ICustomersRepo, CustomersRepo>();
              builder.Services.AddScoped<IOrdersRepo, OrdersRepo>();
            builder.Services.AddScoped<ICategoriesRepo, CategoriesRepo>();
            builder.Services.AddScoped<IProduct_CategoryRepo, Product_CategoryRepo>();
            builder.Services.AddScoped<ICartProductRepo, CartProductRepository>();
            builder.Services.AddIdentity<Customer, IdentityRole>(con =>
            {
                con.Password.RequireNonAlphanumeric=true;

            }).AddEntityFrameworkStores<Dokkanah2Contex>();
            builder.Services.AddDbContext<Dokkanah2Contex>(options =>
           options.UseMySQL("server=localhost;database=DokkanahDataBase;uid=root;pwd=new_password;") );
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.IsEssential = true;
            });
            var app = builder.Build();
           
            app.UseSession();
          
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/ErrorHandleForUser");

                //app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
