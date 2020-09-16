using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchShop.Models;

namespace WatchShop.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly WatchShopDbContext _context;

        public ProductRepository(WatchShopDbContext context)
        {
            this._context = context;
        }

        public int CreateProduct(Product product)
        {
            _context.Add(product);
            return _context.SaveChanges();
        }

        public Product GetProduct(int id)
        {
           return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetProductList()
        {
            return _context.Products.ToList();
        }

        public int Delete(int id)
        {
            _context.Remove(GetProduct(id));
            return _context.SaveChanges();
        }

        public int EditProduct(Product product)
        {

            _context.Products.Update(product);
            return _context.SaveChanges();
        }
    }
}
