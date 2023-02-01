using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzum.Domain.Entities;

namespace Uzum.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class ShopEntityTypeConfiguration : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.AccountNumber)
                .IsRequired();
        }
    }
}
