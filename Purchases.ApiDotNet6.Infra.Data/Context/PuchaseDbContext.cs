using Microsoft.EntityFrameworkCore;
using Purchases.ApiDotNet6.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchases.ApiDotNet6.Infra.Data.Context
{
    public class PuchaseDbContext : DbContext
    {
        public PuchaseDbContext(DbContextOptions<PuchaseDbContext> options) : base(options)
        {}

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PuchaseDbContext).Assembly);
        }
    }
}
