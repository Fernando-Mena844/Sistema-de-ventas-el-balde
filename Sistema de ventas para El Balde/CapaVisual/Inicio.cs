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

namespace CapaVisual
{
    public partial class frmInicio: Form
    {

        private static Usuario usuarioActual;
        private static Button MenuActivo = null;
        private static Form formularioActivo = null;
        private static ContextMenuStrip MenuActivoCMS = null;

        public frmInicio(Usuario objusuario)
        {
            usuarioActual = objusuario;

            InitializeComponent();
        }

        private void lblUsuarioEncabezado_Click(object sender, EventArgs e)
        {

        }

        private void lblTituloEncabezado_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Método para abrir un formulario desde un botón del menú principal
        private void AbrirFormulario(Button menu, Form formulario)
        {
            //if (MenuActivo != null)
            //{
            //    MenuActivo.BackColor = Color.FromArgb(243, 235, 235) ;
            //}
            //menu.BackColor = Color.White;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            //Configuracion de formulario
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.FromArgb(243, 235, 235);
            //Se agrega el formulario al contenedor
            pnlContenedor.Controls.Add(formulario);
            formulario.Show();
        }


        // Método para abrir un formulario desde un ContextMenuStrip
        private void AbrirFormularioCMS(ContextMenuStrip menu, Form formulario)
        {
            //if (MenuActivoCMS != null)
            //{
            //    MenuActivoCMS.BackColor = Color.FromArgb(243, 235, 235);
            //}
            //menu.BackColor = Color.White;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            //Configuracion de formulario
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.FromArgb(243, 235, 235);
            //Se agrega el formulario al contenedor
            pnlContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        // Color original y color activo
        Color colorOriginal = Color.FromArgb(243, 235, 235);
        Color colorActivo = Color.LightBlue;

        // Método para manejar el cambio de color
        private void ActivarBoton(Button botonActivo)
        {
            // Recorrer solo los botones dentro del GroupBox
            foreach (Control control in gbModulos.Controls)
            {
                if (control is Button boton)
                {
                    boton.BackColor = colorOriginal;
                }
            }

            // Activar el botón seleccionado
            botonActivo.BackColor = colorActivo;
        }



        private void btnUsuario_Click(object sender, EventArgs e)
        {
         
            AbrirFormulario((Button)sender, new frmUsuarios());
            // Activar el botón presionado
            ActivarBoton(btnUsuario);

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuarioActual.NombreCompletoUsuario;
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            // Abrir el ContextMenuStrip de mantenimiento
            contextMenuStripMantenimiento.Show(btnMantenimiento, new Point(0, btnMantenimiento.Height));
            // Activar el botón presionado
            ActivarBoton(btnMantenimiento);
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de categoría
            AbrirFormularioCMS(contextMenuStripMantenimiento, new frmCategoria());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            // Abrir el ContextMenuStrip de reportes
            contextMenuStripReportes.Show(btnReportes, new Point(0, btnReportes.Height));
            // Activar el botón presionado
            ActivarBoton(btnReportes);
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de producto
            AbrirFormularioCMS(contextMenuStripMantenimiento, new frmProducto());
        }

        private void negocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de negocio
            AbrirFormularioCMS(contextMenuStripMantenimiento, new frmNegocio());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de ventas
            AbrirFormulario((Button)sender, new frmVentas());
            // Activar el botón presionado
            ActivarBoton(btnVentas);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de compras
            AbrirFormulario((Button)sender, new frmCompras());
            // Activar el botón presionado
            ActivarBoton(btnCompras);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de proveedores
            AbrirFormulario((Button)sender, new frmProveedores());
            // Activar el botón presionado
            ActivarBoton(btnProveedores);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de clientes
            AbrirFormulario((Button)sender, new frmClientes());
            // Activar el botón presionado
            ActivarBoton(btnClientes);
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de reporte de compras
            AbrirFormularioCMS(contextMenuStripReportes, new frmReporteCompra());
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de reporte de ventas
            AbrirFormularioCMS(contextMenuStripReportes, new frmReporteVenta());
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            // Abrir el formulario Acerca de
            AbrirFormulario((Button)sender, new frmAcercaDe());
            // Activar el botón presionado
            ActivarBoton(btnAcercaDe);

        }
    }
}
