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
using CapaVisual.Utilidades;

namespace CapaVisual
{
    public partial class frmProveedores: Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Add(new OpcionCombos() { Valor = 1, Texto = "Activo" });
            cmbEstado.Items.Add(new OpcionCombos() { Valor = 0, Texto = "No Activo" });
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvProveedor.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cmbBusca.Items.Add(new OpcionCombos() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            List<Proveedor> listaProveedor = new CN_Proveedor().Listar();

            foreach (Proveedor item in listaProveedor)
            {
                dgvProveedor.Rows.Add(new object[] { "", item.IdProveedor, item.documentoProveedor, item.razonSocialProveedor, item.correoProveedor, item.telefonoProveedor,
                item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "No Activo"
                });
            }

            foreach (DataGridViewColumn columna in dgvProveedor.Columns)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Proveedor objProveedor = new Proveedor()
            {
                IdProveedor = Convert.ToInt32(txtid.Text),
                documentoProveedor = txtNroDocumento.Text,
                razonSocialProveedor = txtRazonSocial.Text,
                correoProveedor = txtCorreo.Text,
                telefonoProveedor = txtTelefono.Text,
                Estado = Convert.ToInt32(((OpcionCombos)cmbEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objProveedor.IdProveedor == 0)
            {
                int IdGenerado = new CN_Proveedor().Registrar(objProveedor, out mensaje);

                if (IdGenerado != 0)
                {
                    dgvProveedor.Rows.Add(new object[] { "", IdGenerado, txtNroDocumento.Text, txtRazonSocial.Text, txtCorreo.Text, txtTelefono.Text,
            ((OpcionCombos)cmbEstado.SelectedItem).Valor.ToString(),
            ((OpcionCombos)cmbEstado.SelectedItem).Texto.ToString()
            });
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }

            else
            {
                bool resultado = new CN_Proveedor().Editar(objProveedor, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvProveedor.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["id"].Value = txtid.Text;
                    row.Cells["NroDocumento"].Value = txtNroDocumento.Text;
                    row.Cells["RazonSocial"].Value = txtRazonSocial.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["Telefono"].Value = txtTelefono.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombos)cmbEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombos)cmbEstado.SelectedItem).Texto.ToString();

                    Limpiar();
                }

            }

        }

        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtid.Text = "0";
            txtNroDocumento.Text = "";
            txtRazonSocial.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            cmbEstado.SelectedIndex = 0;

            txtNroDocumento.Select();
        }

        private void dgvProveedor_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedor.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtid.Text = dgvProveedor.Rows[indice].Cells["id"].Value.ToString();
                    txtNroDocumento.Text = dgvProveedor.Rows[indice].Cells["NroDocumento"].Value.ToString();
                    txtRazonSocial.Text = dgvProveedor.Rows[indice].Cells["RazonSocial"].Value.ToString();
                    txtCorreo.Text = dgvProveedor.Rows[indice].Cells["Correo"].Value.ToString();
                    txtTelefono.Text = dgvProveedor.Rows[indice].Cells["Telefono"].Value.ToString();

                    foreach (OpcionCombos opcioncombo in cmbEstado.Items)
                    {
                        if (opcioncombo.Texto == dgvProveedor.Rows[indice].Cells["EstadoValor"].Value.ToString())
                        {
                            int indice_combo = cmbEstado.Items.IndexOf(opcioncombo);
                            cmbEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("Desea eliminar el Proveedor?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Proveedor objProveedor = new Proveedor()
                    {
                        IdProveedor = Convert.ToInt32(txtid.Text)
                    };


                    bool respuesta = new CN_Proveedor().Eliminar(objProveedor, out mensaje);

                    if (respuesta)
                    {
                        dgvProveedor.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombos)cmbBusca.SelectedItem).Valor.ToString();
            if (dgvProveedor.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProveedor.Rows)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            foreach (DataGridViewRow row in dgvProveedor.Rows)
            {
                row.Visible = true;
            }
        }
    }
}

