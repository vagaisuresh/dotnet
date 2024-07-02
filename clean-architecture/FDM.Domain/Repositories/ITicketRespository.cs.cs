using FDM.Domain.Models;

namespace FDM.Domain.Repositories
{
    public interface ITicketRespository
    {
        Task<IEnumerable<Ticket>> ListAsync();
        Task<Ticket> FindByIdAsync(int id);
        Task AddAsync(Ticket ticket);
        void Update(Ticket ticket);
        void Remove(Ticket ticket);
    }
}