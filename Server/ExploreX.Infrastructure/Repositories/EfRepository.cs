using Microsoft.EntityFrameworkCore;
using ExploreX.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ExploreX.Infrastructure.Data;

namespace ExploreX.Infrastructure.Repositories
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DataContext _context;

        public EfRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<TEntity> GetByIdAsync(Guid id) => await _context.Set<TEntity>().FindAsync(id);

        public async Task<IEnumerable<TEntity>> GetAllAsync() => await _context.Set<TEntity>().ToListAsync();

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
            => await _context.Set<TEntity>().Where(predicate).ToListAsync();

        public async Task AddAsync(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public void Update(TEntity entity) => _context.Set<TEntity>().Update(entity);

        public void Remove(TEntity entity) => _context.Set<TEntity>().Remove(entity);
    }
}