using FDM.Domain.Models;

#nullable disable

namespace FDM.Domain.Services.Communication
{
    public class TicketResponse : ResponseBase
    {
        public Ticket Ticket { get; private set; }

        public TicketResponse(bool success, string message, Ticket ticket) : base(success, message)
        {
            Ticket = ticket;
        }

        public TicketResponse(Ticket ticket) : this(true, string.Empty, ticket)
        {
        }

        public TicketResponse(string message) : this(false, message, null)
        {
        }
    }
}