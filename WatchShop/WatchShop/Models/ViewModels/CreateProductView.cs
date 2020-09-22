using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WatchShop.Models.ViewModels
{
    public class CreateProductView
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public DateTime CreateAt { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public IFormFile Avata { get; set; }
    }
}
