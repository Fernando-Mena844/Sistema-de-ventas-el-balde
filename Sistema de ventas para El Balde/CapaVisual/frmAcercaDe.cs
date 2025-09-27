using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVisual
{
    public partial class frmAcercaDe: Form
    {
        public frmAcercaDe()
        {
            InitializeComponent();
        }

        private void btnDescargarPDF_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1250OKzD4h1y5Ele_6JVlRnCa7S4-o1VMt0RfSkNC_J4/edit?usp=sharing");
        }
    }
}
