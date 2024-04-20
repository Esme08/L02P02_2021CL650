using Microsoft.EntityFrameworkCore;

namespace L02P02_2021CL650.Models
{
    public class LibreriaDbContext : DbContext
    {
        public LibreriaDbContext(DbContextOptions<LibreriaDbContext> options) : base(options)
        {
        }

        public DbSet<Clientes> Clientes { get; set; }
    }
}
