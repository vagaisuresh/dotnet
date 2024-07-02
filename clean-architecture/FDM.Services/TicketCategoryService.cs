using FDM.Domain.Models;
using FDM.Domain.Repositories;
using FDM.Domain.Services;
using FDM.Domain.Services.Communication;

namespace FDM.Services
{
    public class TicketCategoryService : ITicketCategoryService
    {
        private readonly ITicketCategoryRespository _respository;
        private readonly IUnitOfWork _unitOfWork;

        public TicketCategoryService(ITicketCategoryRespository respository, IUnitOfWork unitOfWork)
        {
            _respository = respository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Ticketcategory>> ListAsync()
        {
            return await _respository.ListAsync();
        }

        public async Task<TicketCategoryResponse> SaveAsync(Ticketcategory ticketcategory)
        {
            try
            {
                await _respository.AddAsync(ticketcategory);
                await _unitOfWork.CompleteAsync();

                return new TicketCategoryResponse(ticketcategory);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new TicketCategoryResponse($"An error occurred when saving the ticket category: {ex.Message}");
            }
        }

        public async Task<TicketCategoryResponse> UpdateAsync(short id, Ticketcategory ticketcategory)
        {
            var existingCategory = await _respository.FindByIdAsync(id);

            if (existingCategory == null)
                return new TicketCategoryResponse("Ticket category not found.");

            existingCategory.CategoryName = ticketcategory.CategoryName;
            existingCategory.IsActive = ticketcategory.IsActive;

            try
            {
                _respository.Update(existingCategory);
                await _unitOfWork.CompleteAsync();

                return new TicketCategoryResponse(existingCategory);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new TicketCategoryResponse($"An error occurred when updating the category: {ex.Message}");
            }
        }

        public async Task<TicketCategoryResponse> DeleteAsync(short id)
        {
            var existingCategory = await _respository.FindByIdAsync(id);

            if (existingCategory == null)
                return new TicketCategoryResponse("Ticket category not found.");

            try
            {
                _respository.Remove(existingCategory);
                await _unitOfWork.CompleteAsync();

                return new TicketCategoryResponse(existingCategory);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new TicketCategoryResponse($"An error occurred when deleting the category: {ex.Message}");
            }
        }
    }
}