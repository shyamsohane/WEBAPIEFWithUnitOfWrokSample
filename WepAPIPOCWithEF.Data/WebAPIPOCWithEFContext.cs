using Microsoft.EntityFrameworkCore;
using System;
using WebAPIPOCWithEF.Domain;

namespace WepAPIPOCWithEF.Data
{
    public class WebAPIPOCWithEFContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }

        public WebAPIPOCWithEFContext(DbContextOptions<WebAPIPOCWithEFContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Data Source=WebAPIPOCWithEF.db");
            base.OnConfiguring(optionsBuilder); 
        }
    }
}
