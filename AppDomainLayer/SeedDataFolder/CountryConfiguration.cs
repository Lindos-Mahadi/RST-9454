using AppDomainLayer.Models.Cascade;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AppDomainLayer.SeedDataFolder
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country { Id = 1, CountryName = "United States" },
                new Country { Id = 2, CountryName = "Canada" },
                new Country { Id = 3, CountryName = "United Kingdom" },
                new Country { Id = 4, CountryName = "Australia" },
                new Country { Id = 5, CountryName = "Germany" },
                new Country { Id = 6, CountryName = "France" },
                new Country { Id = 7, CountryName = "Japan" },
                new Country { Id = 8, CountryName = "Brazil" },
                new Country { Id = 9, CountryName = "India" },
                new Country { Id = 10, CountryName = "China" }
            );
        }
    }

}
