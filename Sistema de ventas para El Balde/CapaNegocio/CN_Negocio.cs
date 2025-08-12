using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Negocio
    {
        private CD_Negocio objcd_Negocio = new CD_Negocio();
        public DatosNegocio ObtenerDatosNegocio()
        {
            return objcd_Negocio.ObtenerDatosNegocio();
        }

        public bool RegistrarDatos(DatosNegocio obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.NombreNegocio == "")
            {
                Mensaje += "Es necesario el nombre del negocio\n";
            }

            if (obj.NitDatoNegocio == "")
            {
                Mensaje += "Es necesario el NIT del negocio";
            }

            if (obj.ubicacionNegocio == "")
            {
                Mensaje += "Es necesaria la dirección del negocio\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Negocio.GuardarDatos(obj, out Mensaje);
            }
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            return objcd_Negocio.ObtenerLogo(out obtenido);

        }

        public bool ActualizarLogo(byte[] imagen,out string mensaje)
        {
            return objcd_Negocio.ActualizarLogo(imagen,out mensaje);

        }

    }
}
