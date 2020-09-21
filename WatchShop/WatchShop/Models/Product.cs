using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WatchShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime CreateAt { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        [DefaultValue("default.jpg")]
        public string AvataPath { get; set; }
    }
}
