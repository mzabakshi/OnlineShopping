using OnlineShopping.DAL.Models;
using System.Data.Entity;

namespace OnlineShopping.DAL
{
    public class ShoppingContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ShoppingContext() : base("ShoppingDbConnectionString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
        }
    }
}
