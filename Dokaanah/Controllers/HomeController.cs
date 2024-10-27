using Dokaanah.Models;
using Dokaanah.Repositories.RepoClasses;
using Dokaanah.Repositories.RepoInterfaces;
using Dokaanah.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dokaanah.Controllers
{
    public class HomeController : Controller
    {
        #region  Constractor Region
       
        private readonly ILogger<HomeController> _logger;
        private readonly IProduct_CategoryRepo product_CategoryRepo;
        private readonly ICategoriesRepo categoriesRepo;
        private readonly IProductsRepo productsRepo;

        public HomeController(IProduct_CategoryRepo _product_CategoryRepo, ICategoriesRepo categoriesRepo, IProductsRepo productsRepo)
        {
            product_CategoryRepo = _product_CategoryRepo;
            this.categoriesRepo = categoriesRepo;
            this.productsRepo = productsRepo;
        }

        #endregion

        #region Index Region
        
        public IActionResult Index()
        {
            var randomProducts = productsRepo.GetRandomProducts(5);
            return View(randomProducts);
        }
        #endregion
        
        #region Shop Region

        public IActionResult Shop(string catName, string productName)
        {
            if (string.IsNullOrEmpty(productName))
            {

                var allproductsWithCats = product_CategoryRepo.GetAll();
                var allcategories = categoriesRepo.GetAll().ToList();
                ViewBag.cats = allcategories;
                catName = string.IsNullOrEmpty(catName) ? "all" : catName;
                ViewData["catName"] = catName;
                ViewBag.allproducts = productsRepo.GetAll().ToList();
                return View(allproductsWithCats);
            }
            else
            {
                var allproductsWithCats = product_CategoryRepo.GetAll();
                var allcategories = categoriesRepo.GetAll().ToList();
                ViewBag.cats = allcategories;
                catName = string.IsNullOrEmpty(catName) ? "all" : catName;
                ViewData["catName"] = catName;

                ViewBag.allproducts = productsRepo.SearchByName(productName).ToList();
                return View(allproductsWithCats);
            }


        }

        #endregion

        #region About Us Region
        
        public IActionResult AboutUs()
        {
            return View();
        }
        #endregion

        #region Contant Us Region

        public IActionResult ContantUs()
        {
            return View();
        }

        #endregion

        #region User Account Region
        
        public IActionResult UserAccount()
        {
            return View();
        }

        #endregion


        #region Error Region
       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #endregion

        #region Error Handle For User Region

        public IActionResult ErrorHandleForUser()
        {
            return View();
        }

        #endregion

        #region FAQ Region
      
        public IActionResult FAQ()
        {
            return View();
        }

        #endregion

    }
}
