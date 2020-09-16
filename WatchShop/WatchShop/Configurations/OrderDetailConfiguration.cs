using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchShop.Models;

namespace WatchShop.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder
               .HasKey(po => new { po.ProductId, po.OrderId });

            builder
                .HasOne(po => po.Product)
                .WithMany(b => b.OrderDetails)
                .HasForeignKey(po => po.ProductId);

            builder
                .HasOne(po => po.Order)
                .WithMany(c => c.OrderDetails)
                .HasForeignKey(po => po.OrderId);
        }
    }
}
