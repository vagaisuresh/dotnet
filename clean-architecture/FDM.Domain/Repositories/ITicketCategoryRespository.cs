using FDM.Domain.Models;

namespace FDM.Domain.Repositories
{
    public interface ITicketCategoryRespository
    {
        Task<IEnumerable<Ticketcategory>> ListAsync();
        Task<Ticketcategory> FindByIdAsync(short id);
        Task AddAsync(Ticketcategory ticketcategory);
        void Update(Ticketcategory ticketcategory);
        void Remove(Ticketcategory ticketcategory);
    }
}