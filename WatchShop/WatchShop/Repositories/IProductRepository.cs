using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchShop.Models;

namespace WatchShop.Repositories
{
    public interface IProductRepository
    {
        int CreateProduct(Product product);
        Product GetProduct(int id);
        List<Product> GetProductList();
        int EditProduct(Product product);

        int Delete(int id);
    }
}
