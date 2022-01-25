using Frwk.BootCamp.QuickWait.Remedies.Domain.Entities;
using Frwk.BootCamp.QuickWait.Remedies.Domain.Extensions;
using Frwk.BootCamp.QuickWait.Remedies.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Frwk.BootCamp.QuickWait.Remedies.Infrastructure.Repositories
{
    public class RemedyRepository<TEntity> : IRemedyRepository<TEntity> where TEntity : Entity
    {
        private readonly IDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public RemedyRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public virtual async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public virtual void DeleteManySync(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public virtual void DeleteSync(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public void Dispose()
        {
            //_dbContext.Dispose();
        }

        public virtual async Task<IEnumerable<TEntity>> FindAllAsync(bool asNoTracking = true)
        {
            return await _dbSet.AsNoTracking(asNoTracking).ToListAsync();
        }

        public IEnumerable<TEntity> FindSync(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = true)
        {
            return _dbSet.Where(predicate).AsNoTracking(asNoTracking);
        }

        public virtual async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public Task<int> SaveChangesAsync()
        {
            return _dbContext.SaveChangesAsync();
        }

        public virtual void UpdateSync(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    }
}
