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
        //Esto me sirve para hacer indensaciones para cada uno de los campos de mi BD's
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Ticket>().HasIndex(t => t.Name).IsUnique();
        //}
    }
}
