using System;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Toro.Domain.Repositories;
using Toro.Infra.Data.Contexts;
using Toro.Domain.Entities.Base;

namespace Toro.Infra.Data.Repositories.Base
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<T> _entitiySet;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _entitiySet = _dbContext.Set<T>();
        }

        // Add
        public void Add(T entity)
            => _dbContext.Add(entity);

        public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
            => await _dbContext.AddAsync(entity, cancellationToken);

        public void AddRange(IEnumerable<T> entities)
            => _dbContext.AddRange(entities);

        public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
            => await _dbContext.AddRangeAsync(entities, cancellationToken);

        // Update
        public void Update(T entity)
            => _dbContext.Update(entity);

        public void UpdateRange(IEnumerable<T> entities)
            => _dbContext.UpdateRange(entities);

        // Remove
        public void Remove(T entity)
            => _dbContext.Remove(entity);

        public void RemoveRange(IEnumerable<T> entities)
            => _dbContext.RemoveRange(entities);

        // Get

        public T Get(
            Expression<Func<T, bool>> expression,
            Expression<Func<T, object>>[]? includes = null)
        {
            IQueryable<T> query = _entitiySet;

            if (includes != null)
                foreach (var include in includes)
                    query = query.Include(include);

            return query.FirstOrDefault(expression);
        }

        public async Task<T> GetAsync(
            Expression<Func<T, bool>> expression,
            Expression<Func<T, object>>[]? includes = null,
            CancellationToken cancellationToken = default)
        {
            IQueryable<T> query = _entitiySet;

            if (includes != null)
                foreach (var include in includes)
                    query = query.Include(include);

            return await query.FirstOrDefaultAsync(expression, cancellationToken);
        }

        // Get All
        public IEnumerable<T> GetAll()
            => _entitiySet.AsEnumerable();

        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default)
            => await _entitiySet.ToListAsync(cancellationToken);

        public IEnumerable<T> GetAll(
            Expression<Func<T, bool>> expression,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            Expression<Func<T, object>>[]? includes = null)
        {
            IQueryable<T> query = _entitiySet;

            if (includes != null)
                foreach (var include in includes)
                    query = query.Include(include);

            query = query.Where(expression);

            if (orderBy is not null)
                query = orderBy(query);

            return query.ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync(
            Expression<Func<T, bool>> expression,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            Expression<Func<T, object>>[]? includes = null,
            CancellationToken cancellationToken = default)
        {
            IQueryable<T> query = _entitiySet;

            if (includes != null)
                foreach (var include in includes)
                    query = query.Include(include);

            query = query.Where(expression);

            if (orderBy is not null)
                query = orderBy(query);

            return await query.ToListAsync(cancellationToken);
        }

        public async Task<PagedResult<T>> GetFilteredAsync(
            Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            Expression<Func<T, object>>[]? includes = null,
            int? pageNumber = null,
            int? pageSize = null,
            CancellationToken cancellationToken = default)
        {
            IQueryable<T> query = _entitiySet;

            // Incluir propriedades de navegação
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            // Aplicar filtro
            if (filter != null)
            {
                query = query.Where(filter);
            }

            // Contar o total de registros antes da paginação
            int totalCount = await query.CountAsync(cancellationToken);

            // Aplicar ordenação
            if (orderBy != null)
            {
                query = orderBy(query);
            }

            // Aplicar paginação
            if (pageNumber.HasValue && pageSize.HasValue)
            {
                int skip = (pageNumber.Value - 1) * pageSize.Value;
                query = query.Skip(skip).Take(pageSize.Value);
            }

            // Retornar os dados paginados e o total de registros
            var items = await query.ToListAsync(cancellationToken);

            return new PagedResult<T>
            {
                Items = items,
                TotalCount = totalCount
            };
        }

    }
}

