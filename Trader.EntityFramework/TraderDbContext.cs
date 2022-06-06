using Microsoft.EntityFrameworkCore;
using System;
using Trader.Models;

namespace Trader.EntityFramework
{
    public class TraderDbContext: DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Acount> Acounts { get; set; }
        public DbSet<AssetTransection> AssetTransection { get; set; }

        public TraderDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssetTransection>().OwnsOne(a => a.Stock);

            base.OnModelCreating(modelBuilder);
        }
    }
}
