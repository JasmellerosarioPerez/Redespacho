using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Sredespacho.Models
{
    public class RequerirRedespacho
    {
        [Key]
        public DateTime? Fecha { get; set; } = DateTime.Now;
        public string? Descripcion { get; set; }
        public string? Ingeniero { get; set; }
        
   
    }

    

  }
