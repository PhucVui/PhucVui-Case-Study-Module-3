using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagement.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.Controllers
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
            return View(categoryRepository.CategoryList());
        }
        public IActionResult BookView(int id)
        {
            return View(categoryRepository.GetWatchBookView(id));
        }
    }
}
