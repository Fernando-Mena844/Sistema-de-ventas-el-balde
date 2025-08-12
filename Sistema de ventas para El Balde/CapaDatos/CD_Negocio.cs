using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Negocio
    {

        public DatosNegocio ObtenerDatosNegocio()
        {
            DatosNegocio datosNegocio = new DatosNegocio();
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.cadena))
                {
                    connection.Open();
                    string query = "select idNegocio, nombreNegocio, NIT_DatoNegocio, ubicacionNegocio from DatosNegocio where idNegocio=1";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader datareader = cmd.ExecuteReader())
                    {
                        while (datareader.Read())
                        {
                            datosNegocio= new DatosNegocio
                            {
                                IdNegocio = Convert.ToInt32(datareader["idNegocio"]),
                                NombreNegocio = datareader["nombreNegocio"].ToString(),
                                NitDatoNegocio = datareader["NIT_DatoNegocio"].ToString(),
                                ubicacionNegocio = datareader["ubicacionNegocio"].ToString()
                            };
                        }
                    }
                }
            }
            catch
            {
                datosNegocio = new DatosNegocio();
            }

            return datosNegocio;
        }

        public bool GuardarDatos(DatosNegocio objeto, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.cadena))
                {
                    connection.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update DatosNegocio set nombreNegocio = @NombreNegocio,");
                    query.AppendLine("NIT_DatoNegocio=@NitDatoNegocio,");
                    query.AppendLine("ubicacionNegocio=@ubicacionNegocio");
                    query.AppendLine("where idNegocio=1;");
                    SqlCommand cmd = new SqlCommand(query.ToString(), connection);
                    cmd.Parameters.AddWithValue("@NombreNegocio", objeto.NombreNegocio);
                    cmd.Parameters.AddWithValue("@NitDatoNegocio", objeto.NitDatoNegocio);
                    cmd.Parameters.AddWithValue("@ubicacionNegocio", objeto.ubicacionNegocio);
                    cmd.CommandType = CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo actualizar los datos del negocio";
                        respuesta = false;
                    }

                    }
            }
            catch (Exception ex)
            {
                respuesta=false;
                mensaje=ex.Message;
            }
            return respuesta;
        }

        public byte [] ObtenerLogo (out bool obtenido)
        {
            obtenido = true;
            byte[] LogoBytes = new byte[0];

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.cadena))
                {
                    connection.Open();
                    string query = "select logoNegocio from DatosNegocio where idNegocio=1";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader datareader = cmd.ExecuteReader())
                    {
                        while (datareader.Read())
                        {
                            LogoBytes = (byte[])datareader["logoNegocio"];
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                obtenido= false;
                LogoBytes = new byte[0];
            }
            return LogoBytes;
        }

        public bool ActualizarLogo(byte[] image, out string mensaje )
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.cadena))
                {
                    connection.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update DatosNegocio set logoNegocio = @image");
                    query.AppendLine("where idNegocio=1;");
                    SqlCommand cmd = new SqlCommand(query.ToString(), connection);
                    cmd.Parameters.AddWithValue("@image", image);
                    cmd.CommandType = CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo actualizar el logo";
                        respuesta = false;
                    }

                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }
            return respuesta;

        }
    }
}
