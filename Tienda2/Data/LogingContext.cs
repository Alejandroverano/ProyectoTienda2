using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tienda2.Models;

namespace Tienda2.Data
{
    public class LogingContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["constring"].ToString());
        }
        public DbSet<Loging> logings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Loging>().HasData(
                    new Loging()
                    {
                        usuario = "Alejandro",
                        contraseña = "Bruno123"
                    },
                    new Loging()
                    {
                        usuario = "Steven",
                        contraseña = "Pompi"
                    },
                    new Loging()
                    {
                        usuario = "Francisco",
                        contraseña = "HijodeAlejandro"
                    }
                );
        }
    }
}
