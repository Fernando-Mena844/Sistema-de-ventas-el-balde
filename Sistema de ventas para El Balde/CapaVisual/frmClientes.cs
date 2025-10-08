using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaVisual.Utilidades;

namespace CapaVisual
{
    public partial class frmClientes: Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        private object cmbRol;
        private int columnaFiltro;

        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtid.Text = "0";
            txtNroDocumento.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            cmbEstado.SelectedIndex = 0;

            txtNroDocumento.Select();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Cliente objCLiente = new Cliente()
            {
                IdCliente = Convert.ToInt32(txtid.Text),
                documentoCliente = txtNroDocumento.Text,
                nombreCompletoCliente = txtNombre.Text,
                correoCliente = txtCorreo.Text,
                telefonoCliente = txtTelefono.Text,
                Estado = Convert.ToInt32(((OpcionCombos)cmbEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objCLiente.IdCliente == 0)
            {
                int IdGenerado = new CN_Cliente().Registrar(objCLiente, out mensaje);

                if (IdGenerado != 0)
                {
                    dgvClientes.Rows.Add(new object[]
                    {
                        "", // btnseleccionar
                        IdGenerado, // idCliente
                        txtNroDocumento.Text,
                        txtNombre.Text,
                        txtCorreo.Text,
                        txtTelefono.Text,
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
                bool resultado = new CN_Cliente().Editar(objCLiente, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvClientes.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["idCliente"].Value = txtid.Text;
                    row.Cells["NroDocumento"].Value = txtNroDocumento.Text;
                    row.Cells["Nombre"].Value = txtNombre.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["Telefono"].Value = txtTelefono.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombos)cmbEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombos)cmbEstado.SelectedItem).Texto.ToString();

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Add(new OpcionCombos() { Valor = 1, Texto = "Activo" });
            cmbEstado.Items.Add(new OpcionCombos() { Valor = 0, Texto = "No Activo" });
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = 0;
            List<Rol> listaRol = new CN_Rol().Listar();
            foreach (DataGridViewColumn columna in dgvClientes.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cmbBusca.Items.Add(new OpcionCombos() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            List<Cliente> listaClientes = new CN_Cliente().Listar();
            foreach (Cliente item in listaClientes)
            {
                dgvClientes.Rows.Add(new object[]
                {
                "",
                item.IdCliente,
                item.documentoCliente,
                item.nombreCompletoCliente,
                item.correoCliente,
                item.telefonoCliente,
                item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "No Activo"
                }
            );
            }
            cmbBusca.DisplayMember = "Texto";
            cmbBusca.ValueMember = "Valor";
            cmbBusca.SelectedIndex = 0;

        }

        private void dgvClientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("Desea eliminar el Cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Cliente objCliente = new Cliente()
                    {
                        IdCliente = Convert.ToInt32(txtid.Text)
                    };


                    bool respuesta = new CN_Cliente().Eliminar(objCliente, out mensaje);

                    if (respuesta)
                    {
                        foreach (DataGridViewRow row in dgvClientes.Rows)
                        {
                            if (row.Cells["idCliente"].Value != null && row.Cells["idCliente"].Value.ToString() == txtid.Text)
                            {
                                dgvClientes.Rows.Remove(row);
                                break;
                            }
                        }
                        Limpiar();
                    }
                    else
                    {
                        if (mensaje == string.Empty)
                        {
                            MessageBox.Show("Recarga el formulario.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombos)cmbBusca.SelectedItem).Valor.ToString();
            if (dgvClientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvClientes.Rows)
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
            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                row.Visible = true;
            }

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtid.Text = dgvClientes.Rows[indice].Cells["idCliente"].Value.ToString();
                    Console.WriteLine($"Valor del ID: {dgvClientes.Rows[indice].Cells["idCliente"].Value}");
                    txtNroDocumento.Text = dgvClientes.Rows[indice].Cells["NroDocumento"].Value.ToString();
                    txtNombre.Text = dgvClientes.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtCorreo.Text = dgvClientes.Rows[indice].Cells["Correo"].Value.ToString();
                    txtTelefono.Text = dgvClientes.Rows[indice].Cells["Telefono"].Value.ToString();
                    foreach (OpcionCombos opcioncombo in cmbEstado.Items)
                    {
                        if (opcioncombo.Texto == dgvClientes.Rows[indice].Cells["EstadoValor"].Value.ToString())
                        {
                            int indice_combo = cmbEstado.Items.IndexOf(opcioncombo);
                            cmbEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        #region Validaciones
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Clear();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números y un guion (-)", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTelefono.Clear();
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Contains("-"))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permite un guion (-)", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTelefono.Clear();
            }
        }
        #endregion

        private void txtNroDocumento_Leave(object sender, EventArgs e)
        {
            string patron = @"^\d{8}-\d{1}$";
            if (!Regex.IsMatch(txtNroDocumento.Text, patron))
            {
                MessageBox.Show("El formato debe ser 00000000-0", "Formato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNroDocumento.Focus();
            }

        }
    }
}