using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Purchases.ApiDotNet6.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchases.ApiDotNet6.Infra.Data.Maps
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("produto");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("idproduto")
                .UseIdentityColumn();

            builder.Property(c => c.Name)
                .HasColumnName("nome");

            builder.Property(c => c.CodErp)
                .HasColumnName("coderp");

            builder.Property(c => c.Price)
                .HasColumnName("preco");

            builder.HasMany(c => c.Purchases)
                .WithOne(p => p.Product)
                .HasForeignKey(c => c.ProductId);
        }
    }
}
