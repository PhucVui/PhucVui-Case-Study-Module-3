using BookManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Repository
{
    public interface IBookRepository
    {
        int CreateBook(Book book);
        Book GetBook(int id);
        List<Book> GetBooktList();
        int EditBook(Book book);
        int Delete(int id);
    }
}
