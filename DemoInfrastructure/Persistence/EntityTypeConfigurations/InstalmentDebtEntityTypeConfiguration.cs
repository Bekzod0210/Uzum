using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzum.Domain.Entities;

namespace Uzum.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class InstalmentDebtEntityTypeConfiguration : IEntityTypeConfiguration<InstalmentDebt>
    {
        public void Configure(EntityTypeBuilder<InstalmentDebt> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Instalment)
                .WithMany(x => x.Debts)
                .HasForeignKey(x => x.InstalmentId);
        }
    }
}
