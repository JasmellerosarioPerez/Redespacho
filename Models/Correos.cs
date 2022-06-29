using System.ComponentModel.DataAnnotations;

namespace Sredespacho.Models
{
    public class Correos
    {
        [Key]
        public string email { get; set; }
        public string? Nombre { get; set; }
        public bool CC { get; set; }
        public bool? Nuevo { get; set; }

    }
}
