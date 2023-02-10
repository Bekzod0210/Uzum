using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzum.Domain.Entities;

namespace Uzum.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class MerchantEntityTypeConfiguration : IEntityTypeConfiguration<Merchant>
    {
        void IEntityTypeConfiguration<Merchant>.Configure(EntityTypeBuilder<Merchant> builder)
        {
            throw new NotImplementedException();
        }
    }
}
