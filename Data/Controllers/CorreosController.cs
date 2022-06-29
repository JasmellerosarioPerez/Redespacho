using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sredespacho.Models;

namespace Sredespacho.Data.Controllers
{
    public class CorreosController : Controller
    {
        private readonly CorreosDbContext _correosDbContext;

        public CorreosController(CorreosDbContext correosDbContext)
        {
            _correosDbContext = correosDbContext;
        }

        public async Task <List<Correos>> GetCorreos(string opcion)
        {
            if(opcion == "todos")
            {
                return await _correosDbContext.Correos.ToListAsync();
            }
            else
             { 
            return await _correosDbContext.Correos.Where(x => x.CC == true).ToListAsync();
            }
        }

        public async Task<Correos> AddCorreos(Correos correos)
        {
           await _correosDbContext.Correos.AddAsync(correos);
           await _correosDbContext.SaveChangesAsync();
            return correos;
        }

        public async Task<List<Correos>> ObtenerCCporID(string? id, bool CC)
        {
            return await _correosDbContext.Correos.Where(x => x.email == id && x.CC == CC).ToListAsync();
        }

        public async Task<bool> GuardarCorreos(Correos correos)
        {
            _correosDbContext.Correos.Add(correos);

            return await _correosDbContext.SaveChangesAsync() > 0;
        }

    }
}
