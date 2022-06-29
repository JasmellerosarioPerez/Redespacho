using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sredespacho.Models;

namespace Sredespacho.Data.Controllers
{
    public class stp_localizarIngenierodTurnoController : Controller
    {
        private readonly TurnosDbContext _turnosDbContext;

        public stp_localizarIngenierodTurnoController (TurnosDbContext turnosDbContext)
        {
            _turnosDbContext = turnosDbContext;
        }

        public List<stp_localizarIngenierodTurno> GetTurno()
        {

            List <stp_localizarIngenierodTurno> turno = new List<stp_localizarIngenierodTurno>();
            turno = _turnosDbContext.Stp_LocalizarIngenierodTurnos.FromSqlRaw("exec Stp_LocalizarIngenierodTurno '20220510', 11,09").ToList();

            return turno;
        }
    }
}
