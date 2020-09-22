using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WatchShop.Models.ViewModels
{
    public class RegisterUserView
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Nhập một định dạng của email")]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public IFormFile IFormFilePath { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Not Match Password")]
        public string ConfirmPassword { get; set; }

    }
}
