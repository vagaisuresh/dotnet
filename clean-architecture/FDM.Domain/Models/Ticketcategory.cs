using System.ComponentModel.DataAnnotations.Schema;

namespace FDM.Domain.Models
{
    [Table("Ticketcategory")]
    public class Ticketcategory
    {
        public short Id { get; set; }
        public string? CategoryName { get; set; }
        public bool IsActive { get; set; }
        public bool IsRemoved { get; set; }
        public short BranchCode { get; set; }
    }
}