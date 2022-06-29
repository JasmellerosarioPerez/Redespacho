using System.ComponentModel.DataAnnotations;

namespace Sredespacho.Models
{
    public class Turnos
    {
        [Key]
        public decimal KeyRecord { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public string? Ingeniero  { get; set; }
        public string? Operadorf4 { get; set; }
        public string? Operadorf6 { get; set; }
        public string? Militares { get; set; }
        public string? Militares2 { get; set; }
        public bool Entregado { get; set; }
        public DateTime fechaAdicion { get; set; }
        public string? AnalistaOp { get; set; }


    }
}
