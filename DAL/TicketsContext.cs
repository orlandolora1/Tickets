using Microsoft.EntityFrameworkCore;
using Tickets.Models;

namespace Tickets.DAL
{
    public class TicketsContext : DbContext
    {
        public TicketsContext(DbContextOptions<TicketsContext> Options)
            : base(Options) { }

        public DbSet<Sistemas> Sistemas { get; set; }
    }
}
