namespace FDM.DTOs
{
    public class TicketCategoryDto
    {
        public short Id { get; set; }
        public string? CategoryName { get; set; }
        public bool IsActive { get; set; }
        public bool IsRemoved { get; set; }
        public short BranchCode { get; set; }
    }
}