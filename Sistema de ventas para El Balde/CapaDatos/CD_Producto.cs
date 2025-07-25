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
    public class CD_Producto
    {
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT P.IdProducto, P.codigoProducto, P.nombreProducto, P.descripcionProducto,");
                    query.AppendLine("c.IdCategoria, c.descripcionCategoria as descripcionCategoria,"); // aquí se usa directamente la columna
                    query.AppendLine("pr.IdProveedor, pr.razonSocialProveedor,");
                    query.AppendLine("P.Stock, P.PrecioCompra, P.PrecioVenta, P.Estado");
                    query.AppendLine("FROM PRODUCTO P");
                    query.AppendLine("INNER JOIN CATEGORIA c ON c.IdCategoria = P.categoria_id");
                    query.AppendLine("INNER JOIN PROVEEDOR pr ON pr.IdProveedor = P.proveedor_id");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    //Se crea un objeto SqlCommand que representa una instrucción SQL que se va a ejecutar en la base de datos.

                    oconexion.Open();

                    using (SqlDataReader datareader = cmd.ExecuteReader())
                    {
                        while (datareader.Read())
                        {
                            lista.Add(new Producto()

                            {
                                IdProducto = Convert.ToInt32(datareader["IdProducto"]),
                                codigoProducto = datareader["codigoProducto"].ToString(),
                                nombreProducto = datareader["nombreProducto"].ToString(),
                                descripcionProducto = datareader["descripcionProducto"].ToString(),
                                oCategoria = new Categoria() {IdCategoria= Convert.ToInt32(datareader["IdCategoria"]),descripcionCategoria= datareader["descripcionCategoria"].ToString()},
                                oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(datareader["IdProveedor"]), razonSocialProveedor = datareader["razonSocialProveedor"].ToString() },
                                Stock = Convert.ToInt32(datareader["Stock"]),
                                PrecioCompra = Convert.ToDecimal(datareader["PrecioCompra"]),
                                PrecioVenta = Convert.ToDecimal(datareader["PrecioVenta"]),
                                Estado = Convert.ToBoolean(datareader["Estado"]),
                            });


                        }

                    }


                }
                catch (Exception)
                {
                    lista = new List<Producto>();
                }
            }
            return lista;
        }


        public int Registrar(Producto obj, out string mensaje)
        {
            int idProductoGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_CrearProducto", oconexion);
                    cmd.Parameters.AddWithValue("CodigoProducto", obj.codigoProducto);
                    cmd.Parameters.AddWithValue("nombreProducto", obj.nombreProducto);
                    cmd.Parameters.AddWithValue("descripcionProducto", obj.descripcionProducto);
                    cmd.Parameters.AddWithValue("IdCategoria", obj.oCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("IdProveedor", obj.oProveedor.IdProveedor);
                    cmd.Parameters.AddWithValue("Stock", obj.Stock);
                    cmd.Parameters.AddWithValue("PrecioCompra", obj.PrecioCompra);
                    cmd.Parameters.AddWithValue("PrecioVenta", obj.PrecioVenta);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);

                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                    idProductoGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idProductoGenerado = 0;
                mensaje = ex.Message;
            }

            return idProductoGenerado;
        }


        public bool Editar(Producto obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ModificarProducto", oconexion);
                    cmd.Parameters.AddWithValue("IdProducto", obj.IdProducto);
                    cmd.Parameters.AddWithValue("CodigoProducto", obj.codigoProducto);
                    cmd.Parameters.AddWithValue("nombreProducto", obj.nombreProducto);
                    cmd.Parameters.AddWithValue("descripcionProducto", obj.descripcionProducto);
                    cmd.Parameters.AddWithValue("IdCategoria", obj.oCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("IdProveedor", obj.oProveedor.IdProveedor);
                    cmd.Parameters.AddWithValue("Stock", obj.Stock);
                    cmd.Parameters.AddWithValue("PrecioCompra", obj.PrecioCompra);
                    cmd.Parameters.AddWithValue("PrecioVenta", obj.PrecioVenta);
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

        public bool Eliminar(Producto obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarProducto", oconexion);
                    cmd.Parameters.AddWithValue("IdProducto", obj.IdProducto);

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
