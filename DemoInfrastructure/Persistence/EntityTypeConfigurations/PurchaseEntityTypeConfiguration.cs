using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzum.Domain.Entities;

namespace Uzum.Infrastructure.Persistence.EntityTypeConfigurations
{

    public class PurchaseEntityTypeConfiguration : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(x => x.OrderDetail)
                .WithMany(x => x.Purchases)
                .HasForeignKey(x => x.OrderDetailId);
        }
    }
}
