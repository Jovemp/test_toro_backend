using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Toro.API.Domain.Entities;

namespace Toro.API.Data.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<BondEntity> Bonds { get; set; }
    }
}

