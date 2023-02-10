using Microsoft.EntityFrameworkCore;
using Uzum.Aplication.Abstractions;
using Uzum.Domain.Entities;

namespace Uzum.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IAppDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Instalment> Instalments { get; set; }
        public DbSet<InstalmentDebt> InstalmentDebts { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<MerchantProduct> MerchantProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}