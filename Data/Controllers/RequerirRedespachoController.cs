using Microsoft.AspNetCore.Mvc;
using Sredespacho.Models;
using Microsoft.EntityFrameworkCore;

namespace Sredespacho.Data.Controllers
{
    public class RequerirRedespachoController : Controller
    {
        private readonly RequerirRedespachoDbContext _requerirDbContext;

        public RequerirRedespachoController(RequerirRedespachoDbContext requerirRedespachoDbContext)
        {
            _requerirDbContext = requerirRedespachoDbContext;
        }

        public async Task<List<RequerirRedespacho>> GetDespachoList()
        {
            return await _requerirDbContext.RequerirRedespacho.OrderByDescending(r => r.Fecha).ToListAsync();
        }     
          
        public async Task<bool> SalvarRedespacho(RequerirRedespacho requerirRedespacho)
        {
            _requerirDbContext.RequerirRedespacho.Add(requerirRedespacho);

            return await _requerirDbContext.SaveChangesAsync() > 0;
        }


    }
}
