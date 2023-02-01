using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzum.Domain.Entities;

namespace Uzum.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class CardEntityTypeConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CardNumber)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasData(new Card()
            {
                Id = 1,
                CardNumber = "8600 0000 0000",
                TotalSum = 0,
            });
        }
    }
}
