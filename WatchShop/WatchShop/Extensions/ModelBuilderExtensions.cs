using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchShop.Models;

namespace WatchShop.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Name = "Rolex", Description = "danh mục rolex thụy sĩ", Id = 1,CreateAt=DateTime.Today },
                new Category { Name = "Casio", Description = "Casio việt Nam", Id = 2, CreateAt = DateTime.Today },
                new Category { Name = "Bulova", Description = "Bulova Ý", Id = 3, CreateAt = DateTime.Today }
                );
            modelBuilder.Entity<Product>().HasData(
               new Product { Name = "Rolex 01", Price=30000000, Id = 1,CategoryId=1, CreateAt = DateTime.Today },
               new Product { Name = "Casio 0012", Price = 4000000, Id = 2, CategoryId = 2, CreateAt = DateTime.Today },
               new Product { Name = "Bulova Nữ", Price = 10000000, Id = 3, CategoryId = 3, CreateAt = DateTime.Today }
               );
        }
    }
}
