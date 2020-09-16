using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchShop.Models;
using WatchShop.Models.ViewModels;

namespace WatchShop.Repositories
{
    public interface IProductRepository
    {
        int CreateProduct(CreateProductView product);
        Product GetProduct(int id);
        List<Product> GetProductList();
        int EditProduct(Product product);
        int Delete(int id);
        string UploadedFile(IFormFile iformfile_path);
    }
}
