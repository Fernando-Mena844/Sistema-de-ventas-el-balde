using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using CapaEntidad; //Se llama la referencia CapaEntidad que fue agregada al proyecto previamente
using CapaNegocio;


namespace CapaVisual
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public Image ByteToImage(byte[] ImageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(ImageBytes, 0, ImageBytes.Length);
            Image logo = new Bitmap(ms);
            return logo;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteImagen = new CN_Negocio().ObtenerLogo(out obtenido);
            if (obtenido)
            {
                pbLogo.Image = ByteToImage(byteImagen);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
