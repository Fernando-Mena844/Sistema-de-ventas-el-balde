namespace CapaVisual
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.gbEncabezado = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUsuarioEncabezado = new System.Windows.Forms.Label();
            this.lblTituloEncabezado = new System.Windows.Forms.Label();
            this.gbModulos = new System.Windows.Forms.GroupBox();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.contextMenuStripMantenimiento = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripReportes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbEncabezado.SuspendLayout();
            this.gbModulos.SuspendLayout();
            this.contextMenuStripMantenimiento.SuspendLayout();
            this.contextMenuStripReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEncabezado
            // 
            this.gbEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.gbEncabezado.Controls.Add(this.lblUsuario);
            this.gbEncabezado.Controls.Add(this.btnClose);
            this.gbEncabezado.Controls.Add(this.lblUsuarioEncabezado);
            this.gbEncabezado.Controls.Add(this.lblTituloEncabezado);
            this.gbEncabezado.Location = new System.Drawing.Point(-3, -14);
            this.gbEncabezado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbEncabezado.Name = "gbEncabezado";
            this.gbEncabezado.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbEncabezado.Size = new System.Drawing.Size(1350, 92);
            this.gbEncabezado.TabIndex = 0;
            this.gbEncabezado.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(894, 49);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(122, 29);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "lblUsuario";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1244, 25);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 63);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblUsuarioEncabezado
            // 
            this.lblUsuarioEncabezado.AutoSize = true;
            this.lblUsuarioEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioEncabezado.Location = new System.Drawing.Point(783, 49);
            this.lblUsuarioEncabezado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioEncabezado.Name = "lblUsuarioEncabezado";
            this.lblUsuarioEncabezado.Size = new System.Drawing.Size(102, 29);
            this.lblUsuarioEncabezado.TabIndex = 1;
            this.lblUsuarioEncabezado.Text = "Usuario:";
            this.lblUsuarioEncabezado.Click += new System.EventHandler(this.lblUsuarioEncabezado_Click);
            // 
            // lblTituloEncabezado
            // 
            this.lblTituloEncabezado.AutoSize = true;
            this.lblTituloEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblTituloEncabezado.Location = new System.Drawing.Point(9, 32);
            this.lblTituloEncabezado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloEncabezado.Name = "lblTituloEncabezado";
            this.lblTituloEncabezado.Size = new System.Drawing.Size(302, 37);
            this.lblTituloEncabezado.TabIndex = 0;
            this.lblTituloEncabezado.Text = "Sistema de Ventas";
            this.lblTituloEncabezado.Click += new System.EventHandler(this.lblTituloEncabezado_Click);
            // 
            // gbModulos
            // 
            this.gbModulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gbModulos.Controls.Add(this.btnAcercaDe);
            this.gbModulos.Controls.Add(this.btnMantenimiento);
            this.gbModulos.Controls.Add(this.btnReportes);
            this.gbModulos.Controls.Add(this.btnClientes);
            this.gbModulos.Controls.Add(this.btnProveedores);
            this.gbModulos.Controls.Add(this.btnCompras);
            this.gbModulos.Controls.Add(this.btnVentas);
            this.gbModulos.Controls.Add(this.btnUsuario);
            this.gbModulos.Location = new System.Drawing.Point(-3, 88);
            this.gbModulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbModulos.Name = "gbModulos";
            this.gbModulos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbModulos.Size = new System.Drawing.Size(148, 777);
            this.gbModulos.TabIndex = 1;
            this.gbModulos.TabStop = false;
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcercaDe.Image = ((System.Drawing.Image)(resources.GetObject("btnAcercaDe.Image")));
            this.btnAcercaDe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAcercaDe.Location = new System.Drawing.Point(0, 635);
            this.btnAcercaDe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(148, 92);
            this.btnAcercaDe.TabIndex = 7;
            this.btnAcercaDe.Text = "Acerca De";
            this.btnAcercaDe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAcercaDe.UseVisualStyleBackColor = false;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnMantenimiento.Image")));
            this.btnMantenimiento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMantenimiento.Location = new System.Drawing.Point(0, 545);
            this.btnMantenimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(148, 92);
            this.btnMantenimiento.TabIndex = 6;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMantenimiento.UseVisualStyleBackColor = false;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReportes.Location = new System.Drawing.Point(0, 454);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(148, 92);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientes.Location = new System.Drawing.Point(0, 363);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(148, 92);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProveedores.Location = new System.Drawing.Point(0, 272);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(148, 92);
            this.btnProveedores.TabIndex = 3;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompras.Location = new System.Drawing.Point(0, 182);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCompras.Size = new System.Drawing.Size(148, 92);
            this.btnCompras.TabIndex = 2;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVentas.Location = new System.Drawing.Point(0, 91);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(148, 92);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(148, 92);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Location = new System.Drawing.Point(153, 88);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1172, 777);
            this.pnlContenedor.TabIndex = 2;
            // 
            // contextMenuStripMantenimiento
            // 
            this.contextMenuStripMantenimiento.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripMantenimiento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.negocioToolStripMenuItem});
            this.contextMenuStripMantenimiento.Name = "contextMenuStripMantenimiento";
            this.contextMenuStripMantenimiento.Size = new System.Drawing.Size(161, 100);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(160, 32);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(160, 32);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // negocioToolStripMenuItem
            // 
            this.negocioToolStripMenuItem.Name = "negocioToolStripMenuItem";
            this.negocioToolStripMenuItem.Size = new System.Drawing.Size(160, 32);
            this.negocioToolStripMenuItem.Text = "Negocio";
            this.negocioToolStripMenuItem.Click += new System.EventHandler(this.negocioToolStripMenuItem_Click);
            // 
            // contextMenuStripReportes
            // 
            this.contextMenuStripReportes.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripReportes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.contextMenuStripReportes.Name = "contextMenuStripReportes";
            this.contextMenuStripReportes.Size = new System.Drawing.Size(157, 68);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(156, 32);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(156, 32);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1326, 863);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.gbModulos);
            this.Controls.Add(this.gbEncabezado);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.gbEncabezado.ResumeLayout(false);
            this.gbEncabezado.PerformLayout();
            this.gbModulos.ResumeLayout(false);
            this.contextMenuStripMantenimiento.ResumeLayout(false);
            this.contextMenuStripReportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEncabezado;
        private System.Windows.Forms.Label lblUsuarioEncabezado;
        private System.Windows.Forms.Label lblTituloEncabezado;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbModulos;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negocioToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripReportes;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
    }
}

