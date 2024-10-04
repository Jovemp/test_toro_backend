using System;
using Toro.Domain.Entities;
using Toro.Domain.Repositories;

namespace Toro.Domain.Interfaces
{
	public interface IAccountRepository : IGenericRepository<AccountEntity>
    {
    }
}

