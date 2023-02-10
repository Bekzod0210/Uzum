using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzum.Domain.Entities;

namespace Uzum.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class InstalmentEntityTypeConfiguration : IEntityTypeConfiguration<Instalment>
    {
        public void Configure(EntityTypeBuilder<Instalment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Order)
                .WithOne(x => x.Instalment)
                .HasForeignKey<Instalment>(x => x.OrderId);
        }
    }
}
