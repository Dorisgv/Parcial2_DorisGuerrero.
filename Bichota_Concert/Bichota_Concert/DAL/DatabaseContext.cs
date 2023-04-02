using Bichota_Concert.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bichota_Concert.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
