using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Models
{
    public class WatchBookView 
    {
        public List<Book> Books { get; set; }
        public int CategoryId { get; set; }
    }
}
