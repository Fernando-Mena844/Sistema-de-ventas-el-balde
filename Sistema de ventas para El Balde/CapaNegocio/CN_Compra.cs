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
    public class CN_Compra
    {
        private CD_Compra objcd_compra = new CD_Compra();
        public int ObtenerCorrelativo()
        {
            return objcd_compra.obtenerCorrelativo();
        }

        public bool Registrar(Compra obj, DataTable DetalleCompra, out string mensaje)
        {
            return objcd_compra.RegistrarCompra(obj, DetalleCompra, out mensaje);
        }

        public Compra ObtenerCompra(string numero)
        {
            Compra oCompra = objcd_compra.ObtenerCompra(numero);

            if (oCompra.IdCompra != 0)
            {
                List<DetalleCompra> oDetalleCompra = objcd_compra.ObtenerDetalleCompra(oCompra.IdCompra);

                oCompra.oDetalleCompra = oDetalleCompra;
            }
            return oCompra;
        }
        
    }
}
