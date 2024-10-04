using System;
using Toro.API.Data.Contexts;
using Toro.API.Domain.Repositories;

namespace Toro.API.Data.Repositories.Base
{
    public class Uow : IUow
    {
        private readonly ApplicationDbContext _dbContext;
        //private IExempleRepository _exempleRepository;

        public Uow(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public IExempleRepository ExempleRepository
        //{
        //    get { return _exempleRepository = _exempleRepository ?? new ExempleRepository(_dbContext); }
        //}

        public void Commit() => _dbContext.SaveChanges();

        public async Task CommitAsync() => await _dbContext.SaveChangesAsync();

        public void Rollback() => _dbContext.Dispose();

        public async Task RollbackAsync() => await _dbContext.DisposeAsync();
    }
}

