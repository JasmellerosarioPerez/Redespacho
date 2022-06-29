using Microsoft.EntityFrameworkCore;
using Sredespacho.Models;

namespace Sredespacho.Data
{
    public class GenPlantillaReDespachoDbContext : DbContext
    {
        public GenPlantillaReDespachoDbContext(DbContextOptions<GenPlantillaReDespachoDbContext> options) : base(options)
        {

        }
        public DbSet<Plantillas> GenPlantillaReDespacho { get; set; }


    }
}
