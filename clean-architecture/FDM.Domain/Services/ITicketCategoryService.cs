using FDM.Domain.Models;
using FDM.Domain.Services.Communication;

namespace FDM.Domain.Services
{
    public interface ITicketCategoryService
    {
        Task<IEnumerable<Ticketcategory>> ListAsync();
        Task<TicketCategoryResponse> SaveAsync(Ticketcategory category);
        Task<TicketCategoryResponse> UpdateAsync(short id, Ticketcategory category);
        Task<TicketCategoryResponse> DeleteAsync(short id);
    }
}