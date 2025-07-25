using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Cliente
    {
        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdCliente,documentoCliente,nombreCompletoCliente,correoCliente,telefonoCliente,Estado from CLIENTE");


                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    //Se crea un objeto SqlCommand que representa una instrucción SQL que se va a ejecutar en la base de datos.

                    oconexion.Open();

                    using (SqlDataReader datareader = cmd.ExecuteReader())
                    {
                        while (datareader.Read())
                        {
                            lista.Add(new Cliente()

                            {
                                IdCliente = Convert.ToInt32(datareader["IdCliente"]),
                                documentoCliente = datareader["documentoCliente"].ToString(),
                                nombreCompletoCliente = datareader["nombreCompletoCliente"].ToString(),
                                correoCliente = datareader["correoCliente"].ToString(),
                                Estado = Convert.ToBoolean(datareader["Estado"]),

                            });


                        }

                    }


                }
                catch (Exception)
                {
                    lista = new List<Cliente>();
                }
            }
            return lista;
        }


        public int Registrar(Cliente obj, out string mensaje)
        {
            int idClienteGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarCliente", oconexion);
                    cmd.Parameters.AddWithValue("Documento", obj.documentoCliente);
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.nombreCompletoCliente);
                    cmd.Parameters.AddWithValue("Correo", obj.correoCliente);
                    cmd.Parameters.AddWithValue("telefono", obj.telefonoCliente);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idClienteGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idClienteGenerado = 0;
                mensaje = ex.Message;
            }

            return idClienteGenerado;
        }


        public bool Editar(Cliente obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_ModificarCliente", oconexion);
                    cmd.Parameters.AddWithValue("IdCliente", obj.IdCliente);
                    cmd.Parameters.AddWithValue("Documento", obj.documentoCliente);
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.nombreCompletoCliente);
                    cmd.Parameters.AddWithValue("Correo", obj.correoCliente);
                    cmd.Parameters.AddWithValue("telefono", obj.telefonoCliente);
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

        public bool Eliminar(Cliente obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand(" delete from Cliente where IdCliente = @id", oconexion);
                    cmd.Parameters.AddWithValue("@id", obj.IdCliente);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
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
