using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaVisual.Modales;
using CapaVisual.Utilidades;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office.Y2022.FeaturePropertyBag;

namespace CapaVisual
{
    public partial class frmReporteCompra : Form
    {
        int idProveedorReporte = 0;
        public frmReporteCompra()
        {
            InitializeComponent();
        }

        private void frmReporteCompra_Load(object sender, EventArgs e)
        {
            List<Proveedor> listaProveedor = new CN_Proveedor().Listar();

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                //cmbBusca.Items.Add(new OpcionCombos() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            dtpFechaFin.MaxDate = DateTime.Today;
            dtpFechaInicio.MaxDate = dtpFechaFin.Value;
            dtpFechaFin.MinDate = dtpFechaInicio.Value;
            // Llamar a los eventos
            dtpFechaFin.ValueChanged += dtpFechaFin_ValueChanged;
            dtpFechaInicio.ValueChanged += dtpFechaInicio_ValueChanged;
        }

        private void btnbuscarresultado_Click(object sender, EventArgs e)
        {

            List<ReporteCompra> lista = new List<ReporteCompra>();

            lista = new CN_Reporte().Compra(
                dtpFechaInicio.Value.ToString("dd/MM/yyyy"),
                dtpFechaFin.Value.ToString("dd/MM/yyyy"),
                idProveedorReporte
                );

            dgvdata.Rows.Clear();

            foreach (ReporteCompra rc in lista)
            {
                dgvdata.Rows.Add(new object[] {
                    rc.FechaRegistro,
                    rc.TipoDocumento,
                    rc.NumeroDocumentoCompra,
                    rc.MontoTotal,
                    rc.UsuarioRegistro,
                    rc.DocumentoProveedor,
                    rc.RazonSocial,
                    rc.CodigoProducto,
                    rc.NombreProducto,
                    rc.Categoria,
                    rc.PrecioCompra,
                    rc.PrecioVenta,
                    rc.Cantidad,
                    rc.SubTotal
                });
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn column in dgvdata.Columns)
            {
                if (column.Visible && column.Name != "btnseleccionar" && column.HeaderText != string.Empty)
                {
                    dt.Columns.Add(column.HeaderText, typeof(string));
                }
            }
            // Solo agregar filas visibles
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                if (row.Visible) // Verificar si la fila es visible
                {
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < dgvdata.Columns.Count; i++)
                    {
                        if (dgvdata.Columns[i].Visible && dgvdata.Columns[i].HeaderText != string.Empty && dgvdata.Columns[i].Name != "btnseleccionar")
                        {
                            dr[dgvdata.Columns[i].HeaderText] = row.Cells[i].Value?.ToString() ?? string.Empty;
                        }
                    }
                    dt.Rows.Add(dr);
                }
            }
            SaveFileDialog guardarExcel = new SaveFileDialog
            {
                FileName = "ReporteCompra_" + DateTime.Now.ToString("ddMMyyyy_HHmmss") + ".xlsx",
                Filter = "Excel Files|*.xlsx",
                Title = "Guardar archivo Excel"
            };
            if (guardarExcel.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XLWorkbook wb = new XLWorkbook();
                    var hoja = wb.Worksheets.Add(dt, "Informe");
                    hoja.ColumnsUsed().AdjustToContents(); // Ajustar el ancho de las columnas
                    wb.SaveAs(guardarExcel.FileName);
                    MessageBox.Show("Archivo exportado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error al exportar el archivo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            txtProveedor.Text = "TODOS";
            idProveedorReporte = 0;
            btnBorrarBusqueda_Click(sender, e);
        }


        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            // dtpFechaFin no puede ser menor a dtpFechaInicio
            dtpFechaFin.MinDate = dtpFechaInicio.Value;
            if (dtpFechaFin.Value < dtpFechaInicio.Value)
            {
                dtpFechaFin.Value = dtpFechaInicio.Value;
            }
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            // dtpFechaInicio no puede superar dtpFechaFin
            dtpFechaInicio.MaxDate = dtpFechaFin.Value;
            if (dtpFechaInicio.Value > dtpFechaFin.Value)
            {
                dtpFechaInicio.Value = dtpFechaFin.Value;
            }
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtProveedor.Text = modal._Proveedor.razonSocialProveedor;
                    idProveedorReporte = modal._Proveedor.IdProveedor;
                }
            }

        }
    }
}
