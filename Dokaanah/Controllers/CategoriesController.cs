using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dokaanah.Models;
using Dokaanah.Repositories.RepoInterfaces;
using Dokaanah.Repositories.RepoClasses;

namespace Dokaanah.Controllers
{
    public class CategoriesController : Controller
    {
        #region  Constractor Region

        private readonly ICategoriesRepo _categoryRepo;

        public CategoriesController(ICategoriesRepo categoriesRepo)
        {
            _categoryRepo = categoriesRepo;
        }

        #endregion
     
        #region  Get All Region

        public IActionResult AllCategoryRegion()
        {
            var allCategory = _categoryRepo.GetAll();
            ViewBag.allCategory2 = allCategory;
            return View();
        }

        #endregion


        #region  Get All Region

        public IActionResult GetAll()
        {
            // Get all products from all categories
            var allProducts = _categoryRepo.GetAllProductsForAllCategories();
            return View(allProducts);
        }

        #endregion

     
        #region Get Products For Category Region

        // GET Categories/Products/{categoryId}
        public IActionResult GetProductsForCategory(int categoryId)
        {
            var products = _categoryRepo.GetProductsForCategory(categoryId);
            return View(products);
        }

        #endregion


        #region Create GET Region

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        #endregion


        #region Create Post Region
       
        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Icon")] Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryRepo.Insert(category);
                return RedirectToAction(nameof(AllCategoryRegion), "Categories");
            }
            return RedirectToAction(nameof(AllCategoryRegion), "AllCategoryRegion", category);
        }

        #endregion


        #region Edit

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var category = _categoryRepo.GetById(id);
            if (category == null)
            {
                return NotFound();
            }

            ViewBag.AllcategoryNames = _categoryRepo.GetAll();

            return View(category);
        }



        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Category category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _categoryRepo.Update(category);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (category.Id == 0)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(CategoriesController.AllCategoryRegion), "Categories");
            }
            return View(category);
        }


        #endregion


        #region delete 

        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var category = _categoryRepo.GetById(id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = _categoryRepo.GetById(id);
            if (category != null)
            {
                _categoryRepo.Delete(category);
            }

            return RedirectToAction(nameof(AllCategoryRegion), "Categories");
        }



        #endregion



    }
}
