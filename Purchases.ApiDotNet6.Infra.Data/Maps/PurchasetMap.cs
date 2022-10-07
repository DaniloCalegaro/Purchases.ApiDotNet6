﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Purchases.ApiDotNet6.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchases.ApiDotNet6.Infra.Data.Maps
{
    public class PurchaseMap : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.ToTable("compra");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("idcompra")
                .UseIdentityColumn();

            builder.Property(c => c.PersonId)
                .HasColumnName("idpessoa");

            builder.Property(c => c.ProductId)
                .HasColumnName("idproduto");

            builder.Property(c => c.Date)
                .HasColumnType("date")
                .HasColumnName("datacompra");

            builder.HasOne(c => c.Person)
                .WithMany(p => p.Purchases);

            builder.HasOne(c => c.Product)
                .WithMany(p => p.Purchases);
        }
    }
}
