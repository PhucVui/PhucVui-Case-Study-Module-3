using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WatchShop.Models.ViewModels
{
    public class EditUserView 
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Nhập một định dạng của email")]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string AvatarPath { get; set; }
        public IFormFile IformfilePath { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }       

    }
}
