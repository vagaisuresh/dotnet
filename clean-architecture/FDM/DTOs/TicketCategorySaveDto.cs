using System.ComponentModel.DataAnnotations;

namespace FDM.DTOs
{
    public class TicketCategorySaveDto
    {
        [Required]
        [MaxLength(30)]
        public string? CategoryName { get; set; }

        public bool IsActive { get; set; }
        public bool IsRemoved { get; set; }

        [Required]
        [Range(1, short.MaxValue)]
        public short BranchCode { get; set; }
    }
}