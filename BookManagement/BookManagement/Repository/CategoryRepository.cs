using BookManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BookDbContext context;

        public CategoryRepository(BookDbContext context)
        {
            this.context = context;
        }

        public List<Category> CategoryList()
        {
            return context.Categories.ToList();
        }

        public WatchBookView GetWatchBookView(int id)
        {
            WatchBookView watchBookView = new WatchBookView()
            {
                CategoryId = id,
                Books = context.Books.Where(b => b.CategoryId == id).ToList()
            };
            return watchBookView;
        }
    }
}
