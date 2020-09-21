using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchShop.Models;

namespace WatchShop.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(el => el.Name).HasMaxLength(200).IsRequired();
            builder.Property(el => el.Description).HasMaxLength(250);
            builder.Property(el => el.Logo).HasMaxLength(100).HasDefaultValue("default.jpg");
            //ok chặp làm cái chức năng  up ảnh cho cate nữa
            // cai nay nho hom qua lam roi ma?? hay hom qua go~nham ben bai cua chu 
            //hôm qua là của product
            // ak ak loan nao~ :)) anh chạy chương trình hết chức năng e coi thử 
            // toang nang roi

        }
    }
}
