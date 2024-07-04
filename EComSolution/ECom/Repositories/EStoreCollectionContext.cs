using Microsoft.EntityFrameworkCore;
using ProductsOnline.Models;

namespace ProductsOnline.Repositories
{
    public class EStoreCollectionContext:DbContext
    {
        public DbSet<Product> products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionstring = @"Server=localhost;Port=3306;User=root;Password=2911;Database=ecom;";
            optionsBuilder.UseMySQL(connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Title).IsRequired();
            });
            modelBuilder.Entity<Product>().ToTable("products");
        }
    }
}
