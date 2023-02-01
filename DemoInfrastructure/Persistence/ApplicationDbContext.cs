using Microsoft.EntityFrameworkCore;
using Uzum.Domain.Entities;

namespace Uzum.Infrastructure.Persistence
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<BoughtProduct> boughtProducts { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Card> cards { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Contract> contracts { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<Shop> shops { get; set; }
        public DbSet<ShopProduct> shopProducts { get; set; }
        public DbSet<Transaction> transactions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
