using Microsoft.EntityFrameworkCore;

namespace API_NBA.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Jugador> Jugador { get; set; }
        public DbSet<Equipo> Equipo { get; set; }
    }
}
