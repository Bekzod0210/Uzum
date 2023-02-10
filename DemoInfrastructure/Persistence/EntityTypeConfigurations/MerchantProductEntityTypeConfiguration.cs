using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzum.Domain.Entities;

namespace Uzum.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class MerchantProductEntityTypeConfiguration : IEntityTypeConfiguration<MerchantProduct>
    {
        public void Configure(EntityTypeBuilder<MerchantProduct> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Merchant)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.MerchantId);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.MerchantProducts)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
