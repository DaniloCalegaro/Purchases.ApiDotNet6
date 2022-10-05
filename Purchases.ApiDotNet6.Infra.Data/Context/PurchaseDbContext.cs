using Microsoft.EntityFrameworkCore;
using Purchases.ApiDotNet6.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchases.ApiDotNet6.Infra.Data.Context
{
    public class PurchaseDbContext : DbContext
    {
        public PurchaseDbContext(DbContextOptions<PurchaseDbContext> options) : base(options)
        {}

        public DbSet<Person> People { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PurchaseDbContext).Assembly);
        }
    }
}
