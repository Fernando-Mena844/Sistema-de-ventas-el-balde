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
    public partial class frmCategoria: Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Add(new OpcionCombos() { Valor = 1, Texto = "Activo" });
            cmbEstado.Items.Add(new OpcionCombos() { Valor = 0, Texto = "No Activo" });
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvCategorias.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cmbBusca.Items.Add(new OpcionCombos() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            List<Categoria> listaCategoria = new CN_Categoria().Listar();

            foreach (Categoria item in listaCategoria)
            {
                dgvCategorias.Rows.Add(new object[] { "", item.IdCategoria, item.descripcionCategoria,
                item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "No Activo"
                });
            }

            foreach (DataGridViewColumn columna in dgvCategorias.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar" && columna.Name != "idCategoria" && columna.Name != "Estado")
                {
                    cmbBusca.Items.Add(new OpcionCombos() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cmbBusca.DisplayMember = "Texto";
            cmbBusca.ValueMember = "Valor";
            cmbBusca.SelectedIndex = 0;

        }
        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtid.Text = "0";
            txtNombreCategoria.Text = "";
            cmbEstado.SelectedIndex = 0;

            txtNombreCategoria.Select();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Categoria objcategoria = new Categoria()
            {
                IdCategoria = Convert.ToInt32(txtid.Text),
                descripcionCategoria = txtNombreCategoria.Text,
                Estado = Convert.ToInt32(((OpcionCombos)cmbEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objcategoria.IdCategoria == 0)
            {
                int IdCategoriaGenerada = new CN_Categoria().Registrar(objcategoria, out mensaje);

                if (IdCategoriaGenerada != 0)
                {
                    dgvCategorias.Rows.Add(new object[] { "", IdCategoriaGenerada, txtNombreCategoria.Text,
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
                bool resultado = new CN_Categoria().Editar(objcategoria, out mensaje);
                if (resultado)
                {
                    int index = Convert.ToInt32(txtIndice.Text);
                    if (index >= 0 && index < dgvCategorias.Rows.Count)
                    {
                        DataGridViewRow row = dgvCategorias.Rows[index];
                        row.Cells["idCategoria"].Value = txtid.Text;
                        row.Cells["Categoria"].Value = txtNombreCategoria.Text;
                        row.Cells["Estado"].Value = ((OpcionCombos)cmbEstado.SelectedItem).Valor.ToString();
                        row.Cells["EstadoValor"].Value = ((OpcionCombos)cmbEstado.SelectedItem).Texto.ToString();

                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una fila válida para editar.");
                    }
                }

            }
            Limpiar();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar la categoría?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Categoria objcategoria = new Categoria()
                    {
                        IdCategoria = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Categoria().Eliminar(objcategoria, out mensaje);

                    if (int.TryParse(txtIndice.Text, out int index) && index >= 0 && index < dgvCategorias.Rows.Count)
                    {
                        dgvCategorias.Rows.RemoveAt(index);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            Limpiar();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombos)cmbBusca.SelectedItem).Valor.ToString();
            if (dgvCategorias.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCategorias.Rows)
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
            txtBusca.Text = string.Empty;
            foreach (DataGridViewRow row in dgvCategorias.Rows)
            {
                row.Visible = true;
            }
            cmbBusca.SelectedIndex = 0;

        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtid.Text = dgvCategorias.Rows[indice].Cells["idCategoria"].Value.ToString();
                    txtNombreCategoria.Text = dgvCategorias.Rows[indice].Cells["Categoria"].Value.ToString();

                    foreach (OpcionCombos opcioncombo in cmbEstado.Items)
                    {
                        if (opcioncombo.Texto == dgvCategorias.Rows[indice].Cells["Estado"].Value.ToString())
                        {
                            int indice_combo = cmbEstado.Items.IndexOf(opcioncombo);
                            cmbEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }

        }

        private void dgvCategorias_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
    }
}
