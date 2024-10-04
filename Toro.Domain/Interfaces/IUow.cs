using System;
using Toro.Domain.Interfaces;

namespace Toro.Domain.Repositories
{
    public interface IUow : IUnitOfWork
    {
        IBondRepository BondRepository { get; }
        IOrderRepository OrderRepository { get; }
        IAccountRepository AccountRepository { get; }
    }
}

