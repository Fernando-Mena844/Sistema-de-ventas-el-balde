using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVisual.Modales;
using CapaVisual.Utilidades;

namespace CapaVisual
{
    public partial class frmCompras: Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            cbotipodocumento.Items.Add(new OpcionCombos() { Valor = "Boleta", Texto = "Boleta" });
            cbotipodocumento.Items.Add(new OpcionCombos() { Valor = "Factura", Texto = "Factura" });
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;


            txtFechaC.Text = DateTime.Now.ToString("dd/MM/yyyy");



        }

        private void btnBuscarC_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

            }
        }
    }
}
