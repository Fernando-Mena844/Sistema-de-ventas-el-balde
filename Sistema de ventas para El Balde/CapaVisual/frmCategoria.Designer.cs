namespace CapaVisual
{
    partial class frmCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbBusca = new System.Windows.Forms.ComboBox();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDetallesCategoria = new System.Windows.Forms.Label();
            this.btnBorrarBusqueda = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblBusca = new System.Windows.Forms.Label();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.lblNombreCategoría = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.pnlDetallesUsuario = new System.Windows.Forms.Panel();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.pnlDetallesUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBusca
            // 
            this.cmbBusca.FormattingEnabled = true;
            this.cmbBusca.Location = new System.Drawing.Point(395, 37);
            this.cmbBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBusca.Name = "cmbBusca";
            this.cmbBusca.Size = new System.Drawing.Size(96, 24);
            this.cmbBusca.TabIndex = 2;
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(136, 14);
            this.txtIndice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(30, 22);
            this.txtIndice.TabIndex = 17;
            this.txtIndice.Text = "0";
            this.txtIndice.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(136, 40);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(30, 22);
            this.txtid.TabIndex = 16;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(10, 139);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(160, 24);
            this.cmbEstado.TabIndex = 15;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(6, 121);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(53, 16);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado:";
            // 
            // lblDetallesCategoria
            // 
            this.lblDetallesCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallesCategoria.Location = new System.Drawing.Point(4, 12);
            this.lblDetallesCategoria.Name = "lblDetallesCategoria";
            this.lblDetallesCategoria.Size = new System.Drawing.Size(131, 50);
            this.lblDetallesCategoria.TabIndex = 11;
            this.lblDetallesCategoria.Text = "Detalles de la categoría";
            // 
            // btnBorrarBusqueda
            // 
            this.btnBorrarBusqueda.BackColor = System.Drawing.Color.IndianRed;
            this.btnBorrarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnBorrarBusqueda.Location = new System.Drawing.Point(716, 38);
            this.btnBorrarBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrarBusqueda.Name = "btnBorrarBusqueda";
            this.btnBorrarBusqueda.Size = new System.Drawing.Size(77, 31);
            this.btnBorrarBusqueda.TabIndex = 12;
            this.btnBorrarBusqueda.Text = "Borrar";
            this.btnBorrarBusqueda.UseVisualStyleBackColor = false;
            this.btnBorrarBusqueda.Click += new System.EventHandler(this.btnBorrarBusqueda_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::CapaVisual.Properties.Resources.Search;
            this.btnBuscar.Location = new System.Drawing.Point(619, 38);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(77, 31);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnBorrarBusqueda);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.txtBusca);
            this.panel2.Controls.Add(this.cmbBusca);
            this.panel2.Controls.Add(this.lblBusca);
            this.panel2.Controls.Add(this.lblCategorias);
            this.panel2.Location = new System.Drawing.Point(201, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 90);
            this.panel2.TabIndex = 6;
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(504, 38);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(104, 22);
            this.txtBusca.TabIndex = 3;
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Location = new System.Drawing.Point(314, 39);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(71, 16);
            this.lblBusca.TabIndex = 1;
            this.lblBusca.Text = "Busca por:";
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.Location = new System.Drawing.Point(20, 34);
            this.lblCategorias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(117, 25);
            this.lblCategorias.TabIndex = 0;
            this.lblCategorias.Text = "Categorías";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(10, 308);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(158, 29);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(10, 232);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(158, 32);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Black;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(9, 269);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(158, 34);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(9, 85);
            this.txtNombreCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(160, 22);
            this.txtNombreCategoria.TabIndex = 4;
            // 
            // lblNombreCategoría
            // 
            this.lblNombreCategoría.AutoSize = true;
            this.lblNombreCategoría.Location = new System.Drawing.Point(5, 68);
            this.lblNombreCategoría.Name = "lblNombreCategoría";
            this.lblNombreCategoría.Size = new System.Drawing.Size(66, 16);
            this.lblNombreCategoría.TabIndex = 0;
            this.lblNombreCategoría.Text = "Categoría";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.idCategoria,
            this.Categoria,
            this.Estado,
            this.EstadoValor});
            this.dgvCategorias.Location = new System.Drawing.Point(202, 149);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategorias.RowHeadersWidth = 62;
            this.dgvCategorias.RowTemplate.Height = 28;
            this.dgvCategorias.Size = new System.Drawing.Size(574, 395);
            this.dgvCategorias.TabIndex = 5;
            this.dgvCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentClick);
            this.dgvCategorias.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvCategorias_CellPainting);
            // 
            // pnlDetallesUsuario
            // 
            this.pnlDetallesUsuario.BackColor = System.Drawing.Color.White;
            this.pnlDetallesUsuario.Controls.Add(this.txtIndice);
            this.pnlDetallesUsuario.Controls.Add(this.txtid);
            this.pnlDetallesUsuario.Controls.Add(this.cmbEstado);
            this.pnlDetallesUsuario.Controls.Add(this.lblEstado);
            this.pnlDetallesUsuario.Controls.Add(this.lblDetallesCategoria);
            this.pnlDetallesUsuario.Controls.Add(this.btnBorrar);
            this.pnlDetallesUsuario.Controls.Add(this.btnGuardar);
            this.pnlDetallesUsuario.Controls.Add(this.btnLimpiar);
            this.pnlDetallesUsuario.Controls.Add(this.txtNombreCategoria);
            this.pnlDetallesUsuario.Controls.Add(this.lblNombreCategoría);
            this.pnlDetallesUsuario.Location = new System.Drawing.Point(11, 0);
            this.pnlDetallesUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDetallesUsuario.Name = "pnlDetallesUsuario";
            this.pnlDetallesUsuario.Size = new System.Drawing.Size(178, 554);
            this.pnlDetallesUsuario.TabIndex = 4;
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.MinimumWidth = 8;
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 50;
            // 
            // idCategoria
            // 
            this.idCategoria.HeaderText = "idCategoria";
            this.idCategoria.MinimumWidth = 8;
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.ReadOnly = true;
            this.idCategoria.Visible = false;
            this.idCategoria.Width = 150;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 8;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 150;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 8;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            this.Estado.Width = 150;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "Estado";
            this.EstadoValor.MinimumWidth = 8;
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Width = 150;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.pnlDetallesUsuario);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCategoria";
            this.Text = "frmCategoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.pnlDetallesUsuario.ResumeLayout(false);
            this.pnlDetallesUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBusca;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDetallesCategoria;
        private System.Windows.Forms.Button btnBorrarBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Label lblNombreCategoría;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Panel pnlDetallesUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
    }
}