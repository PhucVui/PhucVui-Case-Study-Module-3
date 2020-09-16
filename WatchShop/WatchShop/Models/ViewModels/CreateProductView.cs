using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchShop.Models.ViewModels
{
    public class CreateProductView
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime CreateAt { get; set; }        
        public int CategoryId { get; set; }
        public IFormFile Avata { get; set; }
    }
}
