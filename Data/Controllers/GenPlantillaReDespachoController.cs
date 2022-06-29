using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sredespacho.Models;


namespace Sredespacho.Data.Controllers
{
    public class GenPlantillaReDespachoController : Controller
    {
        private readonly GenPlantillaReDespachoDbContext _genplantillaredespachoDbContext;

        public GenPlantillaReDespachoController(GenPlantillaReDespachoDbContext genPlantillaReDespachoDbContext)
        {
            _genplantillaredespachoDbContext = genPlantillaReDespachoDbContext;
        }

        public async Task <List<Plantillas>> GetPlantillasData()
        {
            return await _genplantillaredespachoDbContext.GenPlantillaReDespacho.ToListAsync();
        }
       
        public async Task<bool> UpdatePlantilla(Plantillas plantillas)
        {
            _genplantillaredespachoDbContext.Entry(plantillas).State = EntityState.Modified;
            return await _genplantillaredespachoDbContext.SaveChangesAsync() > 0;
        }
       
        public async Task<bool> SaveTipoPlantilla(Plantillas plantillas)
        {
            return await UpdatePlantilla(plantillas);
        }
    }
}
