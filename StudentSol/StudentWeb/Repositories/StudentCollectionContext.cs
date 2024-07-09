using Microsoft.EntityFrameworkCore;
using StudentWeb.Models;
namespace StudentWeb.Repositories
{
    public class StudentCollectionContext : DbContext
    {
        public DbSet<Student> students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionstring = @"Server=localhost;port=3306;User=root;Password=2911;Database=studentapi;";
            optionsBuilder.UseMySQL(connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.status).IsRequired();
            });
            modelBuilder.Entity<Student>().ToTable("Students");
        }
    }
}
