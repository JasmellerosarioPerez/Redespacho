using Microsoft.EntityFrameworkCore;
using Sredespacho.Models;

namespace Sredespacho.Data
{
    public class RequerirRedespachoDbContext : DbContext
    {
        public RequerirRedespachoDbContext(DbContextOptions<RequerirRedespachoDbContext> options) : base(options)
        {

        }

        public DbSet<RequerirRedespacho> RequerirRedespacho { get; set; }
    }
}
