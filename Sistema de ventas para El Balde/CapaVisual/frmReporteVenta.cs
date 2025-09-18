using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaVisual.Modales;
using CapaVisual.Utilidades;
using ClosedXML.Excel;

namespace CapaVisual
{
    public partial class frmReporteVenta: Form
    {
        int idClienteReporte = 0;

        public frmReporteVenta()
        {
            InitializeComponent();
        }

        private void frmReporteVenta_Load(object sender, EventArgs e)
        {
            List<Cliente> listaCliente = new CN_Cliente().Listar();

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                cmbBusca.Items.Add(new OpcionCombos() { Valor = columna.Name, Texto = columna.HeaderText });
            }

            dtpFechaFin.MaxDate = DateTime.Today;
            dtpFechaInicio.MaxDate = dtpFechaFin.Value;
            dtpFechaFin.MinDate = dtpFechaInicio.Value;
            // Llamar a los eventos
            dtpFechaFin.ValueChanged += dtpFechaFin_ValueChanged;
            dtpFechaInicio.ValueChanged += dtpFechaInicio_ValueChanged;
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

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtCliente.Text = modal._Cliente.nombreCompletoCliente;
                    idClienteReporte = modal._Cliente.IdCliente;
                }
            }

        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            List<ReporteVenta> lista = new List<ReporteVenta>();

            lista = new CN_Reporte().Venta(
                dtpFechaInicio.Value.ToString("dd/MM/yyyy"),
                dtpFechaFin.Value.ToString("dd/MM/yyyy"),
                idClienteReporte
                );

            dgvdata.Rows.Clear();

            foreach (ReporteVenta rc in lista)
            {
                dgvdata.Rows.Add(new object[] {
                    rc.FechaRegistro,
                    rc.TipoDocumento,
                    rc.NumeroDocumentoVenta,
                    rc.MontoTotal,
                    rc.UsuarioRegistro,
                    rc.DocumentoCliente,
                    rc.NombreCompletoCliente,
                    rc.CodigoProducto,
                    rc.NombreProducto,
                    rc.DescripcionCategoria,
                    rc.PrecioVenta,
                    rc.Cantidad,
                    rc.SubTotal
                });
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombos)cmbBusca.SelectedItem).Valor.ToString();
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusca.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
            idClienteReporte = 0;
            txtCliente.Text = "TODOS";

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
                FileName = "ReporteVenta_" + DateTime.Now.ToString("ddMMyyyy_HHmmss") + ".xlsx",
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
            idClienteReporte = 0;
            txtCliente.Text = "TODOS";
            btnBorrarBusqueda_Click(sender, e);
        }
    }
}
