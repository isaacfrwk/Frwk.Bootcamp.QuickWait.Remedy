using Frwk.BootCamp.QuickWait.Remedies.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Frwk.BootCamp.QuickWait.Remedies.Domain.Extensions
{
    public static class QueriableExtensions
    {
        public static IQueryable<TEntity> AsNoTracking<TEntity>(this IQueryable<TEntity> query, bool asNoTracking) where TEntity : Entity
        {
            if (!asNoTracking)
                return query;

            return query.AsNoTracking();
        }

    }
}
