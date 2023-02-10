using Microsoft.EntityFrameworkCore;
using Uzum.Domain.Entities;

namespace Uzum.Aplication.Abstractions
{
    public interface IAppDbContext
    {
         DbSet<Admin> Admins { get; set; }
         DbSet<Category> Categories { get; set; }
         DbSet<Customer> Customers { get; set; }
         DbSet<Instalment> Instalments { get; set; }
         DbSet<InstalmentDebt> InstalmentDebts { get; set; }
         DbSet<Manufacturer> Manufacturers { get; set; }
         DbSet<Merchant> Merchants { get; set; }
         DbSet<MerchantProduct> MerchantProducts { get; set; }
         DbSet<Order> Orders { get; set; }
         DbSet<OrderDetail> OrderDetails { get; set; }
         DbSet<Product> Products { get; set; }
         DbSet<Purchase> Purchases { get; set; }
         DbSet<User> Users { get; set; }
         Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
