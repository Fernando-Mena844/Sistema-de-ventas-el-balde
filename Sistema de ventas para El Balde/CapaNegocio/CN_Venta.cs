using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos; //Se llama la referencia CapaDatos que fue agregada al proyecto previamente
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Venta
    {
        private CD_Venta objCD_Venta = new CD_Venta();
        public int ObtenerCorrelativo()
        {
            return objCD_Venta.obtenerCorrelativo();
        }

        public bool Registrar(Venta obj, DataTable DetalleVenta, out string mensaje)
        {
            return objCD_Venta.RegistrarVenta(obj, DetalleVenta, out mensaje);
        }

        public bool RestarStock(int idProducto, int cantidad)
        {
            return objCD_Venta.RestarStock(idProducto, cantidad);
        }
        public bool SumarStock(int idProducto, int cantidad)
        {
            return objCD_Venta.SumarStock(idProducto, cantidad);
        }
    }
}
