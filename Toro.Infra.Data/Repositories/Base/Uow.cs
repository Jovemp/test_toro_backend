using System;
using Toro.Domain.Interfaces;
using Toro.Domain.Repositories;
using Toro.Infra.Data.Contexts;

namespace Toro.Infra.Data.Repositories.Base
{
    public class Uow : IUow
    {
        private readonly ApplicationDbContext _dbContext;
        private IBondRepository _bondRepository;
        private IOrderRepository _orderRepository;
        private IAccountRepository _accountRepository;

        public Uow(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IBondRepository BondRepository
        {
            get { return _bondRepository = _bondRepository ?? new BondRepository(_dbContext); }
        }

        public IOrderRepository OrderRepository
        {
            get { return _orderRepository = _orderRepository ?? new OrderRepository(_dbContext); }
        }

        public IAccountRepository AccountRepository
        {
            get { return _accountRepository = _accountRepository ?? new AccountRepository(_dbContext); }
        }

        public void Commit() => _dbContext.SaveChanges();

        public async Task CommitAsync() => await _dbContext.SaveChangesAsync();

        public void Rollback() => _dbContext.Dispose();

        public async Task RollbackAsync() => await _dbContext.DisposeAsync();
    }
}

