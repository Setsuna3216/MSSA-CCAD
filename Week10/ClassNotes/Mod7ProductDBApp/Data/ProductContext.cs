using Microsoft.EntityFrameworkCore;
using Mod7ProductDBApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7ProductDBApp.Data
{
    public class ProductContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductContext(DbContextOptions<ProductContext>options):base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(GetProducts());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        private Product[] GetProducts()
        {
            return new Product[]
            {

                new Product
                {
                    ProductId=1,
                    Name="HP Laptop",
                    Price=999.99m,
                    Description="A high performance developer machine.",
                    Quantity=2
                }
            };
        }
    }
}
