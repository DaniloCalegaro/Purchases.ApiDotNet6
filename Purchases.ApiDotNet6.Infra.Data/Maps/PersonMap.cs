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
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Pessoa");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasColumnName("idpessoa")
                .UseIdentityColumn();
            builder.Property(c => c.Name)
                .HasColumnName("nome");
            builder.Property(c => c.Document)
                .HasColumnName("documento");
            builder.Property(c => c.Phone)
                .HasColumnName("celular");
            builder.HasMany(c => c.Purchases)
                .WithOne(p => p.Person)
                .HasForeignKey(c => c.PersonId);
        }
    }
}
