using System.Text.RegularExpressions;
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
using System.IO;

namespace CapaVisual
{
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
            txtDireccion.AutoSize = true;
        }

        public Image ByteToImage(byte[] ImageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(ImageBytes, 0, ImageBytes.Length);
            Image logo = new Bitmap(ms);
            return logo;
        }

        private void frmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteImagen = new CN_Negocio().ObtenerLogo(out obtenido);
            if (obtenido)
            {
                pbLogoNegocio.Image = ByteToImage(byteImagen);
            }

            DatosNegocio datos = new CN_Negocio().ObtenerDatosNegocio();
            txtNombreNegocio.Text = datos.NombreNegocio;
            txtNIT.Text = datos.NitDatoNegocio;
            txtDireccion.Text = datos.ubicacionNegocio;

        }

        private void btnSubirLogo_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.FileName = "Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteImagen = File.ReadAllBytes(oOpenFileDialog.FileName);
                bool respuesta = new CN_Negocio().ActualizarLogo(byteImagen, out mensaje);
                if (respuesta)
                {
                    pbLogoNegocio.Image = ByteToImage(byteImagen);
                }
                else
                {
                    MessageBox.Show(mensaje, "Error al actualizar logo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            DatosNegocio obj = new DatosNegocio()
            {
                NombreNegocio = txtNombreNegocio.Text,
                NitDatoNegocio = txtNIT.Text,
                ubicacionNegocio = txtDireccion.Text
            };
            bool respuesta = new CN_Negocio().RegistrarDatos(obj, out mensaje);
            if (respuesta)
            {
                MessageBox.Show("Datos del negocio actualizados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron actualizar los datos", "Error al actualizar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNIT_Leave(object sender, EventArgs e)
        {
            string patron = @"^\d{4}-\d{6}-\d{3}-\d{1}$";
            if (!Regex.IsMatch(txtNIT.Text, patron))
            {
                MessageBox.Show("El formato debe ser 0000-000000-000-0", "Formato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNIT.Focus();
            }
        }
    }
}
