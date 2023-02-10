using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzum.Domain.Entities;

namespace Uzum.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class ManufacturerEntityTypeConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
