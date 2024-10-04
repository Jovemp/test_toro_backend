using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Toro.Domain.Entities;

namespace Toro.Infra.Data.EntitiesConfiguration
{
	public class OrderConfiguration : IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Quantity).IsRequired();
            builder.Property(p => p.Status).IsRequired();
            builder.Property(p => p.Type).IsRequired();
            builder.Property(p => p.AccountId).IsRequired(false);

            builder.HasOne(e => e.Bond)
               .WithMany(b => b.Orders)
               .HasForeignKey(e => e.BondId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Account)
               .WithMany(b => b.Orders)
               .HasForeignKey(e => e.AccountId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

