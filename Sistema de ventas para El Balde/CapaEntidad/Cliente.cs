using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class Cliente
    {
        public int IdCliente { get; set; }
        public string documentoCliente { get; set; }
        public string nombreCompletoCliente { get; set; }
        public string correoCliente { get; set; }
        public string telefonoCliente { get; set; }
        public bool Estado { get; set; }
        public string FechaCreacionCliente { get; set; }
        
       
    }
}
