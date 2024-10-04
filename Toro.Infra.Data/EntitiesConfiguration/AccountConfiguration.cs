using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Toro.Domain.Entities;

namespace Toro.Infra.Data.EntitiesConfiguration
{
	public class AccountConfiguration : IEntityTypeConfiguration<AccountEntity>
    {
        public void Configure(EntityTypeBuilder<AccountEntity> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.ClientId).HasMaxLength(10).IsRequired();
            builder.Property(p => p.CreateDate).IsRequired();
        }
    }
}

