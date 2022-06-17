using Microsoft.EntityFrameworkCore;
using MVC_13062022.Models;

namespace MVC_13062022
{
    public class MyDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* Here we are adding seed data.
            */
            // Seeding Product data.
            modelBuilder.Entity<Product>().HasData(new Product { Id = 2, Name = "Pants", Price = 150.0 });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 3, Name = "Yellow socks", Price = 290.90 });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 4, Name = "Green hat", Price = 500.0 });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 5, Name = "T-shirt", Price = 400.0 });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 6, Name = "Tie", Price = 560.0 });
        }
    }
}
