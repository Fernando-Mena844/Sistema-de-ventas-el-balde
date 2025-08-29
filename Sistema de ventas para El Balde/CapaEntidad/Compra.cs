using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public List<DetalleCompra> oDetalleCompra;

        public int IdCompra { get; set; }
        public Usuario oUsuario { get; set; }
        public TipoDocumentoCompra oTipoDocumentoCompra { get; set; }
        public Proveedor oProveedor { get; set; }
        public string NumeroDocumentoCompra { get; set; }
        public decimal MontoTotal { get; set; }
        public string FechaRegistro { get; set; }

    }
}
