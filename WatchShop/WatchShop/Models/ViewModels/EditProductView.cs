using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WatchShop.Models.ViewModels
{
    public class EditProductView : CreateProductView
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string ImgPath { get; set; }
    }
}
