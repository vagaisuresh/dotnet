using FDM.Domain.Models;
using FDM.Domain.Repositories;
using FDM.Domain.Services;
using FDM.Domain.Services.Communication;

namespace FDM.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRespository _respository;
        private readonly IUnitOfWork _unitOfWork;

        public TicketService(ITicketRespository respository, IUnitOfWork unitOfWork)
        {
            _respository = respository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Ticket>> ListAsync()
        {
            return await _respository.ListAsync();
        }

        public async Task<TicketResponse> SaveAsync(Ticket ticket)
        {
            try
            {
                await _respository.AddAsync(ticket);
                await _unitOfWork.CompleteAsync();

                return new TicketResponse(ticket);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new TicketResponse($"An error occurred when saving the ticket: {ex.Message}");
            }
        }

        public async Task<TicketResponse> UpdateAsync(int id, Ticket ticket)
        {
            var existingTicket = await _respository.FindByIdAsync(id);

            if (existingTicket == null)
                return new TicketResponse("Ticket not found.");

            existingTicket.TicketDate = ticket.TicketDate;
            /// OTHER FIELDS

            try
            {
                _respository.Update(existingTicket);
                await _unitOfWork.CompleteAsync();

                return new TicketResponse(existingTicket);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new TicketResponse($"An error occurred when updating the ticket: {ex.Message}");
            }
        }

        public async Task<TicketResponse> DeleteAsync(int id)
        {
            var existingTicket = await _respository.FindByIdAsync(id);

            if (existingTicket == null)
                return new TicketResponse("Ticket not found.");

            try
            {
                _respository.Remove(existingTicket);
                await _unitOfWork.CompleteAsync();

                return new TicketResponse(existingTicket);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new TicketResponse($"An error occurred when deleting the ticket: {ex.Message}");
            }
        }
    }
}