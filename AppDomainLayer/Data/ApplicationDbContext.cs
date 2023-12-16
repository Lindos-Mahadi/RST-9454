using AppDomainLayer.Models;
using AppDomainLayer.SeedDataFolder;
using Microsoft.EntityFrameworkCore;

namespace AppDomainLayer.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Other DbSet properties can be added for additional entities
        public DbSet<Employee> Employee { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }

    }
    
}
