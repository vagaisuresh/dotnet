using FDM.Domain.Models;
using FDM.Domain.Repositories;
using FDM.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FDM.Persistence.Repositories
{
    public class TicketCategoryRepository : RepositoryBase, ITicketCategoryRespository
    {
        public TicketCategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Ticketcategory>> ListAsync()
        {
            return await _context.Ticketcategories.ToListAsync();
        }

        public async Task<Ticketcategory> FindByIdAsync(short id)
        {
            return await _context.Ticketcategories.FindAsync(id);
        }

        public async Task AddAsync(Ticketcategory ticketcategory)
        {
            await _context.Ticketcategories.AddAsync(ticketcategory);
        }

        public void Update(Ticketcategory ticketcategory)
        {
            _context.Ticketcategories.Update(ticketcategory);
        }

        public void Remove(Ticketcategory ticketcategory)
        {
            _context.Ticketcategories.Remove(ticketcategory);
        }
    }
}