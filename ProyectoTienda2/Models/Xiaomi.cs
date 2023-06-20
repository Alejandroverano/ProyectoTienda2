using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoTienda.Models
{
    public class Xiaomi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idxiaomi { get; set; }
        public string Namexiaomi { get; set; }
        public double unitpricexiaomi { get; set; }


    }
}
