using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzum.Domain.Entities;

namespace Uzum.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class BoughtProductEntityTypeConfiguration : IEntityTypeConfiguration<BoughtProduct>
    {
        public void Configure(EntityTypeBuilder<BoughtProduct> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
