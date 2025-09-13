namespace CapaVisual
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRegistroCompra = new System.Windows.Forms.TabPage();
            this.pnlRegistroCompra = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.btnbuscarproducto = new System.Windows.Forms.Button();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtcodproducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegistrarC = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txttotalapagar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciocompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxProveedor = new System.Windows.Forms.GroupBox();
            this.txtidproveedor = new System.Windows.Forms.TextBox();
            this.btnBuscarprov = new System.Windows.Forms.Button();
            this.txtRazonsocial = new System.Windows.Forms.TextBox();
            this.txtdocproveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxCompra = new System.Windows.Forms.GroupBox();
            this.cbotipodocumento = new System.Windows.Forms.ComboBox();
            this.txtFechaC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistroCompra = new System.Windows.Forms.Label();
            this.tpDetalleCompra = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDescargarPDF = new System.Windows.Forms.Button();
            this.txtBuscarD = new System.Windows.Forms.TextBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.txtMontoTotalD = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnBorrarD = new System.Windows.Forms.Button();
            this.btnBuscarD = new System.Windows.Forms.Button();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.ProductoD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompraD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotalD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIdProveedorD = new System.Windows.Forms.TextBox();
            this.txtRazonSocialD = new System.Windows.Forms.TextBox();
            this.txtNumeroDocumentoProveedorD = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbTipoDocumentoD = new System.Windows.Forms.ComboBox();
            this.txtFechaD = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblDetalleCompra = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpRegistroCompra.SuspendLayout();
            this.pnlRegistroCompra.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.groupBoxProveedor.SuspendLayout();
            this.groupBoxCompra.SuspendLayout();
            this.tpDetalleCompra.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpRegistroCompra);
            this.tabControl1.Controls.Add(this.tpDetalleCompra);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(886, 560);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.Layout += new System.Windows.Forms.LayoutEventHandler(this.tabControl1_Layout);
            // 
            // tpRegistroCompra
            // 
            this.tpRegistroCompra.Controls.Add(this.pnlRegistroCompra);
            this.tpRegistroCompra.Location = new System.Drawing.Point(4, 22);
            this.tpRegistroCompra.Name = "tpRegistroCompra";
            this.tpRegistroCompra.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistroCompra.Size = new System.Drawing.Size(878, 534);
            this.tpRegistroCompra.TabIndex = 0;
            this.tpRegistroCompra.Text = "Registro de compra";
            this.tpRegistroCompra.UseVisualStyleBackColor = true;
            // 
            // pnlRegistroCompra
            // 
            this.pnlRegistroCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRegistroCompra.BackColor = System.Drawing.Color.White;
            this.pnlRegistroCompra.Controls.Add(this.groupBox1);
            this.pnlRegistroCompra.Controls.Add(this.btnRegistrarC);
            this.pnlRegistroCompra.Controls.Add(this.btnagregar);
            this.pnlRegistroCompra.Controls.Add(this.txttotalapagar);
            this.pnlRegistroCompra.Controls.Add(this.label5);
            this.pnlRegistroCompra.Controls.Add(this.dgvdata);
            this.pnlRegistroCompra.Controls.Add(this.groupBoxProveedor);
            this.pnlRegistroCompra.Controls.Add(this.groupBoxCompra);
            this.pnlRegistroCompra.Controls.Add(this.lblRegistroCompra);
            this.pnlRegistroCompra.Location = new System.Drawing.Point(55, 10);
            this.pnlRegistroCompra.Name = "pnlRegistroCompra";
            this.pnlRegistroCompra.Size = new System.Drawing.Size(769, 515);
            this.pnlRegistroCompra.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtpreciocompra);
            this.groupBox1.Controls.Add(this.txtidproducto);
            this.groupBox1.Controls.Add(this.btnbuscarproducto);
            this.groupBox1.Controls.Add(this.txtproducto);
            this.groupBox1.Controls.Add(this.txtcodproducto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(19, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Producto";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(614, 48);
            this.txtcantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(91, 21);
            this.txtcantidad.TabIndex = 1;
            this.txtcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(611, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(502, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Precio Compra";
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.Location = new System.Drawing.Point(502, 47);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.ReadOnly = true;
            this.txtpreciocompra.ShortcutsEnabled = false;
            this.txtpreciocompra.Size = new System.Drawing.Size(103, 21);
            this.txtpreciocompra.TabIndex = 0;
            this.txtpreciocompra.TabStop = false;
            this.txtpreciocompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreciocompra_KeyPress);
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(110, 23);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.ReadOnly = true;
            this.txtidproducto.ShortcutsEnabled = false;
            this.txtidproducto.Size = new System.Drawing.Size(36, 21);
            this.txtidproducto.TabIndex = 0;
            this.txtidproducto.TabStop = false;
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnbuscarproducto.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscarproducto.Image")));
            this.btnbuscarproducto.Location = new System.Drawing.Point(152, 44);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Size = new System.Drawing.Size(23, 23);
            this.btnbuscarproducto.TabIndex = 0;
            this.btnbuscarproducto.UseVisualStyleBackColor = true;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(197, 47);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.ReadOnly = true;
            this.txtproducto.ShortcutsEnabled = false;
            this.txtproducto.Size = new System.Drawing.Size(162, 21);
            this.txtproducto.TabIndex = 0;
            this.txtproducto.TabStop = false;
            // 
            // txtcodproducto
            // 
            this.txtcodproducto.Location = new System.Drawing.Point(9, 45);
            this.txtcodproducto.Name = "txtcodproducto";
            this.txtcodproducto.ReadOnly = true;
            this.txtcodproducto.ShortcutsEnabled = false;
            this.txtcodproducto.Size = new System.Drawing.Size(137, 21);
            this.txtcodproducto.TabIndex = 0;
            this.txtcodproducto.TabStop = false;
            this.txtcodproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodproducto_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cod. Producto";
            // 
            // btnRegistrarC
            // 
            this.btnRegistrarC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegistrarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRegistrarC.Location = new System.Drawing.Point(271, 475);
            this.btnRegistrarC.Name = "btnRegistrarC";
            this.btnRegistrarC.Size = new System.Drawing.Size(89, 23);
            this.btnRegistrarC.TabIndex = 5;
            this.btnRegistrarC.Text = "Registrar";
            this.btnRegistrarC.UseVisualStyleBackColor = true;
            this.btnRegistrarC.Click += new System.EventHandler(this.btnRegistrarC_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagregar.Location = new System.Drawing.Point(25, 243);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 31);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txttotalapagar
            // 
            this.txttotalapagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txttotalapagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txttotalapagar.Location = new System.Drawing.Point(92, 477);
            this.txttotalapagar.Name = "txttotalapagar";
            this.txttotalapagar.ReadOnly = true;
            this.txttotalapagar.Size = new System.Drawing.Size(137, 21);
            this.txttotalapagar.TabIndex = 0;
            this.txttotalapagar.TabStop = false;
            this.txttotalapagar.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(22, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Monto Total";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.producto,
            this.preciocompra,
            this.precioventa,
            this.cantidad,
            this.subtotal,
            this.btnEliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.Location = new System.Drawing.Point(19, 280);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowHeadersWidth = 51;
            this.dgvdata.Size = new System.Drawing.Size(729, 164);
            this.dgvdata.TabIndex = 5;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Visible = false;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            // 
            // preciocompra
            // 
            this.preciocompra.HeaderText = "PrecioCompra";
            this.preciocompra.MinimumWidth = 6;
            this.preciocompra.Name = "preciocompra";
            // 
            // precioventa
            // 
            this.precioventa.HeaderText = "Precio Venta";
            this.precioventa.MinimumWidth = 6;
            this.precioventa.Name = "precioventa";
            this.precioventa.Visible = false;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Sub total";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.MinimumWidth = 8;
            this.btnEliminar.Name = "btnEliminar";
            // 
            // groupBoxProveedor
            // 
            this.groupBoxProveedor.Controls.Add(this.txtidproveedor);
            this.groupBoxProveedor.Controls.Add(this.btnBuscarprov);
            this.groupBoxProveedor.Controls.Add(this.txtRazonsocial);
            this.groupBoxProveedor.Controls.Add(this.txtdocproveedor);
            this.groupBoxProveedor.Controls.Add(this.label6);
            this.groupBoxProveedor.Controls.Add(this.label7);
            this.groupBoxProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBoxProveedor.Location = new System.Drawing.Point(374, 46);
            this.groupBoxProveedor.Name = "groupBoxProveedor";
            this.groupBoxProveedor.Size = new System.Drawing.Size(375, 87);
            this.groupBoxProveedor.TabIndex = 2;
            this.groupBoxProveedor.TabStop = false;
            this.groupBoxProveedor.Text = "Informacion Proveedor";
            // 
            // txtidproveedor
            // 
            this.txtidproveedor.Location = new System.Drawing.Point(309, 25);
            this.txtidproveedor.Name = "txtidproveedor";
            this.txtidproveedor.ReadOnly = true;
            this.txtidproveedor.ShortcutsEnabled = false;
            this.txtidproveedor.Size = new System.Drawing.Size(50, 21);
            this.txtidproveedor.TabIndex = 0;
            this.txtidproveedor.TabStop = false;
            // 
            // btnBuscarprov
            // 
            this.btnBuscarprov.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBuscarprov.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarprov.Image")));
            this.btnBuscarprov.Location = new System.Drawing.Point(152, 44);
            this.btnBuscarprov.Name = "btnBuscarprov";
            this.btnBuscarprov.Size = new System.Drawing.Size(22, 23);
            this.btnBuscarprov.TabIndex = 0;
            this.btnBuscarprov.UseVisualStyleBackColor = true;
            this.btnBuscarprov.Click += new System.EventHandler(this.btnBuscarprov_Click);
            // 
            // txtRazonsocial
            // 
            this.txtRazonsocial.Location = new System.Drawing.Point(197, 47);
            this.txtRazonsocial.Name = "txtRazonsocial";
            this.txtRazonsocial.ReadOnly = true;
            this.txtRazonsocial.ShortcutsEnabled = false;
            this.txtRazonsocial.Size = new System.Drawing.Size(162, 21);
            this.txtRazonsocial.TabIndex = 0;
            this.txtRazonsocial.TabStop = false;
            // 
            // txtdocproveedor
            // 
            this.txtdocproveedor.Location = new System.Drawing.Point(9, 45);
            this.txtdocproveedor.Name = "txtdocproveedor";
            this.txtdocproveedor.ReadOnly = true;
            this.txtdocproveedor.ShortcutsEnabled = false;
            this.txtdocproveedor.Size = new System.Drawing.Size(137, 21);
            this.txtdocproveedor.TabIndex = 0;
            this.txtdocproveedor.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Razon Social";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Numero Documento";
            // 
            // groupBoxCompra
            // 
            this.groupBoxCompra.Controls.Add(this.cbotipodocumento);
            this.groupBoxCompra.Controls.Add(this.txtFechaC);
            this.groupBoxCompra.Controls.Add(this.label3);
            this.groupBoxCompra.Controls.Add(this.label2);
            this.groupBoxCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBoxCompra.Location = new System.Drawing.Point(19, 46);
            this.groupBoxCompra.Name = "groupBoxCompra";
            this.groupBoxCompra.Size = new System.Drawing.Size(327, 87);
            this.groupBoxCompra.TabIndex = 1;
            this.groupBoxCompra.TabStop = false;
            this.groupBoxCompra.Text = "Informacion Compra";
            // 
            // cbotipodocumento
            // 
            this.cbotipodocumento.FormattingEnabled = true;
            this.cbotipodocumento.Location = new System.Drawing.Point(152, 45);
            this.cbotipodocumento.Name = "cbotipodocumento";
            this.cbotipodocumento.Size = new System.Drawing.Size(159, 23);
            this.cbotipodocumento.TabIndex = 0;
            // 
            // txtFechaC
            // 
            this.txtFechaC.Location = new System.Drawing.Point(9, 45);
            this.txtFechaC.Name = "txtFechaC";
            this.txtFechaC.ReadOnly = true;
            this.txtFechaC.ShortcutsEnabled = false;
            this.txtFechaC.Size = new System.Drawing.Size(100, 21);
            this.txtFechaC.TabIndex = 1;
            this.txtFechaC.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha";
            // 
            // lblRegistroCompra
            // 
            this.lblRegistroCompra.AutoSize = true;
            this.lblRegistroCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroCompra.Location = new System.Drawing.Point(12, 9);
            this.lblRegistroCompra.Name = "lblRegistroCompra";
            this.lblRegistroCompra.Size = new System.Drawing.Size(166, 20);
            this.lblRegistroCompra.TabIndex = 0;
            this.lblRegistroCompra.Text = "Registro de compra";
            // 
            // tpDetalleCompra
            // 
            this.tpDetalleCompra.Controls.Add(this.panel1);
            this.tpDetalleCompra.Location = new System.Drawing.Point(4, 22);
            this.tpDetalleCompra.Name = "tpDetalleCompra";
            this.tpDetalleCompra.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetalleCompra.Size = new System.Drawing.Size(878, 534);
            this.tpDetalleCompra.TabIndex = 1;
            this.tpDetalleCompra.Text = "Ver detalle de compra";
            this.tpDetalleCompra.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDescargarPDF);
            this.panel1.Controls.Add(this.txtBuscarD);
            this.panel1.Controls.Add(this.lblNumeroDocumento);
            this.panel1.Controls.Add(this.txtMontoTotalD);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.btnBorrarD);
            this.panel1.Controls.Add(this.btnBuscarD);
            this.panel1.Controls.Add(this.dgvDetalleCompra);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.lblDetalleCompra);
            this.panel1.Location = new System.Drawing.Point(55, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 515);
            this.panel1.TabIndex = 8;
            // 
            // btnDescargarPDF
            // 
            this.btnDescargarPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDescargarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDescargarPDF.Location = new System.Drawing.Point(604, 466);
            this.btnDescargarPDF.Name = "btnDescargarPDF";
            this.btnDescargarPDF.Size = new System.Drawing.Size(119, 23);
            this.btnDescargarPDF.TabIndex = 14;
            this.btnDescargarPDF.Text = "Descargar a PDF";
            this.btnDescargarPDF.UseVisualStyleBackColor = true;
            this.btnDescargarPDF.Click += new System.EventHandler(this.btnDescargarPDF_Click);
            // 
            // txtBuscarD
            // 
            this.txtBuscarD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtBuscarD.Location = new System.Drawing.Point(373, 11);
            this.txtBuscarD.Name = "txtBuscarD";
            this.txtBuscarD.Size = new System.Drawing.Size(144, 21);
            this.txtBuscarD.TabIndex = 6;
            this.txtBuscarD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarD_KeyPress);
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNumeroDocumento.Location = new System.Drawing.Point(256, 14);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(134, 15);
            this.lblNumeroDocumento.TabIndex = 6;
            this.lblNumeroDocumento.Text = "Número de documento";
            // 
            // txtMontoTotalD
            // 
            this.txtMontoTotalD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMontoTotalD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtMontoTotalD.Location = new System.Drawing.Point(92, 472);
            this.txtMontoTotalD.Name = "txtMontoTotalD";
            this.txtMontoTotalD.Size = new System.Drawing.Size(137, 21);
            this.txtMontoTotalD.TabIndex = 9;
            this.txtMontoTotalD.Text = "0";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label19.Location = new System.Drawing.Point(22, 475);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 15);
            this.label19.TabIndex = 9;
            this.label19.Text = "Monto Total";
            // 
            // btnBorrarD
            // 
            this.btnBorrarD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarD.BackColor = System.Drawing.Color.IndianRed;
            this.btnBorrarD.ForeColor = System.Drawing.Color.White;
            this.btnBorrarD.Location = new System.Drawing.Point(635, 9);
            this.btnBorrarD.Name = "btnBorrarD";
            this.btnBorrarD.Size = new System.Drawing.Size(89, 23);
            this.btnBorrarD.TabIndex = 12;
            this.btnBorrarD.Text = "Borrar";
            this.btnBorrarD.UseVisualStyleBackColor = false;
            this.btnBorrarD.Click += new System.EventHandler(this.btnBorrarD_Click);
            // 
            // btnBuscarD
            // 
            this.btnBuscarD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarD.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBuscarD.ForeColor = System.Drawing.Color.White;
            this.btnBuscarD.Location = new System.Drawing.Point(541, 10);
            this.btnBuscarD.Name = "btnBuscarD";
            this.btnBuscarD.Size = new System.Drawing.Size(89, 23);
            this.btnBuscarD.TabIndex = 11;
            this.btnBuscarD.Text = "Buscar";
            this.btnBuscarD.UseVisualStyleBackColor = false;
            this.btnBuscarD.Click += new System.EventHandler(this.btnBuscarD_Click);
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.AllowUserToAddRows = false;
            this.dgvDetalleCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalleCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvDetalleCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoD,
            this.PrecioCompraD,
            this.CantidadD,
            this.SubTotalD,
            this.dataGridViewButtonColumn1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleCompra.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalleCompra.Location = new System.Drawing.Point(19, 163);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.RowHeadersWidth = 51;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(704, 290);
            this.dgvDetalleCompra.TabIndex = 5;
            // 
            // ProductoD
            // 
            this.ProductoD.HeaderText = "Producto";
            this.ProductoD.MinimumWidth = 6;
            this.ProductoD.Name = "ProductoD";
            // 
            // PrecioCompraD
            // 
            this.PrecioCompraD.HeaderText = "PrecioCompra";
            this.PrecioCompraD.MinimumWidth = 6;
            this.PrecioCompraD.Name = "PrecioCompraD";
            // 
            // CantidadD
            // 
            this.CantidadD.HeaderText = "Cantidad";
            this.CantidadD.MinimumWidth = 6;
            this.CantidadD.Name = "CantidadD";
            // 
            // SubTotalD
            // 
            this.SubTotalD.HeaderText = "Sub total";
            this.SubTotalD.MinimumWidth = 6;
            this.SubTotalD.Name = "SubTotalD";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.MinimumWidth = 8;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtIdProveedorD);
            this.groupBox3.Controls.Add(this.txtRazonSocialD);
            this.groupBox3.Controls.Add(this.txtNumeroDocumentoProveedorD);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox3.Location = new System.Drawing.Point(374, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 87);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion Proveedor";
            // 
            // txtIdProveedorD
            // 
            this.txtIdProveedorD.Location = new System.Drawing.Point(280, 25);
            this.txtIdProveedorD.Name = "txtIdProveedorD";
            this.txtIdProveedorD.ShortcutsEnabled = false;
            this.txtIdProveedorD.Size = new System.Drawing.Size(50, 21);
            this.txtIdProveedorD.TabIndex = 6;
            // 
            // txtRazonSocialD
            // 
            this.txtRazonSocialD.Location = new System.Drawing.Point(168, 47);
            this.txtRazonSocialD.Name = "txtRazonSocialD";
            this.txtRazonSocialD.ReadOnly = true;
            this.txtRazonSocialD.ShortcutsEnabled = false;
            this.txtRazonSocialD.Size = new System.Drawing.Size(162, 21);
            this.txtRazonSocialD.TabIndex = 4;
            // 
            // txtNumeroDocumentoProveedorD
            // 
            this.txtNumeroDocumentoProveedorD.Location = new System.Drawing.Point(9, 45);
            this.txtNumeroDocumentoProveedorD.Name = "txtNumeroDocumentoProveedorD";
            this.txtNumeroDocumentoProveedorD.ReadOnly = true;
            this.txtNumeroDocumentoProveedorD.ShortcutsEnabled = false;
            this.txtNumeroDocumentoProveedorD.Size = new System.Drawing.Size(137, 21);
            this.txtNumeroDocumentoProveedorD.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(165, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 15);
            this.label20.TabIndex = 1;
            this.label20.Text = "Razon Social";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 29);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 15);
            this.label21.TabIndex = 0;
            this.label21.Text = "Numero Documento";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbTipoDocumentoD);
            this.groupBox4.Controls.Add(this.txtFechaD);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox4.Location = new System.Drawing.Point(19, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 87);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informacion Compra";
            // 
            // cmbTipoDocumentoD
            // 
            this.cmbTipoDocumentoD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumentoD.FormattingEnabled = true;
            this.cmbTipoDocumentoD.Location = new System.Drawing.Point(152, 45);
            this.cmbTipoDocumentoD.Name = "cmbTipoDocumentoD";
            this.cmbTipoDocumentoD.Size = new System.Drawing.Size(159, 23);
            this.cmbTipoDocumentoD.TabIndex = 3;
            // 
            // txtFechaD
            // 
            this.txtFechaD.Location = new System.Drawing.Point(9, 45);
            this.txtFechaD.Name = "txtFechaD";
            this.txtFechaD.ReadOnly = true;
            this.txtFechaD.ShortcutsEnabled = false;
            this.txtFechaD.Size = new System.Drawing.Size(100, 21);
            this.txtFechaD.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(149, 29);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 15);
            this.label22.TabIndex = 1;
            this.label22.Text = "Tipo documento";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 15);
            this.label23.TabIndex = 0;
            this.label23.Text = "Fecha";
            // 
            // lblDetalleCompra
            // 
            this.lblDetalleCompra.AutoSize = true;
            this.lblDetalleCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleCompra.Location = new System.Drawing.Point(12, 9);
            this.lblDetalleCompra.Name = "lblDetalleCompra";
            this.lblDetalleCompra.Size = new System.Drawing.Size(174, 20);
            this.lblDetalleCompra.TabIndex = 0;
            this.lblDetalleCompra.Text = "Detalle de la compra";
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(892, 563);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpRegistroCompra.ResumeLayout(false);
            this.pnlRegistroCompra.ResumeLayout(false);
            this.pnlRegistroCompra.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.groupBoxProveedor.ResumeLayout(false);
            this.groupBoxProveedor.PerformLayout();
            this.groupBoxCompra.ResumeLayout(false);
            this.groupBoxCompra.PerformLayout();
            this.tpDetalleCompra.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRegistroCompra;
        private System.Windows.Forms.Panel pnlRegistroCompra;
        private System.Windows.Forms.Button btnRegistrarC;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txttotalapagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.GroupBox groupBoxProveedor;
        private System.Windows.Forms.TextBox txtRazonsocial;
        private System.Windows.Forms.TextBox txtdocproveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxCompra;
        private System.Windows.Forms.ComboBox cbotipodocumento;
        private System.Windows.Forms.TextBox txtFechaC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegistroCompra;
        private System.Windows.Forms.TabPage tpDetalleCompra;
        private System.Windows.Forms.TextBox txtidproveedor;
        private System.Windows.Forms.Button btnBuscarprov;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.Button btnbuscarproducto;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.TextBox txtcodproducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtpreciocompra;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciocompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDescargarPDF;
        private System.Windows.Forms.TextBox txtBuscarD;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.TextBox txtMontoTotalD;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnBorrarD;
        private System.Windows.Forms.Button btnBuscarD;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIdProveedorD;
        private System.Windows.Forms.TextBox txtRazonSocialD;
        private System.Windows.Forms.TextBox txtNumeroDocumentoProveedorD;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbTipoDocumentoD;
        private System.Windows.Forms.TextBox txtFechaD;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblDetalleCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompraD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotalD;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}