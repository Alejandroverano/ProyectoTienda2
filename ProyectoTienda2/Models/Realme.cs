using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoTienda.Models
{
    public class Realme
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idrealme { get; set; }
        public string Namerealme { get; set; }
        public double unitpricerealme { get; set; }
    }
}
