using System;
using Toro.Domain.Entities;
using Toro.Domain.Interfaces;
using Toro.Infra.Data.Contexts;
using Toro.Infra.Data.Repositories.Base;

namespace Toro.Infra.Data.Repositories
{
	public class OrderRepository : GenericRepository<OrderEntity>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

