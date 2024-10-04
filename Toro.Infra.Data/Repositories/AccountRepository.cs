using System;
using Toro.Domain.Entities;
using Toro.Domain.Interfaces;
using Toro.Infra.Data.Contexts;
using Toro.Infra.Data.Repositories.Base;

namespace Toro.Infra.Data.Repositories
{
	public class AccountRepository : GenericRepository<AccountEntity>, IAccountRepository
    {
        public AccountRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

