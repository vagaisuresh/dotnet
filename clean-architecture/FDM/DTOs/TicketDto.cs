using FDM.Domain.Models;

namespace FDM.DTOs
{
    public class TicketDto
    {
        public int TicketId { get; set; }
        public DateTime TicketDate { get; set; }
        public short TicketCategory { get; set; }
        public string? Subject { get; set; }
        public string? Salutation { get; set; }
        public string? Name { get; set; }
        public string? Designation { get; set; }
        public string? CompanyName { get; set; }
        public string? MobileIsd { get; set; }
        public string? MobileNumber { get; set; }
        public string? EmailId { get; set; }
        public string? TicketDescription { get; set; }
        public string? ReferenceNumber { get; set; }
        public DateTime ReferenceDate { get; set; }
        public string? SupportDocument { get; set; }
        public byte Priority { get; set; }
        public byte Status { get; set; }
        public int PreparedBy { get; set; }
        public DateTime PreparedDateTime { get; set; }
        public short BranchCode { get; set; }

        public Ticketcategory? TicketCategoryNavigation { get; set; }
    }
}