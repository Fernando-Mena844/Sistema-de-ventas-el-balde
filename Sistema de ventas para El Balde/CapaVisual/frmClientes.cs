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
                    dgvClientes.Rows.Add(new object[] { "", IdGenerado, txtNroDocumento.Text, txtNombre.Text, txtCorreo.Text, txtTelefono.Text,
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
                    row.Cells["id"].Value = txtid.Text;
                    row.Cells["NroDocumento"].Value = txtNroDocumento.Text;
                    row.Cells["Nombre"].Value = txtNombre.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["telefono"].Value = txtTelefono.Text;
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

            List<Cliente> listaUsuario = new CN_Cliente().Listar();

            foreach (Cliente item in listaUsuario)
            {
                dgvClientes.Rows.Add(new object[] { "", item.IdCliente, item.documentoCliente ,item.telefonoCliente, item.correoCliente, item.telefonoCliente,
         item.Estado == true ? 1 : 0,
         item.Estado == true ? "Activo" : "No Activo"
         });
            }
            cmbBusca.DisplayMember = "Texto";
            cmbBusca.ValueMember = "Valor";
            cmbBusca.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvClientes.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar" && columna.Name != "idRol" && columna.Name != "EstadoValor")
                {
                    cmbBusca.Items.Add(new OpcionCombos() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cmbBusca.DisplayMember = "Texto";
            cmbBusca.ValueMember = "Valor";
            cmbBusca.SelectedIndex = 0;

            List<Cliente> lisata = new CN_Cliente().Listar();

            foreach (Cliente item in lisata)
            {
                dgvClientes.Rows.Add(new object[] {"",item.IdCliente,item.documentoCliente,item.nombreCompletoCliente,item.correoCliente,item.telefonoCliente,
                    item.Estado ==true ? 1:0,
                    item.Estado == true?"true":"no Activo"
                });
            }

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
                            if (row.Cells["id"].Value != null && row.Cells["id"].Value.ToString() == txtid.Text)
                            {
                                dgvClientes.Rows.Remove(row);
                                break;
                            }
                        }
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
    }
}
