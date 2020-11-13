using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using CryptocurrencyTrader.Models;

namespace CryptocurrencyTrader.Models
{
    public class PostgresRdsDbContext : DbContext
    {        
            public PostgresRdsDbContext(DbContextOptions<PostgresRdsDbContext> options) : base(options) { }
            public DbSet<Transaction> Transactions { get; set;}
            public DbSet<CryptoCurrency> CryptoCurrencies { get; set;}

            protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);
            }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }

        
    }
}