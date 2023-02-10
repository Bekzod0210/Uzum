using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Uzum.Domain.Entities;

namespace Uzum.Aplication.Abstractions
{
    public interface IApplicationDbContext
    {
        DbSet<Brand> Brands { get; set; }
        DbSet<BoughtProduct> BoughtProducts { get; set; }
        DbSet<Card> Cards { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Contract> Contracts { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Payment> Payments { get; set; }
        DbSet<Shop> Shops { get; set; }
        DbSet<ShopProduct> ShopProducts { get; set; }
        DbSet<Transaction> Transactions { get; set; }
        DbSet<User> Users { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
