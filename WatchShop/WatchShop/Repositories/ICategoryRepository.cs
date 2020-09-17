using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchShop.Models;

namespace WatchShop.Repositories
{
    public interface ICategoryRepository
    {
        int CreateCategory(Category category);
        List<Category> Categories();
        List<Product> Products(int id);
        Category GetCategory(int id);
        int EditCategory(Category category);
        int Delete(int id);

    }
}
