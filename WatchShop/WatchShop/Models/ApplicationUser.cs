using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchShop.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Avatar { get; set; }
        public ICollection<Order> Orders { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
    
}
