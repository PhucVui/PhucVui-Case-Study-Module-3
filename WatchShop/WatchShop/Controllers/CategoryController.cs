using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WatchShop.Models;
using WatchShop.Repositories;

namespace WatchShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            return View(categoryRepository.Categories());
        }
        public IActionResult ProductListView(int id)
        {
            return View(categoryRepository.Products(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                if (categoryRepository.CreateCategory(category) > 0)
                    return RedirectToAction("Index", "Product");
               
                    ModelState.AddModelError("", "Erors");
            }
            return View(category);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(categoryRepository.GetCategory(id));
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                if (categoryRepository.EditCategory(category) > 0)
                    return RedirectToAction("Index", "Product");
                
                    ModelState.AddModelError("", "Erors");
            }
            return View(category);
        }
        public IActionResult Delete(int id)
        {
            if (categoryRepository.Delete(id) > 0)
                return RedirectToAction("Index", "Category");   
            
            ModelState.AddModelError("", "Erors");
            return View();
        }
    }
}
