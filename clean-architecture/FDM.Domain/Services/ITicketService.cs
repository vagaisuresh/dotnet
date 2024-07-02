using FDM.Domain.Models;
using FDM.Domain.Services.Communication;

namespace FDM.Domain.Services
{
    public interface ITicketService
    {
        Task<IEnumerable<Ticket>> ListAsync();
        Task<TicketResponse> SaveAsync(Ticket ticket);
        Task<TicketResponse> UpdateAsync(int id, Ticket ticket);
        Task<TicketResponse> DeleteAsync(int id);
    }
}