using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Toro.Domain.Entities;

namespace Toro.Infra.Data.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AccountEntity>().HasData(
                new AccountEntity { Id = -1, ClientId = "12454", Balance = 100.00 }
            );

            modelBuilder.Entity<BondEntity>().HasData(
                new BondEntity(-1, "CDB",  "IPCA", 5.0, "Banco Teste",  1000, 100.00),
                new BondEntity(-2, "LCI", "Pre", 5.0, "Banco Teste 2", 2000, 100.00),
                new BondEntity(-3, "LCI", "CDI", 4.5, "Banco Exemplo", 1500, 200.00),
                new BondEntity(-4, "LCA", "Selic", 3.8, "Banco Invest", 1200, 300.00),
                new BondEntity(-5, "CDB", "IPCA", 6.2, "Banco Alpha", 1000, 150.00),
                new BondEntity(-6, "LCI", "IPCA", 5.5, "Banco Beta", 1800, 250.00),
                new BondEntity(-7, "Debênture", "CDI", 7.0, "Banco Delta", 2000, 80.00),
                new BondEntity(-8, "CRI", "IPCA", 5.9, "Banco Gama", 1100, 180.00),
                new BondEntity(-9, "CDB", "Selic", 4.2, "Banco Omega", 1300, 220.00),
                new BondEntity(-10, "LCA", "CDI", 4.8, "Banco Theta", 1700, 140.00),
                new BondEntity(-11, "LCI", "IPCA", 6.1, "Banco Zeta", 1900, 160.00),
                new BondEntity(-12, "Debênture", "Selic", 5.7, "Banco Epsilon", 2100, 120.00)
            );

            modelBuilder.Entity<OrderEntity>().HasData(
                new OrderEntity
                {
                    CreateDate = DateTime.Now,
                    Date = DateTime.Now,
                    Quantity = 100.00,
                    Status = Domain.Enums.StatusOrder.COMPLETED,
                    Type = Domain.Enums.TypeOrder.SALE,
                    UpdateDate = DateTime.Now,
                    BondId = -1,
                    Id = -1,
                },
                new OrderEntity
                {
                    CreateDate = DateTime.Now,
                    Date = DateTime.Now,
                    Quantity = 100.00,
                    Status = Domain.Enums.StatusOrder.COMPLETED,
                    Type = Domain.Enums.TypeOrder.SALE,
                    UpdateDate = DateTime.Now,
                    BondId = -2,
                    Id = -2,
                },
                new OrderEntity
                {
                    CreateDate = DateTime.Now,
                    Date = DateTime.Now,
                    Quantity = 200.00,
                    Status = Domain.Enums.StatusOrder.COMPLETED,
                    Type = Domain.Enums.TypeOrder.SALE,
                    UpdateDate = DateTime.Now,
                    BondId = -3,
                    Id = -3,
                },
                new OrderEntity
                {
                    CreateDate = DateTime.Now,
                    Date = DateTime.Now,
                    Quantity = 300.00,
                    Status = Domain.Enums.StatusOrder.COMPLETED,
                    Type = Domain.Enums.TypeOrder.SALE,
                    UpdateDate = DateTime.Now,
                    BondId = -4,
                    Id = -4,
                },
                new OrderEntity
                {
                    CreateDate = DateTime.Now,
                    Date = DateTime.Now,
                    Quantity = 150.00,
                    Status = Domain.Enums.StatusOrder.COMPLETED,
                    Type = Domain.Enums.TypeOrder.SALE,
                    UpdateDate = DateTime.Now,
                    BondId = -5,
                    Id = -5
                },
                new OrderEntity
                {
                    CreateDate = DateTime.Now,
                    Date = DateTime.Now,
                    Quantity = 250.00,
                    Status = Domain.Enums.StatusOrder.COMPLETED,
                    Type = Domain.Enums.TypeOrder.SALE,
                    UpdateDate = DateTime.Now,
                    BondId = -6,
                    Id = -6
                },
                new OrderEntity
                {
                    CreateDate = DateTime.Now,
                    Date = DateTime.Now,
                    Quantity = 80.00,
                    Status = Domain.Enums.StatusOrder.COMPLETED,
                    Type = Domain.Enums.TypeOrder.SALE,
                    UpdateDate = DateTime.Now,
                    BondId = -7,
                    Id = -7
                },
                new OrderEntity
                {
                    CreateDate = DateTime.Now,
                    Date = DateTime.Now,
                    Quantity = 180.00,
                    Status = Domain.Enums.StatusOrder.COMPLETED,
                    Type = Domain.Enums.TypeOrder.SALE,
                    UpdateDate = DateTime.Now,
                    BondId = -8,
                    Id = -8
                },
                new OrderEntity
                {
                    CreateDate = DateTime.Now,
                    Date = DateTime.Now,
                    Quantity = 220.00,
                    Status = Domain.Enums.StatusOrder.COMPLETED,
                    Type = Domain.Enums.TypeOrder.SALE,
                    UpdateDate = DateTime.Now,
                    BondId = -9,
                    Id = -9
                },
                new OrderEntity
                {
                    CreateDate = DateTime.Now,
                    Date = DateTime.Now,
                    Quantity = 140.00,
                    Status = Domain.Enums.StatusOrder.COMPLETED,
                    Type = Domain.Enums.TypeOrder.SALE,
                    UpdateDate = DateTime.Now,
                    BondId = -10,
                    Id = -10
                },
                new OrderEntity
                {
                    CreateDate = DateTime.Now,
                    Date = DateTime.Now,
                    Quantity = 160.00,
                    Status = Domain.Enums.StatusOrder.COMPLETED,
                    Type = Domain.Enums.TypeOrder.SALE,
                    UpdateDate = DateTime.Now,
                    BondId = -11,
                    Id = -11
                },
                new OrderEntity
                {
                    CreateDate = DateTime.Now,
                    Date = DateTime.Now,
                    Quantity = 120.00,
                    Status = Domain.Enums.StatusOrder.COMPLETED,
                    Type = Domain.Enums.TypeOrder.SALE,
                    UpdateDate = DateTime.Now,
                    BondId = -12,
                    Id = -12
                }
            );
        }

        public DbSet<BondEntity> Bonds { get; set; }
        public DbSet<AccountEntity> Accounts { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
    }
}

