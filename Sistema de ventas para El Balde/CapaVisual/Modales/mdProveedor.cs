using CapaEntidad;
using CapaNegocio;
using CapaVisual.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVisual.Modales
{
    public partial class mdProveedor : Form
    {

        public Proveedor Proveedor { get; set; }
        public mdProveedor()
        {
            InitializeComponent();
        }

        private void mdProveedor_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cmbBusca.Items.Add(new OpcionCombos() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            List<Proveedor> listaProveedor = new CN_Proveedor().Listar();

            foreach (Proveedor item in listaProveedor)
            {
                dgvdata.Rows.Add(new object[] { "", item.IdProveedor, item.documentoProveedor, item.razonSocialProveedor, item.correoProveedor, item.telefonoProveedor,
                item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "No Activo"
                });
            }

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar" && columna.Name != "EstadoValor")
                {
                    cmbBusca.Items.Add(new OpcionCombos() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cmbBusca.DisplayMember = "Texto";
            cmbBusca.ValueMember = "Valor";
            cmbBusca.SelectedIndex = 0;
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iFila = e.RowIndex;
            int iColumna = e.ColumnIndex;

            if (iFila >= 0 && iColumna > 0)
            {
                Proveedor = new Proveedor()
                {
                    IdProveedor = Convert.ToInt32(dgvdata.Rows[iFila].Cells["id"].Value.ToString()),
                    documentoProveedor = dgvdata.Rows[iFila].Cells["NroDocumento"].Value.ToString(),
                    razonSocialProveedor = dgvdata.Rows[iFila].Cells["RazonSocial"].Value.ToString(),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
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

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
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
    }
}