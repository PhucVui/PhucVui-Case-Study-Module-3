using BookManagement.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookManagement.Models;

namespace BookManagement.Extension
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryName="Toán nâng cao" , Id=1},
                new Category { CategoryName = "Văn học", Id = 2 },
                new Category { CategoryName = "Lịch sử", Id = 3 },
                new Category { CategoryName = "Lý nâng cao", Id = 4 },
                new Category { CategoryName = "Hóa nâng cao", Id = 5 }
                );
        }
    }
}
