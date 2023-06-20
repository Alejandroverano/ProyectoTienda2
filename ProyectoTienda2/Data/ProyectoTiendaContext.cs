using Microsoft.EntityFrameworkCore;
using ProyectoTienda.Models;

namespace ProyectoTienda.Data
{
    public class ProyectoTiendaContext : DbContext
    {
        public ProyectoTiendaContext(DbContextOptions<ProyectoTiendaContext> options) : base(options)
        {

        }

        public DbSet<products> products { get; set; }
        //public DbSet<Xiaomi> xiaomis { get; set; }
        //public DbSet<iphone> iphones { get; set; }
        //public DbSet<Realme> realmes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<products>().HasData(
                    new products()
                    {
                        productId = 1,
                        productName = "Samsung Galaxy S23",
                        unitprice = 959.00

                    },
                    new products()
                    {
                        productId = 2,
                        productName = "Samsung Galaxy S23+",
                        unitprice = 1209.00
                    },
                    new products()
                    {
                        productId = 3,
                        productName = "Samsung Galaxy S23 Ultra",
                        unitprice = 1409.00
                    },
                     new products()
                     {
                         productId = 4,
                         productName = "Samsung Galaxy A54 5G ",
                         unitprice = 499.00
                     },
                      new products()
                      {
                          productId = 5,
                          productName = "Samsung Galaxy A34 5G",
                          unitprice = 469.00
                      },
                       new products()
                       {
                           productId = 6,
                           productName = "Samsung Galaxy A53 5G",
                           unitprice = 335.00
                       },
                        new products()
                        {
                            productId = 7,
                            productName = "Samsung Galaxy A13",
                            unitprice = 179.00
                        },
                         new products()
                         {
                             productId = 8,
                             productName = "Samsung Galaxy A14",
                             unitprice = 185.00
                         },
                          new products()
                          {
                              productId = 9,
                              productName = "Samsung Galaxy A04 Core",
                              unitprice = 170.00
                          },
                           new products()
                           {
                               productId = 10,
                               productName = "Samsung Galaxy A10s",
                               unitprice = 100.00
                           }, new products()
                           {
                               productId = 12,
                               productName = "Xiaomi 13",
                               unitprice = 650.00
                           }, new products()
                           {
                               productId = 13,
                               productName = "Xiaomi 13 pro",
                               unitprice = 750.00
                           }, new products()
                           {
                               productId = 14,
                               productName = "Xiaomi 12S Ultra",
                               unitprice = 1200.00
                           }, new products()
                           {
                               productId = 15,
                               productName = "Redmi note 12",
                               unitprice = 190.00
                           }, new products()
                           {
                               productId = 16,
                               productName = "Redmi note 12 Pro",
                               unitprice = 270.00
                           }, new products()
                           {
                               productId = 17,
                               productName = "Redmi note 12 Pro plus",
                               unitprice = 335.00
                           }, new products()
                           {
                               productId = 18,
                               productName = "Redmi 9c",
                               unitprice = 80.00
                           }, new products()
                           {
                               productId = 19,
                               productName = "Redmi 10C",
                               unitprice = 92.00
                           }, new products()
                           {
                               productId = 20,
                               productName = "Redmi 11C",
                               unitprice = 90.00
                           }, new products()
                           {
                               productId = 21,
                               productName = "Redmi 12C",
                               unitprice = 95.00
                           }, new products()
                           {
                               productId = 22,
                               productName = "iphone 12",
                               unitprice = 990.00
                           }, new products()
                           {
                               productId = 23,
                               productName = "iphone 12 Pro",
                               unitprice = 1100.00
                           }, new products()
                           {
                               productId = 24,
                               productName = "iphone 12 Pro Max",
                               unitprice = 1200.00
                           }, new products()
                           {
                               productId = 25,
                               productName = "iphone 13",
                               unitprice = 900.00
                           }, new products()
                           {
                               productId = 26,
                               productName = "iphone 13 Pro ",
                               unitprice = 1100.00
                           }, new products()
                           {
                               productId = 27,
                               productName = "iphone 13 Pro Max",
                               unitprice = 1200.00
                           }, new products()
                           {
                               productId = 28,
                               productName = "iphone 14",
                               unitprice = 900.00
                           }, new products()
                           {
                               productId = 29,
                               productName = "iphone 14 Pro",
                               unitprice = 1100.00
                           }, new products()
                           {
                               productId = 30,
                               productName = "iphone 14 Plus",
                               unitprice = 1150.00
                           }, new products()
                           {
                               productId = 31,
                               productName = "iphone 14 Pro Max",
                               unitprice = 1200.00
                           }, new products()
                           {
                               productId = 32,
                               productName = "Realme Gt 2 Pro",
                               unitprice = 690.00
                           }, new products()
                           {
                               productId = 33,
                               productName = "Realme GT 2",
                               unitprice = 500.00
                           }, new products()
                           {
                               productId = 34,
                               productName = "Samsung Galaxy A10s",
                               unitprice = 100.00
                           }, new products()
                           {
                               productId = 35,
                               productName = "Realme GT ",
                               unitprice = 450.00
                           }, new products()
                           {
                               productId = 36,
                               productName = "Realme 9 Pro plus",
                               unitprice = 350.00
                           }, new products()
                           {
                               productId = 37,
                               productName = "Realme GT Master Edition",
                               unitprice = 340.00
                           }, new products()
                           {
                               productId = 38,
                               productName = "Realme 9 Pro",
                               unitprice = 330.00
                           }, new products()
                           {
                               productId = 39,
                               productName = "Realme C35",
                               unitprice = 199.00
                           }, new products()
                           {
                               productId = 40,
                               productName = "Realme C25Y",
                               unitprice = 179.00
                           }, new products()
                           {
                               productId = 41,
                               productName = "Realme C31",
                               unitprice = 159.00
                           }, new products()
                           {
                               productId = 42,
                               productName = "Realme C21Y",
                               unitprice = 130.00
                           }



                );


        }

    }
}
   

