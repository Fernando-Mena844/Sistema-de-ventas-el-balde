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
using CapaVisual.Modales;
using CapaVisual.Utilidades;

namespace CapaVisual
{
    public partial class frmProducto: Form
    {

        public frmProducto()
        {
            InitializeComponent();
        }
        private void frmProducto_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Add(new OpcionCombos() { Valor = 1, Texto = "Activo" });
            cmbEstado.Items.Add(new OpcionCombos() { Valor = 0, Texto = "No Activo" });
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = 0;

            List<Categoria> listaRol = new CN_Categoria().Listar();

            foreach (Categoria item in listaRol)
            {
                cmbCategoria.Items.Add(new OpcionCombos() { Valor = item.IdCategoria, Texto = item.descripcionCategoria });
            }
            cmbCategoria.DisplayMember = "Texto";
            cmbCategoria.ValueMember = "Valor";
            cmbCategoria.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvProductos.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cmbBusca.Items.Add(new OpcionCombos() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            List<Producto> listaProducto = new CN_Producto().Listar();

            foreach (Producto item in listaProducto)
            {
                dgvProductos.Rows.Add(new object[] { "", item.IdProducto, item.codigoProducto, item.nombreProducto, item.descripcionProducto, item.oCategoria.descripcionCategoria,item.oCategoria.IdCategoria, item.oProveedor.razonSocialProveedor, item.oProveedor.IdProveedor,item.Stock, item.PrecioCompra, item.PrecioVenta,
                item.Estado == true ? "Activo" : "No Activo",
                item.Estado == true ? 1 : 0,
                });
            }

            foreach (DataGridViewColumn columna in dgvProductos.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar" && columna.Name != "idRol" && columna.Name != "EstadoValor")
                {
                    cmbBusca.Items.Add(new OpcionCombos() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cmbBusca.DisplayMember = "Texto";
            cmbBusca.ValueMember = "Valor";
            cmbBusca.SelectedIndex = 0;

        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtProveedor.Text = modal.Proveedor.razonSocialProveedor;
                    txtProveedor.Tag = modal.Proveedor.IdProveedor;
                }
                else
                {
                    txtProveedor.Text = string.Empty;
                }
            }

        }

        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtid.Text = "0";
            txtCodigoProducto.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cmbCategoria.SelectedIndex = 0;
            txtProveedor.Text = "";
            txtStock.Text = "";
            txtPrecioVenta.Text = "";
            txtPrecioCompra.Text = "";
            cmbEstado.SelectedIndex = 0;

            txtCodigoProducto.Select();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Producto objProducto = new Producto()
            {
                IdProducto = Convert.ToInt32(txtid.Text),
                codigoProducto = txtCodigoProducto.Text,
                nombreProducto = txtNombre.Text,
                descripcionProducto = txtDescripcion.Text,
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombos)cmbCategoria.SelectedItem).Valor) },
                oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(txtProveedor.Tag) },
                Stock = Convert.ToInt32(txtStock.Text),
                PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text),
                PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text),
                Estado = Convert.ToInt32(((OpcionCombos)cmbEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objProducto.IdProducto == 0)
            {
                int IdProductoGenerado = new CN_Producto().Registrar(objProducto, out mensaje);

                if (IdProductoGenerado != 0)
                {
                    dgvProductos.Rows.Add(new object[] {
            "", IdProductoGenerado,
            txtCodigoProducto.Text,
            txtNombre.Text,
            txtDescripcion.Text,
            ((OpcionCombos)cmbCategoria.SelectedItem).Valor.ToString(),
            ((OpcionCombos)cmbCategoria.SelectedItem).Texto.ToString(),
            txtProveedor.Tag.ToString(),
            txtProveedor.Text,
            txtStock.Text,
            txtPrecioCompra.Text,
            txtPrecioVenta.Text,
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
                bool resultado = new CN_Producto().Editar(objProducto, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvProductos.Rows[Convert.ToInt32(txtIndice.Text)];

                    row.Cells["idProducto"].Value = txtid.Text;
                    row.Cells["Codigo"].Value = txtCodigoProducto.Text;
                    row.Cells["Producto"].Value = txtNombre.Text;
                    row.Cells["Descripcion"].Value = txtDescripcion.Text;
                    row.Cells["idCategoria"].Value = ((OpcionCombos)cmbCategoria.SelectedItem).Valor.ToString();
                    row.Cells["Categoria"].Value = ((OpcionCombos)cmbCategoria.SelectedItem).Texto.ToString();
                    row.Cells["idProveedor"].Value = txtProveedor.Tag.ToString();
                    row.Cells["Proveedor"].Value = txtProveedor.Text;
                    row.Cells["Stock"].Value = txtStock.Text;
                    row.Cells["PrecioCompra"].Value = txtPrecioCompra.Text;
                    row.Cells["PrecioVenta"].Value = txtPrecioVenta.Text;
                    row.Cells["EstadoBit"].Value = ((OpcionCombos)cmbEstado.SelectedItem).Valor.ToString();
                    row.Cells["EstadoVisible"].Value = ((OpcionCombos)cmbEstado.SelectedItem).Texto.ToString();

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtid.Text = dgvProductos.Rows[indice].Cells["idProducto"].Value.ToString();
                    txtCodigoProducto.Text = dgvProductos.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtDescripcion.Text = dgvProductos.Rows[indice].Cells["Descripcion"].Value.ToString();
                    txtNombre.Text = dgvProductos.Rows[indice].Cells["Producto"].Value.ToString();
                    txtStock.Text = dgvProductos.Rows[indice].Cells["Stock"].Value.ToString();
                    txtPrecioCompra.Text = dgvProductos.Rows[indice].Cells["PrecioCompra"].Value.ToString();
                    txtPrecioVenta.Text = dgvProductos.Rows[indice].Cells["PrecioVenta"].Value.ToString();
                    txtProveedor.Text = dgvProductos.Rows[indice].Cells["Proveedor"].Value.ToString();

                    foreach (OpcionCombos opcioncombo in cmbCategoria.Items)
                    {
                        if (Convert.ToInt32(opcioncombo.Valor) == Convert.ToInt32(dgvProductos.Rows[indice].Cells["idCategoria"].Value))
                        {
                            int indice_combo = cmbCategoria.Items.IndexOf(opcioncombo);
                            cmbCategoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (OpcionCombos opcioncombo in cmbEstado.Items)
                    {
                        if (Convert.ToInt32(opcioncombo.Valor) == Convert.ToInt32(dgvProductos.Rows[indice].Cells["EstadoBit"].Value))
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

                    if (int.TryParse(txtIndice.Text, out int index) && index >= 0 && index < dgvProductos.Rows.Count)
                    {
                        dgvProductos.Rows.RemoveAt(index);
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
            if (dgvProductos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProductos.Rows)
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
            txtBusca.Text = "";
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                row.Visible = true;
            }

        }
    }
}