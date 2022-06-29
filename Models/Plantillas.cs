using System.ComponentModel.DataAnnotations;

namespace Sredespacho.Models
{
    public class Plantillas
    {
        [Key]
        public string? TipoRedespacho_id { get; set; }  
        public string? Tipo { get; set; }
        public string? Plantilla { get; set; }
        public DateTime FechaAdicion { get; set; }
    }
}
