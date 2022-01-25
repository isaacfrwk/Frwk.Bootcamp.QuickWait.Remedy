using Frwk.BootCamp.QuickWait.Remedies.Domain.Entities;
using Frwk.BootCamp.QuickWait.Remedies.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Frwk.BootCamp.QuickWait.Remedies.Infrastructure.Context
{
    public class DBContext : DbContext, IDbContext
    {
        public DBContext()
        {

        }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

        public virtual DbSet<Remedy>Remedies { get; set; }

    }
}
