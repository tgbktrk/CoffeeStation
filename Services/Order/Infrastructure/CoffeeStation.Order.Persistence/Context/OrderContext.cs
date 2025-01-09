using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeStation.Order.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoffeeStation.Order.Persistence.Context
{
    public class OrderContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseSqlServer(
                // "Server=localhost,1440;initial Catalog=MultiShopOrderDb;User=sa;Password=123456aA*;TrustServerCertificate=True;"
                "Server=localhost,1441;Initial Catalog=CoffeeStationOrderDb;User ID=sa;Password=123456aA*;TrustServerCertificate=True;"
            // "Server=localhost,1433;Database=MultiShopDiscountDb;User Id=SA;Password=Tugbaakturk0;TrustServerCertificate=True"
            );
        }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Ordering> Orderings { get; set; }
    }
}
