using BookManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDbContext context;

        public BookRepository(BookDbContext context)
        {
            this.context = context;
        }
        public int CreateBook(Book book)
        {
            context.Add(book);
            return context.SaveChanges();
        }

        public int Delete(int id)
        {
            context.Remove(GetBook(id));
            return context.SaveChanges();
        }

        public int EditBook(Book book)
        {
            if (context.Books.Contains(book))
                context.Update(book);
            return context.SaveChanges();
        }

        public Book GetBook(int id)
        {
            return context.Books.FirstOrDefault(b => b.Id == id);
        }

        public List<Book> GetBooktList()
        {
            return context.Books.ToList();
        }
    }
}
