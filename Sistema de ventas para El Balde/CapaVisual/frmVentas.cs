using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaVisual.Modales;
using CapaVisual.Utilidades;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace CapaVisual
{
    public partial class frmVentas: Form
    {
        private Usuario _Usuario;
        public frmVentas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void btnDescargarPDF_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarD_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarD_Click(object sender, EventArgs e)
        {

        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

            cbotipodocumento.Items.Add(new OpcionCombos() { Valor = "Boleta", Texto = "Boleta" });
            cbotipodocumento.Items.Add(new OpcionCombos() { Valor = "Factura", Texto = "Factura" });
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;


            txtFechaC.Text = DateTime.Now.ToString("dd/MM/yyyy");

            
            txtidproducto.Text = "0";

            txtPagaCon.Text = "";
            txtCambio.Text = "";
            txtTotalPagar.Text = "0";
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    
                    txtDocClienteRegistroVenta.Text = modal._Cliente.documentoCliente;
                    txtNombreClienteRegistroVenta.Text = modal._Cliente.nombreCompletoCliente;
                    txtIdCliente.Text= modal._Cliente.IdCliente.ToString();
                    txtcodproducto.Select();
                }
                else
                {
                    txtNumeroDocumentoCliente.Select();
                }
            }
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Producto.IdProducto.ToString();
                    txtcodproducto.Text = modal._Producto.codigoProducto;
                    txtproducto.Text = modal._Producto.nombreProducto;
                    txtprecio.Text = modal._Producto.PrecioVenta.ToString("0.00");
                    txtstock.Text = modal._Producto.Stock.ToString();
                    txtcantidad.Select();
                }
                else
                {
                    txtcodproducto.Select();
                }
            }
        }

        private void txtcodproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().Listar().Where(p => p.codigoProducto == txtcodproducto.Text && p.Estado == true).FirstOrDefault();


                if (oProducto != null)
                {
                    txtcodproducto.BackColor = System.Drawing.Color.Honeydew;
                    ;
                    txtidproducto.Text = oProducto.IdProducto.ToString();
                    txtproducto.Text = oProducto.nombreProducto;
                    txtprecio.Text = oProducto.PrecioVenta.ToString("0.00");
                    txtstock.Text = oProducto.Stock.ToString();
                    txtcantidad.Select();

                }
                else
                {
                    txtcodproducto.BackColor = System.Drawing.Color.MistyRose;
                    ;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                    txtprecio.Text = "";
                    txtstock.Text = "";
                    txtcantidad.Value = 1;
                }
            }

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;

            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtprecio.Text, out precio))
            {
                MessageBox.Show("Precio no valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecio.Select();
                return;
            }

            if (Convert.ToInt32(txtstock.Text) < Convert.ToInt32(txtcantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["IdProducto"].Value != null && fila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
                   //if (fila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe) {

                string mensaje = string.Empty;
                bool respuesta = new CN_Venta().RestarStock(
                    //Pasándele al método RestarStock los parámetros necesarios
                    Convert.ToInt32(txtidproducto.Text),
                    Convert.ToInt32(txtcantidad.Value.ToString())
                    );
                if (respuesta)
                {
                    dgvdata.Rows.Add(new object[] {
                        txtidproducto.Text,
                        txtproducto.Text,
                        txtprecio.Text.ToString(),
                        txtcantidad.Value.ToString(),
                        (txtcantidad.Value * precio).ToString("0.00")
                        });
                    calcularTotal();
                    limpiarProducto();
                }
            }



        }
        private void calcularTotal()
        {
            decimal total = 0;

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells["SubTotal"].Value != null &&
                        decimal.TryParse(row.Cells["SubTotal"].Value.ToString(), out decimal subtotal))
                    {
                        total += subtotal;
                    }
                }
            }

            txtTotalPagar.Text = total.ToString("0.00");
        }

        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtcodproducto.Text = "";
            txtproducto.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            txtcantidad.Value = 1;
            txtcodproducto.Select();
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.Check.Width;
                var h = Properties.Resources.Check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Delete, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {

                    bool respuesta = new CN_Venta().SumarStock(
                        Convert.ToInt32(dgvdata.Rows[indice].Cells["IdProducto"].Value.ToString()),
                        Convert.ToInt32(dgvdata.Rows[indice].Cells["cantidad"].Value.ToString())
                        );
                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(indice);
                        calcularTotal();
                    }
                }
            }
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }

                }
            }
        }

        private void txtPagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPagaCon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }

                }
            }
        }

        private void calcularcambio()
        {
            if (txtTotalPagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(txtTotalPagar.Text);

            if(txtPagaCon.Text.Trim() == "")
            {
                txtPagaCon.Text = "0";
            }

            if (decimal.TryParse(txtPagaCon.Text.Trim(), out pagacon))
            {
                if(pagacon < total)
                {
                    txtCambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtCambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private void txtPagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }

        private void txtBuscarD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBuscarD.Clear();
            }

        }

        private void limpiarRegistroVenta()
        {
            txtDocClienteRegistroVenta.Text = "";
            txtNombreClienteRegistroVenta.Text = "";
            txtcodproducto.Text = "";
            txtidproducto.Text = "0";
            txtproducto.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            txtcantidad.Value = 1;
            dgvdata.Rows.Clear();
            txtPagaCon.Text = "";
            txtCambio.Text = "";
            txtTotalPagar.Text = "0";
        }

        private void BtnCrearVenta_Click(object sender, EventArgs e)
        {
            if (txtDocClienteRegistroVenta.Text == "")
            {
                MessageBox.Show("Debe seleccionar un cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(txtNombreClienteRegistroVenta.Text == "")
            {
                MessageBox.Show("Debe seleccionar un cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe agregar productos a la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_venta = new DataTable();
            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("subTotal", typeof(decimal));

            foreach (DataGridViewRow row in dgvdata.Rows)
            {

                detalle_venta.Rows.Add(new object[]
                {
                    Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()),
                    Convert.ToDecimal(row.Cells["PrecioVenta"].Value.ToString()),
                    Convert.ToInt32(row.Cells["cantidad"].Value.ToString()),
                    Convert.ToDecimal(row.Cells["subTotal"].Value.ToString())
                });
            }

            int idCorrelativo = new CN_Venta().ObtenerCorrelativo();
            string numeroDocumento = idCorrelativo.ToString().PadLeft(5, '0');
            calcularcambio();

            Venta oVenta = new Venta()
            {
                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                oCliente = new Cliente() { IdCliente = Convert.ToInt32(txtIdCliente.Text) },
                oTipoDocumentoVenta = new TipoDocumentoVenta() { NombreTipoDocumentoVenta = ((OpcionCombos)cbotipodocumento.SelectedItem).Texto },
                NumeroDocumentoVenta = numeroDocumento,
                MontoPago = Convert.ToDecimal(txtPagaCon.Text),
                MontoCambio = Convert.ToDecimal(txtCambio.Text),
                MontoTotal = Convert.ToDecimal(txtTotalPagar.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().Registrar(oVenta, detalle_venta, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Número de compra: " + numeroDocumento + "\n¿Desea copiarlo al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText(numeroDocumento);
                    limpiarRegistroVenta();
                    calcularTotal();
                }
            }
            else 
            {                 
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscarD_Click_1(object sender, EventArgs e)
        {
            Venta oVenta = new CN_Venta().ObtenerVenta(txtBuscarD.Text.Trim());
            if (oVenta.IdVenta != 0 )
            {
                txtFechaD.Text = oVenta.FechaRegistro;
                txtTipoDocumentoVentaDetalle.Text = oVenta.oTipoDocumentoVenta.NombreTipoDocumentoVenta;
                txtIdClienteDetalle.Text = oVenta.oCliente.IdCliente.ToString();
                txtNumeroDocumentoCliente.Text = oVenta.oCliente.documentoCliente;
                txtNombreClienteDocumentoVenta.Text = oVenta.oCliente.nombreCompletoCliente;

                dgvDetalleVenta.Rows.Clear();

                if (oVenta.oDetalleVenta != null && oVenta.oDetalleVenta.Count > 0)
                {
                    foreach (DetalleVenta dv in oVenta.oDetalleVenta)
                    {
                        dgvDetalleVenta.Rows.Add(

                            dv.oProducto.nombreProducto,
                            dv.PrecioVenta,
                            dv.Cantidad,
                            dv.SubTotal
                        );
                    }

                }

                txtMontoTotalD.Text = oVenta.MontoTotal.ToString("0.00");
                txtPagoDetalle.Text = oVenta.MontoPago.ToString("0.00");
                txtCambioDetalle.Text = oVenta.MontoCambio.ToString("0.00");
            }
        }

        private void btnBorrarD_Click_1(object sender, EventArgs e)
        {
            txtBuscarD.Text=string.Empty;
            txtFechaD.Text = string.Empty;
            txtTipoDocumentoVentaDetalle.Text = string.Empty;
            txtIdClienteDetalle.Text = string.Empty;
            txtNumeroDocumentoCliente.Text = string.Empty;
            txtNombreClienteDocumentoVenta.Text = string.Empty;
            dgvDetalleVenta.Rows.Clear();
            txtMontoTotalD.Text = string.Empty;
            txtBuscarD.Select();
        }

        private void btnDescargarPDF_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeroDocumentoCliente.Text))
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                string numeroDocumento = string.Format("{0:00000}", int.Parse(txtBuscarD.Text));
                string Texto_Html = Properties.Resources.PlantillaVenta.ToString();
                DatosNegocio odatos = new CN_Negocio().ObtenerDatosNegocio();

                Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.NombreNegocio.ToUpper());
                Texto_Html = Texto_Html.Replace("@docnegocio", odatos.NitDatoNegocio);
                Texto_Html = Texto_Html.Replace("@direccionnegocio", odatos.ubicacionNegocio);

                Texto_Html = Texto_Html.Replace("@tipodocumento", txtTipoDocumentoVentaDetalle.Text);
                Texto_Html = Texto_Html.Replace("@numerodocumento", numeroDocumento);

                Texto_Html = Texto_Html.Replace("@docCliente", txtNumeroDocumentoCliente.Text);
                Texto_Html = Texto_Html.Replace("@nombreCliente", txtNombreClienteDocumentoVenta.Text);
                Texto_Html = Texto_Html.Replace("@fecharegistro", txtFechaD.Text);

                // Si tienes el usuario que registró la compra, reemplaza aquí
                frmInicio frmAbierto = Application.OpenForms["frmInicio"] as frmInicio;

                if (frmAbierto != null)
                {
                    Texto_Html = Texto_Html.Replace("@usuarioregistro", frmAbierto.lblUsuario.Text);
                }

                string filas = string.Empty;
                foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string producto = row.Cells[0].Value?.ToString() ?? "";
                        string precioVenta = row.Cells[1].Value?.ToString() ?? "0.00";
                        string cantidad = row.Cells[2].Value?.ToString() ?? "0";
                        string subTotal = row.Cells[3].Value?.ToString() ?? "0.00";

                        filas += "<tr>";
                        filas += $"<td style='text-align: center;'>{producto}</td>";
                        filas += $"<td style='text-align: right;'>{precioVenta}</td>";
                        filas += $"<td style='text-align: right;'>{cantidad}</td>";
                        filas += $"<td style='text-align: right;'>{subTotal}</td>";
                        filas += "</tr>";
                    }
                }
                Texto_Html = Texto_Html.Replace("@filas", filas);
                Texto_Html = Texto_Html.Replace("@montototal", txtMontoTotalD.Text);
                Texto_Html = Texto_Html.Replace("@pagocon", txtPagoDetalle.Text);
                Texto_Html = Texto_Html.Replace("@cambio", txtCambioDetalle.Text);

                SaveFileDialog savefile = new SaveFileDialog
                {
                    FileName = $"Venta {numeroDocumento}.pdf",
                    Filter = "PDF Files|*.pdf"
                };

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        bool obtenido = true;
                        byte[] byteImage = new CN_Negocio().ObtenerLogo(out obtenido);

                        if (obtenido && byteImage != null && byteImage.Length > 0)
                        {
                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                            img.ScaleToFit(60, 60);
                            img.Alignment = iTextSharp.text.Image.UNDERLYING;
                            img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                            pdfDoc.Add(img);
                        }

                        using (StringReader sr = new StringReader(Texto_Html))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                    }

                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnBorrarD_Click_1(sender, e);
        }
    }
}
