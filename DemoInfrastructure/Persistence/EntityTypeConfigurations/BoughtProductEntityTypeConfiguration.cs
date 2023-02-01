using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
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
