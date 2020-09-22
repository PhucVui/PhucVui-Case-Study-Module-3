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
               
                new Category { Name = "Casio", Description = "Casio 201", Id = 2, CreateAt = DateTime.Today, Logo= "logoCasio.png" },
                new Category { Name = "Bulova", Description = "Bulova Ý", Id = 3, CreateAt = DateTime.Today, Logo = "Bulova.png" },
                new Category { Name = "GShock", Description = "GSock 2020", Id = 4, CreateAt = DateTime.Today, Logo = "GShock.png" },
                new Category { Name = "Orient", Description = "Orient 2019", Id = 5, CreateAt = DateTime.Today, Logo = "Orient.png" },
                new Category { Name = "Seiko", Description = "Seiko 456", Id = 6, CreateAt = DateTime.Today, Logo = "Seiko.png" },
                new Category { Name = "Sunrise", Description = "Sunrise 104", Id = 7, CreateAt = DateTime.Today, Logo = "sunrise.png" },
                new Category { Name = "Julius", Description = "Julius 2019", Id = 8, CreateAt = DateTime.Today, Logo = "Julius.png" },
                new Category { Name = "Pianus", Description = "Pianus 456", Id = 9, CreateAt = DateTime.Today, Logo = "Pianus.png" },
                new Category { Name = "DW", Description = "DW 104", Id = 10, CreateAt = DateTime.Today, Logo = "DW.png" }
                );
            modelBuilder.Entity<Product>().HasData(
              
               new Product { Name = "Casio 0012", Price = 4000000, Id = 2, CategoryId = 2, CreateAt = DateTime.Today, AvataPath="casio.jpg" },
               new Product { Name = "Bulova Nữ", Price = 10000000, Id = 3, CategoryId = 3, CreateAt = DateTime.Today, AvataPath = "Urgot.jpg" },
               new Product { Name = "GShock 01", Price = 30000000, Id = 4, CategoryId = 4, CreateAt = DateTime.Today, AvataPath = "A.jpg" },
               new Product { Name = "Orient 0012", Price = 4000000, Id = 5, CategoryId = 5, CreateAt = DateTime.Today, AvataPath = "images2.jpg" },
               new Product { Name = "Seiko Nữ", Price = 10000000, Id = 6, CategoryId = 6, CreateAt = DateTime.Today, AvataPath = "images1.jpg" },
               new Product { Name = "Sunrise Nữ", Price = 10000000, Id = 7, CategoryId = 7, CreateAt = DateTime.Today, AvataPath = "images5.jpg" },
                new Product { Name = "Julius 0012", Price = 4000000, Id = 8, CategoryId = 8, CreateAt = DateTime.Today, AvataPath = "images2.jpg" },
               new Product { Name = "Pianus Nữ", Price = 10000000, Id = 9, CategoryId = 9, CreateAt = DateTime.Today, AvataPath = "images1.jpg" },
               new Product { Name = "DW Nữ", Price = 10000000, Id = 10, CategoryId = 10, CreateAt = DateTime.Today, AvataPath = "images5.jpg" }
               );
        }
    }
}
