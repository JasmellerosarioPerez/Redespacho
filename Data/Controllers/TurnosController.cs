using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sredespacho.Models;

namespace Sredespacho.Data.Controllers
{
    public class TurnosController : Controller
    {
        private readonly TurnosDbContext _turnosDbContext;

        public TurnosController(TurnosDbContext turnosDbContext)
        {
            _turnosDbContext = turnosDbContext;
        }

          public async Task<List<Turnos>> NombreIngeniero()
        {
            return await _turnosDbContext.Turnos.ToListAsync();


        }
    }
}
