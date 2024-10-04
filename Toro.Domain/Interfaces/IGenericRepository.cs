using System;
using System.Linq.Expressions;
using Toro.Domain.Entities.Base;

namespace Toro.Domain.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        // Add
        void Add(T entity);
        Task AddAsync(T entity, CancellationToken cancellationToken = default);
        void AddRange(IEnumerable<T> entities);
        Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);

        // Update
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);

        // Remove
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        // Get
        T Get(Expression<Func<T, bool>> expression, Expression<Func<T, object>>[]? includes = null);
        Task<T> GetAsync(Expression<Func<T, bool>> expression, Expression<Func<T, object>>[]? includes = null, CancellationToken cancellationToken = default);

        // Get All
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, Expression<Func<T, object>>[]? includes = null);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, Expression<Func<T, object>>[]? includes = null, CancellationToken cancellationToken = default);
        Task<PagedResult<T>> GetFilteredAsync(
            Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            Expression<Func<T, object>>[]? includes = null,
            int? pageNumber = null,
            int? pageSize = null,
            CancellationToken cancellationToken = default);
    }
}

