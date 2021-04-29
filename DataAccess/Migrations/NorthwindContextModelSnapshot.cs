﻿// <auto-generated />
using DataAccess.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(ProjectContext))]
    partial class NorthwindContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Elektronik"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Süt Ürünleri"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "İçecekler"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Unlu Mamüller"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuantityPerUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<short>("UnitsInStock")
                        .HasColumnType("smallint");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            ProductName = "Dell Bilgisayar",
                            QuantityPerUnit = "PC",
                            UnitPrice = 4500m,
                            UnitsInStock = (short)100
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            ProductName = "Casper Bilgisayar",
                            QuantityPerUnit = "PC",
                            UnitPrice = 2000m,
                            UnitsInStock = (short)100
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            ProductName = "Huaweı Akıllı Telefon",
                            QuantityPerUnit = "Telefon",
                            UnitPrice = 2200m,
                            UnitsInStock = (short)100
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            ProductName = "Sütaş Yoğurt",
                            QuantityPerUnit = "1000ml yoğurt",
                            UnitPrice = 10m,
                            UnitsInStock = (short)10000
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 3,
                            ProductName = "Fanta",
                            QuantityPerUnit = "2,5 lt kola",
                            UnitPrice = 5m,
                            UnitsInStock = (short)10000
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 3,
                            ProductName = "Coca Cola",
                            QuantityPerUnit = "2,5 lt kola",
                            UnitPrice = 5m,
                            UnitsInStock = (short)10000
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 4,
                            ProductName = "Poğaça",
                            QuantityPerUnit = "1 adet poğaça",
                            UnitPrice = 2m,
                            UnitsInStock = (short)10000
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 4,
                            ProductName = "Simit",
                            QuantityPerUnit = "1 adet simit",
                            UnitPrice = 2m,
                            UnitsInStock = (short)10000
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 4,
                            ProductName = "Kıymalı Pide",
                            QuantityPerUnit = "1 adet kıymalı pide",
                            UnitPrice = 12m,
                            UnitsInStock = (short)10000
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 4,
                            ProductName = "Kurabiye",
                            QuantityPerUnit = "1 kg kurabiye",
                            UnitPrice = 18m,
                            UnitsInStock = (short)10000
                        });
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Password = "123",
                            Username = "oguzhankaymak"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
