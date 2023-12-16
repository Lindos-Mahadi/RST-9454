using AppDomainLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AppDomainLayer.SeedDataFolder
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee { Id = 1, Name = "John Doe", Gender = "Male", Email = "john.doe@example.com", Country = "USA" },
                new Employee { Id = 2, Name = "Jane Doe", Gender = "Female", Email = "jane.doe@example.com", Country = "USA" },
                new Employee { Id = 3, Name = "Alice Johnson", Gender = "Female", Email = "alice.johnson@example.com", Country = "Canada" },
                new Employee { Id = 4, Name = "Bob Smith", Gender = "Male", Email = "bob.smith@example.com", Country = "UK" },
                new Employee { Id = 5, Name = "Eva Williams", Gender = "Female", Email = "eva.williams@example.com", Country = "Australia" },
                new Employee { Id = 6, Name = "Michael Brown", Gender = "Male", Email = "michael.brown@example.com", Country = "USA" },
                new Employee { Id = 7, Name = "Sophia Taylor", Gender = "Female", Email = "sophia.taylor@example.com", Country = "Canada" },
                new Employee { Id = 8, Name = "William Davis", Gender = "Male", Email = "william.davis@example.com", Country = "UK" },
                new Employee { Id = 9, Name = "Olivia Martinez", Gender = "Female", Email = "olivia.martinez@example.com", Country = "Australia" },
                new Employee { Id = 10, Name = "James Johnson", Gender = "Male", Email = "james.johnson@example.com", Country = "USA" },
                new Employee { Id = 11, Name = "Emma Brown", Gender = "Female", Email = "emma.brown@example.com", Country = "Canada" },
                new Employee { Id = 12, Name = "Liam Davis", Gender = "Male", Email = "liam.davis@example.com", Country = "UK" },
                new Employee { Id = 13, Name = "Ava Williams", Gender = "Female", Email = "ava.williams@example.com", Country = "Australia" },
                new Employee { Id = 14, Name = "Noah Miller", Gender = "Male", Email = "noah.miller@example.com", Country = "USA" },
                new Employee { Id = 15, Name = "Isabella Smith", Gender = "Female", Email = "isabella.smith@example.com", Country = "Canada" },
                new Employee { Id = 16, Name = "Mason Davis", Gender = "Male", Email = "mason.davis@example.com", Country = "UK" },
                new Employee { Id = 17, Name = "Sophia Wilson", Gender = "Female", Email = "sophia.wilson@example.com", Country = "Australia" },
                new Employee { Id = 18, Name = "Jackson Johnson", Gender = "Male", Email = "jackson.johnson@example.com", Country = "USA" },
                new Employee { Id = 19, Name = "Olivia Taylor", Gender = "Female", Email = "olivia.taylor@example.com", Country = "Canada" },
                new Employee { Id = 20, Name = "Logan Davis", Gender = "Male", Email = "logan.davis@example.com", Country = "UK" }
            );
        }
    }
}
