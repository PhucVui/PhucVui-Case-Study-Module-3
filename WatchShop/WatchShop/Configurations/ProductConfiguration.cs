using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchShop.Models;

namespace WatchShop.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(el => el.Name).IsRequired().HasMaxLength(100);
            builder.Property(el => el.AvataPath).IsRequired().HasDefaultValue("default.jpg");         
        }
    }
}
