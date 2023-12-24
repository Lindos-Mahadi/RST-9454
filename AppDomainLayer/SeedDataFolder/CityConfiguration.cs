using AppDomainLayer.Models.Cascade;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AppDomainLayer.SeedDataFolder
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
                new City { Id = 1, CityName = "City 1", StateId = 1 },
                new City { Id = 2, CityName = "City 2", StateId = 1 },
                new City { Id = 3, CityName = "City 3", StateId = 2 },
                new City { Id = 4, CityName = "City 4", StateId = 2 },
                new City { Id = 5, CityName = "City 5", StateId = 3 },
                new City { Id = 6, CityName = "City 6", StateId = 3 },
                new City { Id = 7, CityName = "City 7", StateId = 4 },
                new City { Id = 8, CityName = "City 8", StateId = 4 },
                new City { Id = 9, CityName = "City 9", StateId = 5 },
                new City { Id = 10, CityName = "City 10", StateId = 5 }
            );
        }
    }

}
