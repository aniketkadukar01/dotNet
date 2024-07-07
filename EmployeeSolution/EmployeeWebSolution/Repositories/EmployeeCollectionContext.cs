using EmployeeWebSolution.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebSolution.Repositories
{
    public class EmployeeCollectionContext : DbContext
    {
        public DbSet<Employee> employees {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionstring = @"Server=localhost;
                            Port=3306;
                            User=root;
                            Password=2911;
                            Database=employee;";
            optionsBuilder.UseMySQL(connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.ContactNumber).IsRequired();
            });
            modelBuilder.Entity<Employee>().ToTable("employees");
        }
    }
}
