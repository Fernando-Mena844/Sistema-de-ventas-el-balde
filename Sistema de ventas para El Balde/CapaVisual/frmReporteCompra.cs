using CapaEntidad;
using CapaNegocio;
using CapaVisual.Utilidades;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office.Y2022.FeaturePropertyBag;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVisual
{
    public partial class frmReporteCompra : Form
    {
        public frmReporteCompra()
        {
            InitializeComponent();
        }

        private void frmReporteCompra_Load(object sender, EventArgs e)
        {
            List<Proveedor> listaProveedor = new CN_Proveedor().Listar();

            //Aqui podemos hacer q se filtren todos los proveedores o uno en especifico toma el valor 0
            //pq es el q esta en sql para filtrar todos, el resto de valores va a depender segun el proveedor q se busque
            cboproveedor.Items.Add(new OpcionCombos() { Valor = 0, Texto = "TODOS" });
            foreach (Proveedor item in listaProveedor)
            {
                cboproveedor.Items.Add(new OpcionCombos() { Valor = item.IdProveedor, Texto = item.razonSocialProveedor });
            }

            cboproveedor.DisplayMember = "Texto";
            cboproveedor.ValueMember = "Valor";
            cboproveedor.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                cmbBusca.Items.Add(new OpcionCombos() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            cmbBusca.DisplayMember = "Texto";
            cmbBusca.ValueMember = "Valor";
            cmbBusca.SelectedIndex = 0;
        }

        private void btnbuscarresultado_Click(object sender, EventArgs e)
        {
            int idproveedor = Convert.ToInt32(((OpcionCombos)cboproveedor.SelectedItem).Valor.ToString());


            List<ReporteCompra> lista = new List<ReporteCompra>();

            lista = new CN_Reporte().Compra(
                dtpFechaInicio.Value.ToString("dd/MM/yyyy"),
                dtpFechaFin.Value.ToString("dd/MM/yyyy"),
                idproveedor
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
        }

        
    }
}
