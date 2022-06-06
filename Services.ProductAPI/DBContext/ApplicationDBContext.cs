using Microsoft.EntityFrameworkCore;
using Services.ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.ProductAPI.DBContext
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Samosa",
                Price = 15,
                Description = "Crispy Samosa",
                ImageURL = "https://msuddemostorage.blob.core.windows.net/mango/Samosa.jpg",
                CategoryName = "Appetizer"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Panner Tikka",
                Price = 20,
                Description = "Delicious Panner Tikka",
                ImageURL = "https://msuddemostorage.blob.core.windows.net/mango/PannerTikka.jpg",
                CategoryName = "Appetizer"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Sweet Pie",
                Price = 10,
                Description = "Sweet Pie",
                ImageURL = "https://msuddemostorage.blob.core.windows.net/mango/SweetPie.jpg",
                CategoryName = "Dessert"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Pav Bhaji",
                Price = 15,
                Description = "Pav Bhaji",
                ImageURL = "https://msuddemostorage.blob.core.windows.net/mango/PavBhaji.jpg",
                CategoryName = "Starter"
            });
        }
    }
}
