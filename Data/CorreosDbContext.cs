using Microsoft.EntityFrameworkCore;
using Sredespacho.Models;

namespace Sredespacho.Data
{
    public class CorreosDbContext : DbContext
    {
        public CorreosDbContext(DbContextOptions<CorreosDbContext> options) : base(options)
        {

        }
        public DbSet<Correos> Correos { get; set; }
    }
}
