﻿using Dokaanah.Repositories.RepoInterfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Dokaanah.Controllers
{
    [Authorize(Roles="Admin")]
    //[Authorize(Roles = "admin")]
    //[Authorize(Roles = "ADMIN")]
    //AdminDashboard

    public class AdminDashboardController : Controller
    {
        #region controllers 
        
        
        private readonly ICustomersRepo customersRepo;
        private readonly ICategoriesRepo categoriesRepo;
        private readonly IProductsRepo productsRepo;

        public AdminDashboardController(ICustomersRepo customersRepo,ICategoriesRepo categoriesRepo, IProductsRepo productsRepo)
        {
            this.customersRepo=customersRepo;
            this.categoriesRepo=categoriesRepo;
            this.productsRepo=productsRepo;
        }

        #endregion
       
        //AdminDashboard
        public IActionResult Index()
        {
            #region view bag data 
           
            
            ViewBag.customerCount = customersRepo.GetAll().Count();
            ViewBag.ProductCount = productsRepo.GetAll().Count();
            ViewBag.AllpriceCount = productsRepo.GetAll().Sum(e => e.Price);
            ViewBag.Allproducts = productsRepo.GetAll();
            ViewBag.AllcategoryNames = categoriesRepo.GetAll(); 
            
            #endregion


            return View();
        }
    
    }
}







      





