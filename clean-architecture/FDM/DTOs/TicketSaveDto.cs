using System.ComponentModel.DataAnnotations;

namespace FDM.DTOs
{
    public class TicketSaveDto
    {
        [Required]
        public DateTime TicketDate { get; set; }

        [Required]
        public short TicketCategory { get; set; }

        [Required]
        [StringLength(200)]
        public string? Subject { get; set; }

        [Required]
        [StringLength(5)]
        public string? Salutation { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required]
        [StringLength(50)]
        public string? Designation { get; set; }

        [Required]
        [StringLength(150)]
        public string? CompanyName { get; set; }

        [Required]
        [StringLength(5)]
        public string? MobileIsd { get; set; }

        [Required]
        [StringLength(10)]
        public string? MobileNumber { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string? EmailId { get; set; }

        [Required]
        [StringLength(500)]
        public string? TicketDescription { get; set; }

        [Required]
        [StringLength(20)]
        public string? ReferenceNumber { get; set; }

        [Required]
        public DateTime ReferenceDate { get; set; }

        public string? SupportDocument { get; set; }
        public byte Priority { get; set; }
        public byte Status { get; set; }
        public int PreparedBy { get; set; }
        public DateTime PreparedDateTime { get; set; }

        [Required]
        [Range(1, short.MaxValue)]
        public short BranchCode { get; set; }
    }
}