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

        public int CreateOrder(Order order)
        {
            _context.Add(order);
            return _context.SaveChanges();
        }

        public int DeleteOrder(int id)
        {
            _context.Remove(GetOrder(id));
            return _context.SaveChanges();
        }

        public Order GetOrder(int id)
        {
            return _context.Orders.FirstOrDefault(o => o.OrderId == id);
        }

        public List<Order> GetOrdersList()
        {
            return _context.Orders.ToList();
        }

        public int UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            return _context.SaveChanges();
        }
    }
}
