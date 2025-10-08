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
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1sHsd5hQkn-uErxoX_fXjcni1YvydB_UA/view?usp=drive_link");
        }
    }
}
