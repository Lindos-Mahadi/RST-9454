using AppDomainLayer.Models.Cascade;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AppDomainLayer.SeedDataFolder
{
    public class StateConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.HasData(
                new State { Id = 1, Name = "California", CountryId = 1 },
                new State { Id = 2, Name = "Texas", CountryId = 1 },
                new State { Id = 3, Name = "Ontario", CountryId = 2 },
                new State { Id = 4, Name = "Quebec", CountryId = 2 },
                new State { Id = 5, Name = "London", CountryId = 3 },
                new State { Id = 6, Name = "Manchester", CountryId = 3 },
                new State { Id = 7, Name = "Tokyo", CountryId = 4 },
                new State { Id = 8, Name = "Osaka", CountryId = 4 },
                new State { Id = 9, Name = "New South Wales", CountryId = 5 },
                new State { Id = 10, Name = "Queensland", CountryId = 5 }
            );
        }
    }


}
