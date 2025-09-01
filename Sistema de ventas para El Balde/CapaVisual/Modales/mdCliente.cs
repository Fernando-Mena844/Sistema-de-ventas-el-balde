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
    public partial class mdCliente: Form
    {
        public Cliente _Cliente { get; set; }


        public mdCliente()
        {
            InitializeComponent();
        }

        private void mdCliente_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                
                    cmbBusca.Items.Add(new OpcionCombos() { Valor = columna.Name, Texto = columna.HeaderText });
                
            }

            cmbBusca.DisplayMember = "Texto";
            cmbBusca.ValueMember = "Valor";
            cmbBusca.SelectedIndex = 0;


            List<Cliente> lista = new CN_Cliente().Listar();
            foreach (Cliente items in lista)
            { 
             if(items.Estado)
                    dgvdata.Rows.Add(new object[] { items.documentoCliente, items.nombreCompletoCliente });
            }
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;
            if (iRow>= 0 && iColum >= 0)
            {
                _Cliente = new Cliente()
                {
                    documentoCliente = dgvdata.Rows[iRow].Cells["NroDocumento"].Value.ToString(),
                    nombreCompletoCliente = dgvdata.Rows[iRow].Cells["nombre"].Value.ToString()
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
    }
}
