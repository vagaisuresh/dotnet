using FDM.Persistence.Contexts;

namespace FDM.Persistence.Repositories
{
    public abstract class RepositoryBase
    {
        protected readonly AppDbContext _context;

        public RepositoryBase(AppDbContext context)
        {
            _context = context;
        }
    }
}