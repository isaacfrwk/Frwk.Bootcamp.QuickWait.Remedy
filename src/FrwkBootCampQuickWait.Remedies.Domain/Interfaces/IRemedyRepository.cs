using Frwk.BootCamp.QuickWait.Remedies.Domain.Entities;
using System.Linq.Expressions;

namespace Frwk.BootCamp.QuickWait.Remedies.Domain.Interfaces
{
    public interface IRemedyRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task AddAsync(TEntity entity);

        void DeleteSync(TEntity entity);

        void DeleteManySync(IEnumerable<TEntity> entities);

        Task<IEnumerable<TEntity>> FindAllAsync(bool asNoTracking = true);

        IEnumerable<TEntity> FindSync(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = true);

        Task<TEntity> GetByIdAsync(Guid id);

        Task<int> SaveChangesAsync();

        void UpdateSync(TEntity entity);

    }
}
