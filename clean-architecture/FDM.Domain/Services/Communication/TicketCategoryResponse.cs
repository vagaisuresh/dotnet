using FDM.Domain.Models;

#nullable disable

namespace FDM.Domain.Services.Communication
{
    public class TicketCategoryResponse : ResponseBase
    {
        public Ticketcategory Ticketcategory { get; private set; }

        public TicketCategoryResponse(bool success, string message, Ticketcategory ticketcategory) : base(success, message)
        {
            Ticketcategory = ticketcategory;
        }

        public TicketCategoryResponse(Ticketcategory ticketcategory) : this(true, string.Empty, ticketcategory)
        {
        }

        public TicketCategoryResponse(string message) : this(false, message, null)
        {
        }
    }
}