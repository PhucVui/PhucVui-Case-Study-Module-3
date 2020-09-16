using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchShop.Models;

namespace WatchShop.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly WatchShopDbContext _context;

        public OrderRepository(WatchShopDbContext context)
        {
            this._context = context;
        }
    }
}
