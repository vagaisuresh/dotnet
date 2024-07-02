using FDM.Domain.Repositories;
using FDM.Persistence.Contexts;

namespace FDM.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task CompleteAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}