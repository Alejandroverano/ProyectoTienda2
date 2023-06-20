﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoTienda.Data;

#nullable disable

namespace ProyectoTienda2.Migrations
{
    [DbContext(typeof(ProyectoTiendaContext))]
    [Migration("20230608062309_tienda1")]
    partial class tienda1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProyectoTienda.Models.Realme", b =>
                {
                    b.Property<int>("Idrealme")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idrealme"));

                    b.Property<string>("Namerealme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("unitpricerealme")
                        .HasColumnType("float");

                    b.HasKey("Idrealme");

                    b.ToTable("realmes");

                    b.HasData(
                        new
                        {
                            Idrealme = 1,
                            Namerealme = "Realme GT 2 Pro",
                            unitpricerealme = 699.99000000000001
                        },
                        new
                        {
                            Idrealme = 2,
                            Namerealme = "Realme GT 2",
                            unitpricerealme = 499.99000000000001
                        },
                        new
                        {
                            Idrealme = 3,
                            Namerealme = "Realme GT",
                            unitpricerealme = 399.99000000000001
                        },
                        new
                        {
                            Idrealme = 4,
                            Namerealme = "Realme 9 Pro plus",
                            unitpricerealme = 350.99000000000001
                        },
                        new
                        {
                            Idrealme = 5,
                            Namerealme = "Realme GT Master Edition",
                            unitpricerealme = 340.99000000000001
                        },
                        new
                        {
                            Idrealme = 6,
                            Namerealme = "Realme 9 Pro",
                            unitpricerealme = 329.99000000000001
                        },
                        new
                        {
                            Idrealme = 7,
                            Namerealme = "Realme C35",
                            unitpricerealme = 199.99000000000001
                        },
                        new
                        {
                            Idrealme = 8,
                            Namerealme = "Realme C25Y",
                            unitpricerealme = 179.99000000000001
                        },
                        new
                        {
                            Idrealme = 9,
                            Namerealme = "Realme C31",
                            unitpricerealme = 159.99000000000001
                        },
                        new
                        {
                            Idrealme = 10,
                            Namerealme = "Realme C21Y",
                            unitpricerealme = 139.99000000000001
                        });
                });

            modelBuilder.Entity("ProyectoTienda.Models.Xiaomi", b =>
                {
                    b.Property<int>("Idxiaomi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idxiaomi"));

                    b.Property<string>("Namexiaomi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("unitpricexiaomi")
                        .HasColumnType("float");

                    b.HasKey("Idxiaomi");

                    b.ToTable("xiaomis");

                    b.HasData(
                        new
                        {
                            Idxiaomi = 1,
                            Namexiaomi = "Xiaomi 13",
                            unitpricexiaomi = 650.0
                        },
                        new
                        {
                            Idxiaomi = 2,
                            Namexiaomi = "Xiaomi 13 pro",
                            unitpricexiaomi = 750.0
                        },
                        new
                        {
                            Idxiaomi = 3,
                            Namexiaomi = "Xiaomi 12S Ultra",
                            unitpricexiaomi = 1200.0
                        },
                        new
                        {
                            Idxiaomi = 4,
                            Namexiaomi = "Redmi Note 12",
                            unitpricexiaomi = 190.99000000000001
                        },
                        new
                        {
                            Idxiaomi = 5,
                            Namexiaomi = "Redmi note 12 Pro",
                            unitpricexiaomi = 270.0
                        },
                        new
                        {
                            Idxiaomi = 6,
                            Namexiaomi = "Redmi note 12 Pro Plus",
                            unitpricexiaomi = 335.0
                        },
                        new
                        {
                            Idxiaomi = 7,
                            Namexiaomi = "Redmi 9c",
                            unitpricexiaomi = 80.0
                        },
                        new
                        {
                            Idxiaomi = 8,
                            Namexiaomi = "Redmi 10C",
                            unitpricexiaomi = 92.0
                        },
                        new
                        {
                            Idxiaomi = 9,
                            Namexiaomi = "Redmi 11c",
                            unitpricexiaomi = 90.0
                        },
                        new
                        {
                            Idxiaomi = 10,
                            Namexiaomi = "Redmi 12C",
                            unitpricexiaomi = 95.0
                        });
                });

            modelBuilder.Entity("ProyectoTienda.Models.iphone", b =>
                {
                    b.Property<int>("Idiphone")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idiphone"));

                    b.Property<string>("Nameiphone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("unitpriceiphone")
                        .HasColumnType("float");

                    b.HasKey("Idiphone");

                    b.ToTable("iphones");

                    b.HasData(
                        new
                        {
                            Idiphone = 1,
                            Nameiphone = "iphone 12",
                            unitpriceiphone = 999.99000000000001
                        },
                        new
                        {
                            Idiphone = 2,
                            Nameiphone = "iphone 12 Pro",
                            unitpriceiphone = 1099.99
                        },
                        new
                        {
                            Idiphone = 3,
                            Nameiphone = "iphone 12 Pro Max",
                            unitpriceiphone = 1199.99
                        },
                        new
                        {
                            Idiphone = 4,
                            Nameiphone = "iphone 13",
                            unitpriceiphone = 999.99000000000001
                        },
                        new
                        {
                            Idiphone = 5,
                            Nameiphone = "iphone 13 Pro ",
                            unitpriceiphone = 1099.99
                        },
                        new
                        {
                            Idiphone = 6,
                            Nameiphone = "iphone 13 Pro Max",
                            unitpriceiphone = 1199.99
                        },
                        new
                        {
                            Idiphone = 7,
                            Nameiphone = "iphone 14",
                            unitpriceiphone = 999.99000000000001
                        },
                        new
                        {
                            Idiphone = 8,
                            Nameiphone = "iphone 14 Pro",
                            unitpriceiphone = 1099.99
                        },
                        new
                        {
                            Idiphone = 9,
                            Nameiphone = "iphone 14 Plus",
                            unitpriceiphone = 1159.99
                        },
                        new
                        {
                            Idiphone = 10,
                            Nameiphone = "iphone 14 Pro Max",
                            unitpriceiphone = 1469.99
                        });
                });

            modelBuilder.Entity("ProyectoTienda.Models.products", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("productId"));

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("unitprice")
                        .HasColumnType("float");

                    b.HasKey("productId");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            productId = 1,
                            productName = "Samsung Galaxy S23",
                            unitprice = 959.0
                        },
                        new
                        {
                            productId = 2,
                            productName = "Samsung Galaxy S23+",
                            unitprice = 1209.0
                        },
                        new
                        {
                            productId = 3,
                            productName = "Samsung Galaxy S23 Ultra",
                            unitprice = 1409.0
                        },
                        new
                        {
                            productId = 4,
                            productName = "Samsung Galaxy A54 5G ",
                            unitprice = 499.0
                        },
                        new
                        {
                            productId = 5,
                            productName = "Samsung Galaxy A34 5G",
                            unitprice = 469.0
                        },
                        new
                        {
                            productId = 6,
                            productName = "Samsung Galaxy A53 5G",
                            unitprice = 335.0
                        },
                        new
                        {
                            productId = 7,
                            productName = "Samsung Galaxy A13",
                            unitprice = 179.0
                        },
                        new
                        {
                            productId = 8,
                            productName = "Samsung Galaxy A14",
                            unitprice = 185.0
                        },
                        new
                        {
                            productId = 9,
                            productName = "Samsung Galaxy A04 Core",
                            unitprice = 170.0
                        },
                        new
                        {
                            productId = 10,
                            productName = "Samsung Galaxy A10s",
                            unitprice = 100.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
