using BookManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Repository
{
    public interface ICategoryRepository
    {
        WatchBookView GetWatchBookView(int id);
        List<Category> CategoryList();
    }
}
