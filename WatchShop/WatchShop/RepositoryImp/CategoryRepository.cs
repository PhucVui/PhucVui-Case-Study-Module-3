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
    }
}
