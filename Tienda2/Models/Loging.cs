using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda2.Models
{
    public class Loging
    {

        [Key]
        public string usuario { get; set; }
        public string contraseña { get; set; }




    }
}
