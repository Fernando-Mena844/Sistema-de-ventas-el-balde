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
using CapaVisual;
using CapaVisual.Utilidades;
using Org.BouncyCastle.Crypto.Generators;
using BCrypt.Net;

namespace CapaVisual
{
    public partial class frmUsuarios : Form
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

            cmbRol.Items.Clear();
            List<Rol> listaRol = new CN_Rol().Listar();
            foreach (Rol item in listaRol)
            {
                cmbRol.Items.Add(new OpcionCombos() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            cmbRol.DisplayMember = "Texto";
            cmbRol.ValueMember = "Valor";
            if (cmbRol.Items.Count > 0)
            {
                cmbRol.SelectedIndex = 0;
            }   

            List<Usuario> listaUsuario = new CN_Usuario().Listar();
            foreach (Usuario item in listaUsuario)
            {
            dgvUsuarios.Rows.Add(new object[] { "", item.IdUsuario, item.DocumentoUsuario, item.NombreCompletoUsuario, item.correoUsuario, "******",
            item.oRol.IdRol,
            item.oRol.Descripcion,
            item.Estado == true ? 1 : 0,
            item.Estado == true ? "Activo" : "No Activo"
                });
            }

            // Criterios de búsqueda (sin duplicados)
            cmbBusca.Items.Clear();
            foreach (DataGridViewColumn columna in dgvUsuarios.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar" && columna.Name != "idRol" && columna.Name != "EstadoValor")
                {
                    cmbBusca.Items.Add(new OpcionCombos() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cmbBusca.DisplayMember = "Texto";
            cmbBusca.ValueMember = "Valor";
            if (cmbBusca.Items.Count > 0) 
            { 
                cmbBusca.SelectedIndex = 0; 
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Creamos el objeto usuario con los datos del formulario
            Usuario objusuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtid.Text),
                DocumentoUsuario = txtNroDocumento.Text,
                NombreCompletoUsuario = txtNombre.Text,
                correoUsuario = txtCorreo.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombos)cmbRol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombos)cmbEstado.SelectedItem).Valor) == 1
            };

            // Si se ingresa una contraseña, la hasheamos
            if (!string.IsNullOrWhiteSpace(txtClave.Text))
            {
                objusuario.Clave = BCrypt.Net.BCrypt.HashPassword(txtClave.Text);
            }

            // Si es nuevo usuario
            if (objusuario.IdUsuario == 0)
            {
                int IdUsuarioGenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                if (IdUsuarioGenerado != 0)
                {
                    dgvUsuarios.Rows.Add(new object[]
                    {
                "",
                IdUsuarioGenerado,
                txtNroDocumento.Text,
                txtNombre.Text,
                txtCorreo.Text,
                "******", // No mostramos la contraseña
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
            // Si es edición de usuario
            else
            {
                // Si txtClave tiene valor, actualizamos la contraseña (ya hasheada)
                if (!string.IsNullOrWhiteSpace(txtClave.Text))
                {
                    objusuario.Clave = BCrypt.Net.BCrypt.HashPassword(txtClave.Text);
                }

                bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvUsuarios.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["id"].Value = txtid.Text;
                    row.Cells["NroDocumento"].Value = txtNroDocumento.Text;
                    row.Cells["Nombre"].Value = txtNombre.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["Contraseña"].Value = "******"; // Siempre ocultamos la contraseña
                    row.Cells["idRol"].Value = ((OpcionCombos)cmbRol.SelectedItem).Valor.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombos)cmbEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombos)cmbEstado.SelectedItem).Texto.ToString();

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            dgvUsuarios.Rows.Clear();
            List<Usuario> listaUsuario = new CN_Usuario().Listar();
            foreach (Usuario item in listaUsuario)
            {
                dgvUsuarios.Rows.Add(new object[] { "", item.IdUsuario, item.DocumentoUsuario, item.NombreCompletoUsuario, item.correoUsuario, "******",
            item.oRol.IdRol,
            item.oRol.Descripcion,
            item.Estado == true ? 1 : 0,
            item.Estado == true ? "Activo" : "No Activo"
                });
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

                e.Graphics.DrawImage(Properties.Resources.Check, new Rectangle(x, y, w, h));
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
                    txtClave.Text = "******";

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
                if (MessageBox.Show("Desea eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombos)cmbBusca.SelectedItem).Valor.ToString();
            if (dgvUsuarios.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvUsuarios.Rows)
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
            foreach (DataGridViewRow row in dgvUsuarios.Rows)
            {
                row.Visible = true;
            }
        }

        private void txtNroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNroDocumento.Clear();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Clear();

            }
        }
    }
}
