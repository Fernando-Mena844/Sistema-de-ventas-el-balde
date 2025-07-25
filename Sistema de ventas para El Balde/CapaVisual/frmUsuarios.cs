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
using CapaVisual;
using CapaVisual.Utilidades;
using CapaNegocio;

namespace CapaVisual
{
    public partial class frmUsuarios: Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Add(new OpcionCombos() { Valor = 1, Texto = "Activo" });
            cmbEstado.Items.Add(new OpcionCombos() { Valor = 0, Texto = "No Activo" });
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                cmbRol.Items.Add(new OpcionCombos() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            cmbRol.DisplayMember = "Texto";
            cmbRol.ValueMember = "Valor";
            cmbRol.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvUsuarios.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cmbBusca.Items.Add(new OpcionCombos() { Valor = columna.Name, Texto = columna.HeaderText});
                }
            }

            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {
                dgvUsuarios.Rows.Add(new object[] { "", item.IdUsuario, item.DocumentoUsuario, item.NombreCompletoUsuario, item.correoUsuario, item.Clave,
                item.oRol.IdRol,
                item.oRol.Descripcion,
                item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "No Activo"
                });
            }
            cmbRol.DisplayMember = "Texto";
            cmbRol.ValueMember = "Valor";
            cmbRol.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvUsuarios.Columns)
            {
                if(columna.Visible == true && columna.Name != "btnseleccionar" && columna.Name != "idRol" && columna.Name != "EstadoValor")
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
            Usuario objusuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtid.Text),
                DocumentoUsuario = txtNroDocumento.Text,
                NombreCompletoUsuario = txtNombre.Text,
                correoUsuario = txtCorreo.Text,
                Clave = txtClave.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombos)cmbRol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombos)cmbEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if(objusuario.IdUsuario == 0)
            {
                int IdUsuarioGenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                if (IdUsuarioGenerado != 0)
                {
                    dgvUsuarios.Rows.Add(new object[] { "", IdUsuarioGenerado, txtNroDocumento.Text, txtNombre.Text, txtCorreo.Text, txtClave.Text,
            ((OpcionCombos)cmbRol.SelectedItem).Valor.ToString(),
            ((OpcionCombos)cmbRol.SelectedItem).Texto.ToString(),
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
                bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvUsuarios.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["id"].Value = txtid.Text;
                    row.Cells["NroDocumento"].Value = txtNroDocumento.Text;
                    row.Cells["Nombre"].Value = txtNombre.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["Contraseña"].Value = txtClave.Text;
                    row.Cells["idRol"].Value = ((OpcionCombos)cmbRol.SelectedItem).Valor.ToString();
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
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtClave.Text = "";
            cmbRol.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;

            txtNroDocumento.Select();
        }

        private void dgvUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

                e.Graphics.DrawImage(Properties.Resources.Check, new Rectangle (x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtid.Text = dgvUsuarios.Rows[indice].Cells["id"].Value.ToString();
                    txtNroDocumento.Text = dgvUsuarios.Rows[indice].Cells["NroDocumento"].Value.ToString();
                    txtNombre.Text = dgvUsuarios.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtCorreo.Text = dgvUsuarios.Rows[indice].Cells["Correo"].Value.ToString();
                    txtClave.Text = dgvUsuarios.Rows[indice].Cells["Contraseña"].Value.ToString();

                    foreach (OpcionCombos opcioncombo in cmbRol.Items)
                    {
                        if (Convert.ToInt32(opcioncombo.Valor) == Convert.ToInt32(dgvUsuarios.Rows[indice].Cells["idRol"].Value))
                        {
                            int indice_combo = cmbRol.Items.IndexOf(opcioncombo);
                            cmbRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (OpcionCombos opcioncombo in cmbEstado.Items)
                    {
                        if (opcioncombo.Texto == dgvUsuarios.Rows[indice].Cells["EstadoValor"].Value.ToString())
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
                if(MessageBox.Show("Desea eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(txtid.Text)
                    };


                    bool respuesta = new CN_Usuario().Eliminar(objusuario, out mensaje);

                    if (int.TryParse(txtIndice.Text, out int index) && index >= 0 && index < dgvUsuarios.Rows.Count)
                    {
                        dgvUsuarios.Rows.RemoveAt(index);
                    }
                    else
                    {
                        MessageBox.Show(mensaje , "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombos)cmbBusca.SelectedItem).Valor.ToString();
            if(dgvUsuarios.Rows.Count > 0 )
            {
                foreach (DataGridViewRow row in dgvUsuarios.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusca.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible=false;
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
            foreach (DataGridViewRow row in dgvUsuarios.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
