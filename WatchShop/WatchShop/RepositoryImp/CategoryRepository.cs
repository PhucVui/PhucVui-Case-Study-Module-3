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
            throw new NotImplementedException();
        }

        public int CreateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Product> Products(int id)
        {
            throw new NotImplementedException();
        }
    }
}
