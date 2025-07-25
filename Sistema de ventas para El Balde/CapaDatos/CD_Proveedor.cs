using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Proveedor
    {
        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new List<Proveedor>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdProveedor, documentoProveedor, razonSocialProveedor, correoProveedor, telefonoProveedor, Estado from PROVEEDOR ");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    //Se crea un objeto SqlCommand que representa una instrucción SQL que se va a ejecutar en la base de datos.

                    oconexion.Open();

                    using (SqlDataReader datareader = cmd.ExecuteReader())
                    {
                        while (datareader.Read())
                        {
                            lista.Add(new Proveedor()

                            {
                                IdProveedor = Convert.ToInt32(datareader["IdProveedor"]),
                                documentoProveedor = datareader["documentoProveedor"].ToString(),
                                razonSocialProveedor = datareader["razonSocialProveedor"].ToString(),
                                correoProveedor = datareader["correoProveedor"].ToString(),
                                telefonoProveedor = datareader["telefonoProveedor"].ToString(),
                                Estado = Convert.ToBoolean(datareader["Estado"])
                            });


                        }

                    }


                }
                catch (Exception ex)
                {
                    lista = new List<Proveedor>();
                }
            }
            return lista;
        }


        public int Registrar(Proveedor obj, out string mensaje)
        {
            int idProveedorGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarProveedor", oconexion);
                    cmd.Parameters.AddWithValue("Documento", obj.documentoProveedor);
                    cmd.Parameters.AddWithValue("RazonSocial", obj.razonSocialProveedor);
                    cmd.Parameters.AddWithValue("Correo", obj.correoProveedor);
                    cmd.Parameters.AddWithValue("Telefono", obj.telefonoProveedor);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);

                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                    idProveedorGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idProveedorGenerado = 0;
                mensaje = ex.Message;
            }

            return idProveedorGenerado;
        }


        public bool Editar(Proveedor obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ModificarProveedor", oconexion);
                    cmd.Parameters.AddWithValue("idProveedor", obj.IdProveedor);
                    cmd.Parameters.AddWithValue("Documento", obj.documentoProveedor);
                    cmd.Parameters.AddWithValue("RazonSocial", obj.razonSocialProveedor);
                    cmd.Parameters.AddWithValue("Correo", obj.correoProveedor);
                    cmd.Parameters.AddWithValue("Telefono", obj.telefonoProveedor);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);

                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }

            return respuesta;
        }

        public bool Eliminar(Proveedor obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarProveedor", oconexion);
                    cmd.Parameters.AddWithValue("IdProveedor", obj.IdProveedor);

                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
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
