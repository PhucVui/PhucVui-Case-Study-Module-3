﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WatchShop.Models;

namespace WatchShop.Migrations
{
    [DbContext(typeof(WatchShopDbContext))]
    partial class WatchShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WatchShop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "danh mục rolex thụy sĩ",
                            Name = "Rolex"
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Casio việt Nam",
                            Name = "Casio"
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Bulova Ý",
                            Name = "Bulova"
                        });
                });

            modelBuilder.Entity("WatchShop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ShippedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WatchShop.Models.OrderDetail", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("ProductId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("WatchShop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvataPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreateAt = new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Rolex 01",
                            Price = 30000000.0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CreateAt = new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Casio 0012",
                            Price = 4000000.0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CreateAt = new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Bulova Nữ",
                            Price = 10000000.0
                        });
                });

            modelBuilder.Entity("WatchShop.Models.OrderDetail", b =>
                {
                    b.HasOne("WatchShop.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WatchShop.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WatchShop.Models.Product", b =>
                {
                    b.HasOne("WatchShop.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
