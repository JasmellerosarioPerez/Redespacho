using Microsoft.EntityFrameworkCore;
using Sredespacho.Models;

namespace Sredespacho.Data
{
    public class TurnosDbContext : DbContext
    {
        public TurnosDbContext(DbContextOptions<TurnosDbContext> options) : base(options)
        {

        }

        public virtual DbSet<stp_localizarIngenierodTurno> Stp_LocalizarIngenierodTurnos { get; set; }
        public DbSet<Turnos> Turnos { get; set; }

        public DbSet<Personal> Personal { get; set; }
    }
}
