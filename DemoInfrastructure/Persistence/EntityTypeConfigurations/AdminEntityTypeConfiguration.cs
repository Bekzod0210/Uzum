using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzum.Domain.Entities;

namespace Uzum.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class AdminEntityTypeConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            // 2 lasi ham bir hil
            //builder.ToTable("Admin");
            builder.ToTable(nameof(Admin));
            builder.HasKey(x => x.Id);
        }
    }
}
