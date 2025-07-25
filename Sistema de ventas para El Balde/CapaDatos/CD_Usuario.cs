using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad; //Se llama la referencia CapaEntidad que fue agregada al proyecto previamente
                   //CapaEntidad contiene las clases que representan las entidades del negocio, como Usuario, Producto, Cliente, etc.
                   //por lo tanto CapaEntidad se utilizara como referencia en todas las capas de la aplicación.

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.idUsuario, u.DocumentoUsuario, u.NombreCompletoUsuario, u.correoUsuario, u.Clave , u.Estado, r.idRol, r.descripcionRol from USUARIO u");
                    query.AppendLine("inner join rol r on r.IdRol = u.rol_id");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    //Se crea un objeto SqlCommand que representa una instrucción SQL que se va a ejecutar en la base de datos.

                    oconexion.Open();

                    using (SqlDataReader datareader = cmd.ExecuteReader())
                    {
                        while (datareader.Read())
                        {
                            lista.Add(new Usuario()

                            {
                                IdUsuario = Convert.ToInt32(datareader["IdUsuario"]),
                                DocumentoUsuario = datareader["DocumentoUsuario"].ToString(),
                                NombreCompletoUsuario = datareader["NombreCompletoUsuario"].ToString(),
                                correoUsuario = datareader["correoUsuario"].ToString(),
                                Clave = datareader["Clave"].ToString(),
                                Estado = Convert.ToBoolean(datareader["Estado"]),
                                oRol = new Rol() { IdRol = Convert.ToInt32(datareader["idRol"]), Descripcion = datareader["descripcionRol"].ToString() }
                            });


                        }

                    }


                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }


        public int Registrar(Usuario obj, out string mensaje)
        {
            int idUsuarioGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("Documento", obj.DocumentoUsuario);
                    cmd.Parameters.AddWithValue("nombreCompletoUsuario", obj.NombreCompletoUsuario);
                    cmd.Parameters.AddWithValue("correoUsuario", obj.correoUsuario);
                    cmd.Parameters.AddWithValue("Clave", obj.Clave);
                    cmd.Parameters.AddWithValue("rol_id", obj.oRol.IdRol);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);

                    cmd.Parameters.Add("IdUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                    idUsuarioGenerado = Convert.ToInt32(cmd.Parameters["IdUsuarioResultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idUsuarioGenerado = 0;
                mensaje = ex.Message;
            }

            return idUsuarioGenerado;
        }


        public bool Editar(Usuario obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.IdUsuario);
                    cmd.Parameters.AddWithValue("Documento", obj.DocumentoUsuario);
                    cmd.Parameters.AddWithValue("nombreCompletoUsuario", obj.NombreCompletoUsuario);
                    cmd.Parameters.AddWithValue("correoUsuario", obj.correoUsuario);
                    cmd.Parameters.AddWithValue("Clave", obj.Clave);
                    cmd.Parameters.AddWithValue("rol_id", obj.oRol.IdRol);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);

                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
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

        public bool Eliminar(Usuario obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.IdUsuario);

                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
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
