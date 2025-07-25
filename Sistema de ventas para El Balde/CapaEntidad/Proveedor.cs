using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedor
    {

        public int IdProveedor { get; set; }
        public string documentoProveedor { get; set; }
        public string razonSocialProveedor { get; set; }
        public string correoProveedor { get; set; }
        public string telefonoProveedor { get; set; }
        public bool Estado { get; set; }
        public string FechaCreacionProveedor { get; set; }
    }
}
