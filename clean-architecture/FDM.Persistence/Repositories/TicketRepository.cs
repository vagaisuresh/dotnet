using FDM.Domain.Models;
using FDM.Domain.Repositories;
using FDM.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FDM.Persistence.Repositories
{
    public class TicketRepository : RepositoryBase, ITicketRespository
    {
        public TicketRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Ticket>> ListAsync()
        {
            return await _context.Tickets.ToListAsync();
        }

        public async Task<Ticket> FindByIdAsync(int id)
        {
            return await _context.Tickets.FindAsync(id);
        }

        public async Task AddAsync(Ticket ticket)
        {
            await _context.Tickets.AddAsync(ticket);
        }

        public void Update(Ticket ticket)
        {
            _context.Tickets.Update(ticket);
        }

        public void Remove(Ticket ticket)
        {
            _context.Tickets.Remove(ticket);
        }
    }
}