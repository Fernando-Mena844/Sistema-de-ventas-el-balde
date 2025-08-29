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
    public class CD_Compra
    {
        public int obtenerCorrelativo()
        {
            int idCorrelativoCompra = 0;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count (*) +1 from COMPRA");
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
        public bool RegistrarCompra(Compra obj, DataTable DetalleCompra, out string mensaje)
        {
            bool Respuesta= false;
            mensaje = string.Empty;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarCompra", oconexion);
                    cmd.Parameters.AddWithValue("IdUsuario",obj.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("IdProveedor",obj.oProveedor.IdProveedor);
                    cmd.Parameters.AddWithValue("TipoDocumento",obj.oTipoDocumentoCompra.NombreDocumentoCompra);
                    cmd.Parameters.AddWithValue("NumeroDocumento", obj.NumeroDocumentoCompra);
                    cmd.Parameters.AddWithValue("MontoTotal",obj.MontoTotal);
                    cmd.Parameters.AddWithValue("DetalleCompra", DetalleCompra);
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
                    mensaje= ex.Message;
                }

            }
            return Respuesta;
        }

        public Compra ObtenerCompra(string numero)
        {
            Compra obj = new Compra();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select C.IdCompra,");
                    query.AppendLine("U.nombreCompletoUsuario,");
                    query.AppendLine("P.documentoProveedor, P.razonSocialProveedor,");
                    query.AppendLine("TDC.nombreDocumentoCompra,");
                    query.AppendLine("C.NumeroDocumentoCompra, C.MontoTotal,convert(char(10), C.FechaRegistro,103)[FechaRegistro] ");
                    query.AppendLine("from COMPRA C");
                    query.AppendLine("inner join USUARIO U on U.IdUsuario = C.usuario_id");
                    query.AppendLine("inner join PROVEEDOR P on P.IdProveedor = P.IdProveedor");
                    query.AppendLine("inner join TipoDocumentoCompra TDC on TDC.idTipoDocumentoCompra = C.tipoDocumentoCompra_id");
                    query.AppendLine("where NumeroDocumentoCompra = @numero");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader datareader = cmd.ExecuteReader())
                    {
                        while (datareader.Read())
                        {
                            obj = new Compra()
                            {
                                IdCompra = Convert.ToInt32(datareader["IdCompra"]),
                                oUsuario = new Usuario() { NombreCompletoUsuario = datareader["nombreCompletoUsuario"].ToString() },
                                oProveedor = new Proveedor() { documentoProveedor = datareader["documentoProveedor"].ToString(), razonSocialProveedor = datareader["razonSocialProveedor"].ToString() },
                                oTipoDocumentoCompra = new TipoDocumentoCompra() { NombreDocumentoCompra = datareader["nombreDocumentoCompra"].ToString() },
                                NumeroDocumentoCompra = datareader["NumeroDocumentoCompra"].ToString(),
                                MontoTotal = Convert.ToDecimal(datareader["MontoTotal"]),
                                FechaRegistro = datareader["FechaRegistro"].ToString()
                            };

                        }

                    }


                }
                catch (Exception)
                {
                    obj = new Compra();
                }
            }

            return obj;
        }

        public List<DetalleCompra> ObtenerDetalleCompra(int idCompra)
        {
            List<DetalleCompra> oLista = new List<DetalleCompra>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select P.nombreProducto, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal from DETALLE_COMPRA dc");
                    query.AppendLine("inner join PRODUCTO P on P.IdProducto = dc.producto_id");
                    query.AppendLine("where dc.compra_id = @idcommpra");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idcompra", idCompra);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader datareader = cmd.ExecuteReader())
                    {
                        while (datareader.Read())
                        {
                            oLista.Add(new DetalleCompra()
                            {
                                oProducto = new Producto() { nombreProducto = datareader["nombreProducto"].ToString() },
                                PrecioCompra = Convert.ToDecimal(datareader["PrecioCompra"]),
                                Cantidad = Convert.ToInt32(datareader["Cantidad"]),
                                MontoTotal = Convert.ToDecimal(datareader["MontoTotal"])
                            });
                        }
                    }
                }
            }
            catch (Exception)
            {
                oLista = new List<DetalleCompra>();
            }
            return oLista;
        }
    }
}