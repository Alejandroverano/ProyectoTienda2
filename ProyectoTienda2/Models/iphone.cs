using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoTienda.Models
{
    public class iphone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idiphone { get; set; }
        public string Nameiphone { get; set; }
        public double unitpriceiphone { get; set; }





    }
}
