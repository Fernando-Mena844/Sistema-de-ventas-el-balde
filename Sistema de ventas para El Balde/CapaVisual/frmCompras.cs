using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaVisual.Modales;
using CapaVisual.Utilidades;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace CapaVisual
{
    public partial class frmCompras : Form
    {
        private Usuario _Usuario;

        public frmCompras(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {



            cbotipodocumento.Items.Add(new OpcionCombos() { Valor = "Boleta", Texto = "Boleta" });
            cbotipodocumento.Items.Add(new OpcionCombos() { Valor = "Factura", Texto = "Factura" });
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;


            txtFechaC.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtidproveedor.Text = "0";
            txtidproducto.Text = "0";



        }

        private void btnBuscarC_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNuevodoc_TextChanged(object sender, EventArgs e)
        {

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarprov_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproveedor.Text = modal._Proveedor.IdProveedor.ToString();
                    txtdocproveedor.Text = modal._Proveedor.documentoProveedor;
                    txtRazonsocial.Text = modal._Proveedor.razonSocialProveedor;

                }
                else
                {
                    txtdocproveedor.Select();
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
                    txtpreciocompra.Text=modal._Producto.PrecioCompra.ToString();
                    txtprecioventa.Text=modal._Producto.PrecioVenta.ToString();
                    txtpreciocompra.Select();
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
                    txtpreciocompra.Select();

                }
                else
                {
                    txtcodproducto.BackColor = System.Drawing.Color.MistyRose;
                    ;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                }
            }

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            bool producto_existe = false;

            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtpreciocompra.Text, out preciocompra))
            {
                MessageBox.Show("Precio de compra - Formato de moneda no es correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpreciocompra.Select();
                return;
            }

            if (!decimal.TryParse(txtprecioventa.Text, out precioventa))
            {
                MessageBox.Show("Precio de venta - Formato de moneda no es correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecioventa.Select();
                return;
            }

            foreach (DataGridViewRow fila in dgvdata.Rows)
            {

                if (fila.Cells["IdProducto"].Value != null &&
                int.TryParse(fila.Cells["IdProducto"].Value.ToString(), out int idFila) &&
                int.TryParse(txtidproducto.Text, out int idTexto) &&
                idFila == idTexto)
                {
                    producto_existe = true;
                    break;
                }

            }

            if (!producto_existe)
            {
                dgvdata.Rows.Add(new object[]
                 {
                    txtidproducto.Text,
                    txtproducto.Text,
                    preciocompra.ToString("0.00"),
                    precioventa.ToString("0.00"),
                    txtcantidad.Value.ToString(),
                    (txtcantidad.Value * preciocompra).ToString("0.00"),
                 });
                calcularTotal();
                LimpiarProductos();
                txtcodproducto.Select();
            }



        }


        private void LimpiarProductos()
        {
            txtidproducto.Text = "0";
            txtcodproducto.Text = "";
            txtcodproducto.BackColor = System.Drawing.Color.White;
            ;
            txtproducto.Text = "";
            txtpreciocompra.Text = "0.00";
            txtprecioventa.Text = "0.00";
            txtcantidad.Value = 1;
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

            txttotalapagar.Text = total.ToString("0.00");
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.Check.Width;
                var h = Properties.Resources.Check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Check, new Rectangle(x, y, w, h));
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
                    dgvdata.Rows.RemoveAt(indice);
                    calcularTotal();



                }
            }
        }

        private void txtpreciocompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpreciocompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void txtprecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecioventa.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void btnRegistrarC_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un proveedor
            if (Convert.ToInt32(txtidproveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validar que se haya agregado al menos un producto
            if (dgvdata.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Crear el DataTable para el detalle de la compra
            DataTable detalle_compra = new DataTable();
            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("MontoTotal", typeof(decimal));

            // Llenar el DataTable con los datos de dgvdata
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                if (row.Cells["IdProducto"].Value != null) // Asegurarse de que la celda no sea nula
                {
                    detalle_compra.Rows.Add
                    (
                        new object[]
                        {
                    Convert.ToInt32(row.Cells["IdProducto"].Value),
                    Convert.ToDecimal(row.Cells["PrecioCompra"].Value),
                    Convert.ToDecimal(row.Cells["PrecioVenta"].Value),
                    Convert.ToInt32(row.Cells["Cantidad"].Value),
                    Convert.ToDecimal(row.Cells["SubTotal"].Value)
                        }
                    );
                }
            }
        
            // Obtener el correlativo
            int idCorrelativo = new CN_Compra().ObtenerCorrelativo();
            if (idCorrelativo == 0)
            {
                MessageBox.Show("Error al obtener el correlativo de la compra.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generar el número de documento
            string numeroDocumento = string.Format("{0:00000}", idCorrelativo);

            // Crear el objeto Compra
            Compra oCompra = new Compra()
            {
                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(txtidproveedor.Text) },
                oTipoDocumentoCompra = new TipoDocumentoCompra { NombreDocumentoCompra = ((OpcionCombos)cbotipodocumento.SelectedItem).Texto },
                NumeroDocumentoCompra = numeroDocumento,
                MontoTotal = Convert.ToDecimal(txttotalapagar.Text),
            };

            // Registrar la compra
            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(oCompra, detalle_compra, out mensaje);
            if (respuesta)
            {
                var result = MessageBox.Show("Número de compra: " + numeroDocumento + "\n¿Desea copiarlo al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText(numeroDocumento);
                }
                // Limpiar los campos después de registrar
                dgvdata.Rows.Clear();
                calcularTotal();
                txtidproveedor.Text = "0";
                txtdocproveedor.Text = "";
                txtRazonsocial.Text = "";
                txtFechaC.Text = DateTime.Now.ToString("dd/MM/yyyy");
                cbotipodocumento.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarD_Click(object sender, EventArgs e)
        {
            Compra oCompra = new CN_Compra().ObtenerCompra(txtBuscarD.Text);
            if (oCompra.IdCompra != 0)
            {
                txtNumeroDocumentoProveedorD.Text = oCompra.oProveedor.documentoProveedor;
                txtFechaD.Text = oCompra.FechaRegistro;
                cmbTipoDocumentoD.SelectedIndex = cmbTipoDocumentoD.FindStringExact(oCompra.oTipoDocumentoCompra.NombreDocumentoCompra);
                txtRazonSocialD.Text = oCompra.oProveedor.razonSocialProveedor;
                dgvDetalleCompra.Rows.Clear();
                if (oCompra.oDetalleCompra != null && oCompra.oDetalleCompra.Count > 0)
                {
                    foreach (DetalleCompra dc in oCompra.oDetalleCompra)
                    {
                        dgvDetalleCompra.Rows.Add(
                            dc.oProducto.nombreProducto,
                            dc.PrecioCompra.ToString("0.00"),
                            dc.Cantidad.ToString(),
                            dc.MontoTotal.ToString("0.00")
                        );
                    }
                }
                txtMontoTotalD.Text = oCompra.MontoTotal.ToString("0.00");
            }
            else
            {
                MessageBox.Show("No se encontró la compra con ese número de documento.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBorrarD_Click(object sender, EventArgs e)
        {
            txtFechaD.Text = "";
            txtNumeroDocumentoProveedorD.Text = "";
            cmbTipoDocumentoD.SelectedIndex = -1;
            txtRazonSocialD.Text = "";

            dgvDetalleCompra.Rows.Clear();
            txtMontoTotalD.Text = "0.00";
        }

        private void btnDescargarPDF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRazonSocialD.Text))
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                string numeroDocumento = string.Format("{0:00000}", int.Parse(txtBuscarD.Text));
                string Texto_Html = Properties.Resources.PlantillaCompra.ToString();
                DatosNegocio odatos = new CN_Negocio().ObtenerDatosNegocio();

                Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.NombreNegocio.ToUpper());
                Texto_Html = Texto_Html.Replace("@docnegocio", odatos.NitDatoNegocio);
                Texto_Html = Texto_Html.Replace("@direccionnegocio", odatos.ubicacionNegocio);

                Texto_Html = Texto_Html.Replace("@tipodocumento", cmbTipoDocumentoD.Text);
                Texto_Html = Texto_Html.Replace("@numerodocumento", numeroDocumento);

                Texto_Html = Texto_Html.Replace("@docproveedor", txtNumeroDocumentoProveedorD.Text);
                Texto_Html = Texto_Html.Replace("@nombreproveedor", txtRazonSocialD.Text);
                Texto_Html = Texto_Html.Replace("@fecharegistro", txtFechaD.Text);

                // Si tienes el usuario que registró la compra, reemplaza aquí
                Texto_Html = Texto_Html.Replace("@usuarioregistro", "Usuario");

                string filas = string.Empty;
                foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string producto = row.Cells[0].Value?.ToString() ?? "";
                        string precioCompra = row.Cells[1].Value?.ToString() ?? "0.00";
                        string cantidad = row.Cells[2].Value?.ToString() ?? "0";
                        string subTotal = row.Cells[3].Value?.ToString() ?? "0.00";

                        filas += "<tr>";
                        filas += $"<td style='text-align: center;'>{producto}</td>";
                        filas += $"<td style='text-align: right;'>{precioCompra}</td>";
                        filas += $"<td style='text-align: right;'>{cantidad}</td>";
                        filas += $"<td style='text-align: right;'>{subTotal}</td>";
                        filas += "</tr>";
                    }
                }
                Texto_Html = Texto_Html.Replace("@filas", filas);
                Texto_Html = Texto_Html.Replace("@montototal", txtMontoTotalD.Text);

                SaveFileDialog savefile = new SaveFileDialog
                {
                    FileName = $"Compra_{numeroDocumento}.pdf",
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
        }

        private void tabControl1_Layout(object sender, LayoutEventArgs e)
        {
            cmbTipoDocumentoD.Items.Add(new OpcionCombos() { Valor = "Boleta", Texto = "Boleta" });
            cmbTipoDocumentoD.Items.Add(new OpcionCombos() { Valor = "Factura", Texto = "Factura" });
            cmbTipoDocumentoD.DisplayMember = "Texto";
            cmbTipoDocumentoD.ValueMember = "Valor";
            cmbTipoDocumentoD.SelectedIndex = 0;
        }
    }
}
