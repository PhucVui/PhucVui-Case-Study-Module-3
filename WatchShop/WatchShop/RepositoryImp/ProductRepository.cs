using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WatchShop.Models;
using WatchShop.Models.ViewModels;

namespace WatchShop.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly WatchShopDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductRepository(WatchShopDbContext context, IWebHostEnvironment hostEnvironment)
        {
            this._context = context;
            this._hostEnvironment = hostEnvironment;
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

        public string UploadedFile(IFormFile iformfile_path)
        {
            string uniqueFileName = null;

            if (iformfile_path != null)
            {
                string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + iformfile_path.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    iformfile_path.CopyTo(fileStream);
                }
            }
            return uniqueFileName;

        }

        public int CreateProduct(CreateProductView productView)
        {
            Product product = new Product()
            {
                Name = productView.Name,
                Price = productView.Price,
                CreateAt = productView.CreateAt,
                CategoryId = productView.CategoryId,
                AvataPath = UploadedFile(productView.Avata)
            };
            _context.Add(product);
            return _context.SaveChanges();
        }
    }
}
