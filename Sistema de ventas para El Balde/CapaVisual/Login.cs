using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad; //Se llama la referencia CapaEntidad que fue agregada al proyecto previamente
using BCrypt.Net;


namespace CapaVisual
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            // Obtenemos la lista de usuarios
            List<Usuario> listaUsuarios = new CN_Usuario().Listar();

            // Buscamos el usuario por Documento
            Usuario oUsuario = listaUsuarios
                .Where(u => u.DocumentoUsuario == txtUsuario.Text)
                .FirstOrDefault();

            // Verificamos que el usuario exista y que la contraseña coincida
            if (oUsuario != null && BCrypt.Net.BCrypt.Verify(txtContrasena.Text, oUsuario.Clave))
            {
                // Login correcto, abrimos el formulario principal
                frmInicio form = new frmInicio(oUsuario);
                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                // Login incorrecto
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtContrasena.Text = "";
                txtUsuario.Focus();
            }

            // List<Usuario> listaUsuarios = new CN_Usuario().Listar();

            //Usuario oUsuario = new CN_Usuario().Listar().Where(u=> u.DocumentoUsuario == txtUsuario.Text && u.Clave == txtContrasena.Text).FirstOrDefault();

            // // Verifica si el usuario existe en la lista de usuarios obtenida de la capa de negocio

            // //Usuario oUsuario = new Usuario();

            // //oUsuario.DocumentoUsuario = txtUsuario.Text;
            // //oUsuario.Clave = txtContrasena.Text;

            // if (oUsuario != null)
            // {
            //     frmInicio form = new frmInicio(oUsuario);

            //     form.Show();
            //     this.Hide();

            //     form.FormClosing += frm_closing;
            // }
            // else
            // {
            //     MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     txtUsuario.Text = "";
            //     txtContrasena.Text = "";
            //     txtUsuario.Focus();
            // }

        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {

            txtUsuario.Text = "";
            txtContrasena.Text = "";
            this.Show();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
