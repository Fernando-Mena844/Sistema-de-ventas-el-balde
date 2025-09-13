using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Venta
    {
        public int obtenerCorrelativo()
        {
            int idCorrelativoCompra = 0;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count (*) +1 from VENTA");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    //Se crea un objeto SqlCommand que representa una instrucción SQL que se va a ejecutar en la base de datos.

                    oconexion.Open();

                    idCorrelativoCompra = Convert.ToInt32(cmd.ExecuteScalar());

                }
                catch (Exception)
                {
                    idCorrelativoCompra = 0;
                }
                return idCorrelativoCompra;
            }
        }

        public bool RestarStock( int idProducto, int cantidad)
        {
            bool respuesta = true;
            using (SqlConnection oconexion =new SqlConnection((Conexion.cadena)))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    //Se crea la consulta SQL para actualizar el stock del producto
                    query.AppendLine("update PRODUCTO set Stock = Stock - @cantidad where IdProducto = @idProducto");
                    //Se crea un objeto SqlCommand que representa una instrucción SQL que se va a ejecutar en la base de datos.
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    //Se agregan los parámetros necesarios para la consulta SQL
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    //Se ejecuta la consulta SQL y se verifica si se afectó al menos una fila, en cuyo caso se considera que la operación fue exitosa.
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true: false;
                }
                catch (Exception)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public bool SumarStock(int idProducto, int cantidad)
        {
            bool respuesta = true;
            using (SqlConnection oconexion = new SqlConnection((Conexion.cadena)))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    //Se crea la consulta SQL para actualizar el stock del producto
                    query.AppendLine("update PRODUCTO set Stock = Stock + @cantidad where IdProducto = @idProducto");
                    //Se crea un objeto SqlCommand que representa una instrucción SQL que se va a ejecutar en la base de datos.
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    //Se agregan los parámetros necesarios para la consulta SQL
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    //Se ejecuta la consulta SQL y se verifica si se afectó al menos una fila, en cuyo caso se considera que la operación fue exitosa.
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public bool RegistrarVenta(Venta obj, DataTable DetalleVenta, out string mensaje)
        {
            bool Respuesta = false;
            mensaje = string.Empty;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarVenta", oconexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("IdCliente", obj.oCliente.IdCliente);
                    cmd.Parameters.AddWithValue("TipoDocumento", obj.oTipoDocumentoVenta.NombreTipoDocumentoVenta);
                    cmd.Parameters.AddWithValue("NumeroDocumento", obj.NumeroDocumentoVenta);
                    cmd.Parameters.AddWithValue("MontoPago", obj.MontoPago);
                    cmd.Parameters.AddWithValue("MontoCambio", obj.MontoCambio);
                    cmd.Parameters.AddWithValue("MontoTotal", obj.MontoTotal);
                    cmd.Parameters.AddWithValue("DetalleVenta", DetalleVenta);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {
                    Respuesta = false;
                    mensaje = ex.Message;
                }

            }
            return Respuesta;
        }

        public Venta ObtenerVenta (string numero)
        {
            Venta obj = new Venta();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select v.IdVenta, ");
                    query.AppendLine(" u.nombreCompletoUsuario, ");
                    query.AppendLine("c.documentoCliente, ");
                    query.AppendLine("c.nombreCompletoCliente, ");
                    query.AppendLine("tdv.nombreTipoDocumentoVenta, ");
                    query.AppendLine("v.NumeroDocumentoVenta, ");
                    query.AppendLine("v.MontoPago, v.MontoCambio, v.MontoTotal, ");
                    query.AppendLine("CONVERT(char(10), v.FechaRegistro, 103) AS [FechaRegistro] ");
                    query.AppendLine("from Venta v ");
                    query.AppendLine("inner join USUARIO u on u.IdUsuario=v.usuario_id ");
                    query.AppendLine("inner join CLIENTE c on c.IdCliente = v.cliente_id");
                    query.AppendLine("inner join TipoDocumentoVenta tdv on tdv.idTipoDocumentoVenta=v.tipoDocumentoVenta_id");
                    query.AppendLine("where v.NumeroDocumentoVenta = @numero");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Venta()
                            {
                                IdVenta = Convert.ToInt32(dr["IdVenta"]),
                                oUsuario = new Usuario() { NombreCompletoUsuario = dr["nombreCompletoUsuario"].ToString() },
                                oCliente = new Cliente()
                                {
                                    documentoCliente = dr["documentoCliente"].ToString(),
                                    nombreCompletoCliente = dr["nombreCompletoCliente"].ToString()
                                },
                                oTipoDocumentoVenta = new TipoDocumentoVenta() { NombreTipoDocumentoVenta = dr["nombreTipoDocumentoVenta"].ToString() },
                                NumeroDocumentoVenta = dr["NumeroDocumentoVenta"].ToString(),
                                MontoPago = Convert.ToDecimal(dr["MontoPago"]),
                                MontoCambio = Convert.ToDecimal(dr["MontoCambio"]),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"]),
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    obj = new Venta();
                }
            }

            return obj;
        }

        public List<DetalleVenta> ObtenerDetalle(string IdDetalleVenta)
        {
            List<DetalleVenta> oLista = new List<DetalleVenta>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.nombreProducto, p.PrecioVenta, dv.Cantidad, dv.SubTotal");
                    query.AppendLine("from DETALLE_VENTA dv");
                    query.AppendLine("inner join PRODUCTO p on p.IdProducto=dv.producto_id");
                    query.AppendLine("where dv.IdDetalleVenta = @IdVenta");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@IdVenta", IdDetalleVenta);
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new DetalleVenta()
                            {
                                IdDetalleVenta = Convert.ToInt32(dr["IdDetalleVenta"]),
                                oProducto = new Producto() { nombreProducto = dr["NombreProducto"].ToString() },
                                Cantidad = Convert.ToInt32(dr["Cantidad"]),
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                                SubTotal = Convert.ToDecimal(dr["SubTotal"])
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    oLista = new List<DetalleVenta>();
                }
            }
            return oLista;
        }

    }
}
