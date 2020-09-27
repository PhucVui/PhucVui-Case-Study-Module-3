using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagement.Models;
using BookManagement.Models.ViewModels;
using BookManagement.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.Controllers
{
    public class BookController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IBookRepository bookRepository;

        public BookController(ICategoryRepository categoryRepository, IBookRepository bookRepository)
        {
            this.categoryRepository = categoryRepository;
            this.bookRepository = bookRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            return View(new CreateBookView { CategoryId = id });
        }

        [HttpPost]
        public IActionResult Create(CreateBookView createBookView)
        {
            Book book = new Book();
            if (ModelState.IsValid)
            {
                book = new Book()
                {
                   Name = createBookView.Name,
                   Author = createBookView.Author,
                   Description = createBookView.Description,
                   PublishingYear = createBookView.PublishingYear,
                   Booksnumber= createBookView.Booksnumber,
                   CategoryId = createBookView.CategoryId
                };


                if (bookRepository.CreateBook(book) > 0)
                    return View("Views/Category/BookView.cshtml", categoryRepository.GetWatchBookView   (book.CategoryId));
                else
                    ModelState.AddModelError("", "Some thing wrong");
            }
            return View(book);

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(bookRepository.GetBook(id));
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                if (bookRepository.EditBook(book) > 0)
                    return RedirectToAction("BookView", "Category");
                else
                    ModelState.AddModelError("", "Some thing wrong");
            }
            return View(book);
        }
        public IActionResult Delete(int id)
        {
            if (bookRepository.Delete(id) > 0)
                return RedirectToAction("BookView", "Category");
            else
                ModelState.AddModelError("", "Some thing wrong");
            return View();
        }
    }
}
