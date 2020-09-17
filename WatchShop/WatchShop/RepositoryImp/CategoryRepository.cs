using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchShop.Models;

namespace WatchShop.Repositories
{   
    public class CategoryRepository : ICategoryRepository
    {
        private readonly WatchShopDbContext _context;

        public CategoryRepository(WatchShopDbContext context)
        {
            this._context = context;
        }

        public List<Category> Categories()
        {
            return _context.Categories.ToList();
        }

        public int CreateCategory(Category category)
        {
            _context.Add(category);
            return _context.SaveChanges();
        }

        public int Delete(int id)
        {
            _context.Remove(GetCategory(id));
            return _context.SaveChanges();
        }

        public int EditCategory(Category category)
        {
            _context.Categories.Update(category);
            return _context.SaveChanges();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }

        public List<Product> Products(int id)
        {
            return _context.Products.ToList().FindAll(p => p.CategoryId == id);
        }
    }
}
