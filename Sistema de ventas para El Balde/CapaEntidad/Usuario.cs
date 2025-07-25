using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string DocumentoUsuario { get; set; }
        public string NombreCompletoUsuario { get; set; }
        public string correoUsuario { get; set; }
        public string Clave { get; set; }
        public Rol oRol { get; set; }
        public bool Estado { get; set; }
        public string FechaCreacionUsuario { get; set; }



    }
}
