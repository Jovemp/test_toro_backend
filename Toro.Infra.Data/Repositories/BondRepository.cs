using System;
using Toro.Domain.Entities;
using Toro.Domain.Interfaces;
using Toro.Domain.Repositories;
using Toro.Infra.Data.Contexts;
using Toro.Infra.Data.Repositories.Base;

namespace Toro.Infra.Data.Repositories
{
    public class BondRepository : GenericRepository<BondEntity>, IBondRepository
    {
        public BondRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

