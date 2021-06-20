using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCrud.Clases
{
    public class Iglesias
    {
        [Key]
        public int PKCodigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public DateTime Fecha_Fundacion { get; set; }

    }
}
