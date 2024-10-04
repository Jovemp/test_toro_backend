using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Toro.Domain.Entities;

namespace Toro.Infra.Data.EntitiesConfiguration
{
	public class BondConfiguration : IEntityTypeConfiguration<BondEntity>
    {
        public void Configure(EntityTypeBuilder<BondEntity> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd(); 
            builder.Property(p => p.IssuerName).HasMaxLength(40).IsRequired();
            builder.Property(p => p.Index).HasMaxLength(10).IsRequired();
        }
    }
}

