using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
     public class Producto
    {
        public int IdProducto { get; set; }
        public string codigoProducto { get; set; }
        public string nombreProducto { get; set; }
        public string descripcionProducto { get; set; }
        public Categoria oCategoria { get; set; }
        public Proveedor oProveedor { get; set; }
        public int Stock { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistroProducto { get; set; }

    }
}
