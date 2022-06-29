using System.ComponentModel.DataAnnotations;

namespace Sredespacho.Models
{
    public class Personal
    {
        [Key]
        public decimal Ingeniero_id { get; set; }
        public decimal Usuario_id   { get; set; }
        public string? Nombre  { get; set; }
        public decimal Funcion_Id { get; set; }
        public string? Siglas { get; set; }
        public int Grupo { get; set; }
        public string? Estatus { get; set; }
        public DateTime FechaAdicion { get; set; }
        public string? Abreviatura { get; set; }
        public string? LaFirma { get; set; }
    }
}
