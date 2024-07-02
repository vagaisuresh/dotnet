using FDM.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FDM.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Ticketcategory> Ticketcategories { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
