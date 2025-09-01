namespace CapaVisual
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.tbcVentas = new System.Windows.Forms.TabControl();
            this.tpRegistrarVenta = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCrearVenta = new System.Windows.Forms.Button();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.txtPagaCon = new System.Windows.Forms.TextBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblPagaCon = new System.Windows.Forms.Label();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.btnbuscarproducto = new System.Windows.Forms.Button();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtcodproducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNuevodoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnBorrarC = new System.Windows.Forms.Button();
            this.btnBuscarC = new System.Windows.Forms.Button();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.gbInformacionCliente = new System.Windows.Forms.GroupBox();
            this.txtidproveedor = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtNombreClienteRegistroVenta = new System.Windows.Forms.TextBox();
            this.txtDocClienteRegistroVenta = new System.Windows.Forms.TextBox();
            this.lblNombreClienteVentaRegistro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxVenta = new System.Windows.Forms.GroupBox();
            this.cbotipodocumento = new System.Windows.Forms.ComboBox();
            this.txtFechaC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDetalleVenta = new System.Windows.Forms.Label();
            this.tpVerDetalleVenta = new System.Windows.Forms.TabPage();
            this.pnlDetalleVenta = new System.Windows.Forms.Panel();
            this.btnDescargarPDF = new System.Windows.Forms.Button();
            this.txtBuscarD = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMontoTotalD = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnBorrarD = new System.Windows.Forms.Button();
            this.btnBuscarD = new System.Windows.Forms.Button();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompraD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotalD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbInfoClienteDocumento = new System.Windows.Forms.GroupBox();
            this.txtIdProveedorD = new System.Windows.Forms.TextBox();
            this.txtNombreClienteDocumentoVenta = new System.Windows.Forms.TextBox();
            this.txtNumeroDocumentoCliente = new System.Windows.Forms.TextBox();
            this.lblNombreClienteVentaDocumento = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.gbInfoVentaDocumento = new System.Windows.Forms.GroupBox();
            this.cmbTipoDocumentoD = new System.Windows.Forms.ComboBox();
            this.txtFechaD = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblDetalleVentaDocumento = new System.Windows.Forms.Label();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbcVentas.SuspendLayout();
            this.tpRegistrarVenta.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.gbInformacionCliente.SuspendLayout();
            this.groupBoxVenta.SuspendLayout();
            this.tpVerDetalleVenta.SuspendLayout();
            this.pnlDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            this.gbInfoClienteDocumento.SuspendLayout();
            this.gbInfoVentaDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcVentas
            // 
            this.tbcVentas.Controls.Add(this.tpRegistrarVenta);
            this.tbcVentas.Controls.Add(this.tpVerDetalleVenta);
            this.tbcVentas.Location = new System.Drawing.Point(0, 1);
            this.tbcVentas.Name = "tbcVentas";
            this.tbcVentas.SelectedIndex = 0;
            this.tbcVentas.Size = new System.Drawing.Size(886, 560);
            this.tbcVentas.TabIndex = 0;
            // 
            // tpRegistrarVenta
            // 
            this.tpRegistrarVenta.Controls.Add(this.panel2);
            this.tpRegistrarVenta.Location = new System.Drawing.Point(4, 22);
            this.tpRegistrarVenta.Name = "tpRegistrarVenta";
            this.tpRegistrarVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistrarVenta.Size = new System.Drawing.Size(878, 534);
            this.tpRegistrarVenta.TabIndex = 0;
            this.tpRegistrarVenta.Text = "Registrar venta";
            this.tpRegistrarVenta.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.BtnCrearVenta);
            this.panel2.Controls.Add(this.txtCambio);
            this.panel2.Controls.Add(this.txtPagaCon);
            this.panel2.Controls.Add(this.txtTotalPagar);
            this.panel2.Controls.Add(this.lblCambio);
            this.panel2.Controls.Add(this.lblPagaCon);
            this.panel2.Controls.Add(this.lblTotalAPagar);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.txtNuevodoc);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnagregar);
            this.panel2.Controls.Add(this.btnBorrarC);
            this.panel2.Controls.Add(this.btnBuscarC);
            this.panel2.Controls.Add(this.dgvdata);
            this.panel2.Controls.Add(this.gbInformacionCliente);
            this.panel2.Controls.Add(this.groupBoxVenta);
            this.panel2.Controls.Add(this.lblDetalleVenta);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 531);
            this.panel2.TabIndex = 8;
            // 
            // BtnCrearVenta
            // 
            this.BtnCrearVenta.BackColor = System.Drawing.Color.White;
            this.BtnCrearVenta.Image = ((System.Drawing.Image)(resources.GetObject("BtnCrearVenta.Image")));
            this.BtnCrearVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCrearVenta.Location = new System.Drawing.Point(640, 434);
            this.BtnCrearVenta.Name = "BtnCrearVenta";
            this.BtnCrearVenta.Size = new System.Drawing.Size(93, 35);
            this.BtnCrearVenta.TabIndex = 22;
            this.BtnCrearVenta.Text = "Crear venta";
            this.BtnCrearVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCrearVenta.UseVisualStyleBackColor = false;
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(640, 403);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(100, 20);
            this.txtCambio.TabIndex = 21;
            // 
            // txtPagaCon
            // 
            this.txtPagaCon.Location = new System.Drawing.Point(640, 348);
            this.txtPagaCon.Name = "txtPagaCon";
            this.txtPagaCon.Size = new System.Drawing.Size(100, 20);
            this.txtPagaCon.TabIndex = 19;
            this.txtPagaCon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPagaCon_KeyDown);
            this.txtPagaCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagaCon_KeyPress);
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(640, 296);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPagar.TabIndex = 18;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(637, 387);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(45, 13);
            this.lblCambio.TabIndex = 17;
            this.lblCambio.Text = "Cambio:";
            // 
            // lblPagaCon
            // 
            this.lblPagaCon.AutoSize = true;
            this.lblPagaCon.Location = new System.Drawing.Point(637, 332);
            this.lblPagaCon.Name = "lblPagaCon";
            this.lblPagaCon.Size = new System.Drawing.Size(56, 13);
            this.lblPagaCon.TabIndex = 16;
            this.lblPagaCon.Text = "Paga con:";
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Location = new System.Drawing.Point(637, 280);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(73, 13);
            this.lblTotalAPagar.TabIndex = 15;
            this.lblTotalAPagar.Text = "Total a pagar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtstock);
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.txtidproducto);
            this.groupBox1.Controls.Add(this.btnbuscarproducto);
            this.groupBox1.Controls.Add(this.txtproducto);
            this.groupBox1.Controls.Add(this.txtcodproducto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(19, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 87);
            this.groupBox1.TabIndex = 7;
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
            this.txtcantidad.Size = new System.Drawing.Size(91, 20);
            this.txtcantidad.TabIndex = 13;
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
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Cantidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(502, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Stock";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(393, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Precio";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(505, 47);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(103, 20);
            this.txtstock.TabIndex = 8;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(396, 47);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(103, 20);
            this.txtprecio.TabIndex = 7;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(110, 23);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(36, 20);
            this.txtidproducto.TabIndex = 6;
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnbuscarproducto.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscarproducto.Image")));
            this.btnbuscarproducto.Location = new System.Drawing.Point(152, 44);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Size = new System.Drawing.Size(22, 23);
            this.btnbuscarproducto.TabIndex = 5;
            this.btnbuscarproducto.UseVisualStyleBackColor = true;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(197, 47);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(162, 20);
            this.txtproducto.TabIndex = 4;
            // 
            // txtcodproducto
            // 
            this.txtcodproducto.Location = new System.Drawing.Point(9, 45);
            this.txtcodproducto.Name = "txtcodproducto";
            this.txtcodproducto.Size = new System.Drawing.Size(137, 20);
            this.txtcodproducto.TabIndex = 2;
            this.txtcodproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodproducto_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cod. Producto";
            // 
            // txtNuevodoc
            // 
            this.txtNuevodoc.Location = new System.Drawing.Point(374, 11);
            this.txtNuevodoc.Name = "txtNuevodoc";
            this.txtNuevodoc.Size = new System.Drawing.Size(144, 20);
            this.txtNuevodoc.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nuevo Documento";
            // 
            // btnagregar
            // 
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagregar.Location = new System.Drawing.Point(25, 243);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 31);
            this.btnagregar.TabIndex = 13;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnBorrarC
            // 
            this.btnBorrarC.BackColor = System.Drawing.Color.IndianRed;
            this.btnBorrarC.ForeColor = System.Drawing.Color.White;
            this.btnBorrarC.Location = new System.Drawing.Point(631, 11);
            this.btnBorrarC.Name = "btnBorrarC";
            this.btnBorrarC.Size = new System.Drawing.Size(89, 23);
            this.btnBorrarC.TabIndex = 12;
            this.btnBorrarC.Text = "Borrar";
            this.btnBorrarC.UseVisualStyleBackColor = false;
            // 
            // btnBuscarC
            // 
            this.btnBuscarC.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBuscarC.ForeColor = System.Drawing.Color.White;
            this.btnBuscarC.Location = new System.Drawing.Point(536, 11);
            this.btnBuscarC.Name = "btnBuscarC";
            this.btnBuscarC.Size = new System.Drawing.Size(89, 23);
            this.btnBuscarC.TabIndex = 11;
            this.btnBuscarC.Text = "Buscar";
            this.btnBuscarC.UseVisualStyleBackColor = false;
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.producto,
            this.precioventa,
            this.cantidad,
            this.subtotal,
            this.btnEliminar});
            this.dgvdata.Location = new System.Drawing.Point(19, 280);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowHeadersWidth = 51;
            this.dgvdata.Size = new System.Drawing.Size(606, 161);
            this.dgvdata.TabIndex = 5;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // gbInformacionCliente
            // 
            this.gbInformacionCliente.Controls.Add(this.txtidproveedor);
            this.gbInformacionCliente.Controls.Add(this.btnBuscarCliente);
            this.gbInformacionCliente.Controls.Add(this.txtNombreClienteRegistroVenta);
            this.gbInformacionCliente.Controls.Add(this.txtDocClienteRegistroVenta);
            this.gbInformacionCliente.Controls.Add(this.lblNombreClienteVentaRegistro);
            this.gbInformacionCliente.Controls.Add(this.label7);
            this.gbInformacionCliente.Location = new System.Drawing.Point(374, 46);
            this.gbInformacionCliente.Name = "gbInformacionCliente";
            this.gbInformacionCliente.Size = new System.Drawing.Size(375, 87);
            this.gbInformacionCliente.TabIndex = 4;
            this.gbInformacionCliente.TabStop = false;
            this.gbInformacionCliente.Text = "Información del cliente";
            // 
            // txtidproveedor
            // 
            this.txtidproveedor.Location = new System.Drawing.Point(309, 25);
            this.txtidproveedor.Name = "txtidproveedor";
            this.txtidproveedor.Size = new System.Drawing.Size(50, 20);
            this.txtidproveedor.TabIndex = 6;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(152, 44);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(22, 23);
            this.btnBuscarCliente.TabIndex = 5;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtNombreClienteRegistroVenta
            // 
            this.txtNombreClienteRegistroVenta.Location = new System.Drawing.Point(197, 47);
            this.txtNombreClienteRegistroVenta.Name = "txtNombreClienteRegistroVenta";
            this.txtNombreClienteRegistroVenta.Size = new System.Drawing.Size(162, 20);
            this.txtNombreClienteRegistroVenta.TabIndex = 4;
            // 
            // txtDocClienteRegistroVenta
            // 
            this.txtDocClienteRegistroVenta.Location = new System.Drawing.Point(9, 45);
            this.txtDocClienteRegistroVenta.Name = "txtDocClienteRegistroVenta";
            this.txtDocClienteRegistroVenta.Size = new System.Drawing.Size(137, 20);
            this.txtDocClienteRegistroVenta.TabIndex = 2;
            // 
            // lblNombreClienteVentaRegistro
            // 
            this.lblNombreClienteVentaRegistro.AutoSize = true;
            this.lblNombreClienteVentaRegistro.Location = new System.Drawing.Point(194, 30);
            this.lblNombreClienteVentaRegistro.Name = "lblNombreClienteVentaRegistro";
            this.lblNombreClienteVentaRegistro.Size = new System.Drawing.Size(44, 13);
            this.lblNombreClienteVentaRegistro.TabIndex = 1;
            this.lblNombreClienteVentaRegistro.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Numero Documento";
            // 
            // groupBoxVenta
            // 
            this.groupBoxVenta.Controls.Add(this.cbotipodocumento);
            this.groupBoxVenta.Controls.Add(this.txtFechaC);
            this.groupBoxVenta.Controls.Add(this.label3);
            this.groupBoxVenta.Controls.Add(this.label2);
            this.groupBoxVenta.Location = new System.Drawing.Point(19, 46);
            this.groupBoxVenta.Name = "groupBoxVenta";
            this.groupBoxVenta.Size = new System.Drawing.Size(327, 87);
            this.groupBoxVenta.TabIndex = 1;
            this.groupBoxVenta.TabStop = false;
            this.groupBoxVenta.Text = "Informacón de la compra";
            // 
            // cbotipodocumento
            // 
            this.cbotipodocumento.FormattingEnabled = true;
            this.cbotipodocumento.Location = new System.Drawing.Point(152, 45);
            this.cbotipodocumento.Name = "cbotipodocumento";
            this.cbotipodocumento.Size = new System.Drawing.Size(159, 21);
            this.cbotipodocumento.TabIndex = 3;
            // 
            // txtFechaC
            // 
            this.txtFechaC.Location = new System.Drawing.Point(9, 45);
            this.txtFechaC.Name = "txtFechaC";
            this.txtFechaC.Size = new System.Drawing.Size(100, 20);
            this.txtFechaC.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha";
            // 
            // lblDetalleVenta
            // 
            this.lblDetalleVenta.AutoSize = true;
            this.lblDetalleVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleVenta.Location = new System.Drawing.Point(12, 9);
            this.lblDetalleVenta.Name = "lblDetalleVenta";
            this.lblDetalleVenta.Size = new System.Drawing.Size(140, 20);
            this.lblDetalleVenta.TabIndex = 0;
            this.lblDetalleVenta.Text = "Detalle de venta";
            // 
            // tpVerDetalleVenta
            // 
            this.tpVerDetalleVenta.Controls.Add(this.pnlDetalleVenta);
            this.tpVerDetalleVenta.Location = new System.Drawing.Point(4, 22);
            this.tpVerDetalleVenta.Name = "tpVerDetalleVenta";
            this.tpVerDetalleVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tpVerDetalleVenta.Size = new System.Drawing.Size(878, 534);
            this.tpVerDetalleVenta.TabIndex = 1;
            this.tpVerDetalleVenta.Text = "Ver detalle";
            this.tpVerDetalleVenta.UseVisualStyleBackColor = true;
            // 
            // pnlDetalleVenta
            // 
            this.pnlDetalleVenta.BackColor = System.Drawing.Color.White;
            this.pnlDetalleVenta.Controls.Add(this.btnDescargarPDF);
            this.pnlDetalleVenta.Controls.Add(this.txtBuscarD);
            this.pnlDetalleVenta.Controls.Add(this.label18);
            this.pnlDetalleVenta.Controls.Add(this.txtMontoTotalD);
            this.pnlDetalleVenta.Controls.Add(this.label19);
            this.pnlDetalleVenta.Controls.Add(this.btnBorrarD);
            this.pnlDetalleVenta.Controls.Add(this.btnBuscarD);
            this.pnlDetalleVenta.Controls.Add(this.dgvDetalleCompra);
            this.pnlDetalleVenta.Controls.Add(this.gbInfoClienteDocumento);
            this.pnlDetalleVenta.Controls.Add(this.gbInfoVentaDocumento);
            this.pnlDetalleVenta.Controls.Add(this.lblDetalleVentaDocumento);
            this.pnlDetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalleVenta.Location = new System.Drawing.Point(3, 3);
            this.pnlDetalleVenta.Name = "pnlDetalleVenta";
            this.pnlDetalleVenta.Size = new System.Drawing.Size(872, 528);
            this.pnlDetalleVenta.TabIndex = 9;
            // 
            // btnDescargarPDF
            // 
            this.btnDescargarPDF.Location = new System.Drawing.Point(654, 486);
            this.btnDescargarPDF.Name = "btnDescargarPDF";
            this.btnDescargarPDF.Size = new System.Drawing.Size(119, 23);
            this.btnDescargarPDF.TabIndex = 14;
            this.btnDescargarPDF.Text = "Descargara en PDF";
            this.btnDescargarPDF.UseVisualStyleBackColor = true;
            // 
            // txtBuscarD
            // 
            this.txtBuscarD.Location = new System.Drawing.Point(374, 11);
            this.txtBuscarD.Name = "txtBuscarD";
            this.txtBuscarD.Size = new System.Drawing.Size(144, 20);
            this.txtBuscarD.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(271, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Nuevo Documento";
            // 
            // txtMontoTotalD
            // 
            this.txtMontoTotalD.Location = new System.Drawing.Point(88, 488);
            this.txtMontoTotalD.Name = "txtMontoTotalD";
            this.txtMontoTotalD.Size = new System.Drawing.Size(137, 20);
            this.txtMontoTotalD.TabIndex = 9;
            this.txtMontoTotalD.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 491);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "Monto Total";
            // 
            // btnBorrarD
            // 
            this.btnBorrarD.BackColor = System.Drawing.Color.IndianRed;
            this.btnBorrarD.ForeColor = System.Drawing.Color.White;
            this.btnBorrarD.Location = new System.Drawing.Point(636, 9);
            this.btnBorrarD.Name = "btnBorrarD";
            this.btnBorrarD.Size = new System.Drawing.Size(89, 23);
            this.btnBorrarD.TabIndex = 12;
            this.btnBorrarD.Text = "Borrar";
            this.btnBorrarD.UseVisualStyleBackColor = false;
            // 
            // btnBuscarD
            // 
            this.btnBuscarD.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBuscarD.ForeColor = System.Drawing.Color.White;
            this.btnBuscarD.Location = new System.Drawing.Point(542, 10);
            this.btnBuscarD.Name = "btnBuscarD";
            this.btnBuscarD.Size = new System.Drawing.Size(89, 23);
            this.btnBuscarD.TabIndex = 11;
            this.btnBuscarD.Text = "Buscar";
            this.btnBuscarD.UseVisualStyleBackColor = false;
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ProductoD,
            this.PrecioCompraD,
            this.dataGridViewTextBoxColumn4,
            this.CantidadD,
            this.SubTotalD,
            this.dataGridViewButtonColumn1});
            this.dgvDetalleCompra.Location = new System.Drawing.Point(19, 163);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.RowHeadersWidth = 51;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(754, 296);
            this.dgvDetalleCompra.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "IdProducto";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // ProductoD
            // 
            this.ProductoD.HeaderText = "Producto";
            this.ProductoD.MinimumWidth = 6;
            this.ProductoD.Name = "ProductoD";
            this.ProductoD.Width = 125;
            // 
            // PrecioCompraD
            // 
            this.PrecioCompraD.HeaderText = "PrecioCompra";
            this.PrecioCompraD.MinimumWidth = 6;
            this.PrecioCompraD.Name = "PrecioCompraD";
            this.PrecioCompraD.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio Venta";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // CantidadD
            // 
            this.CantidadD.HeaderText = "Cantidad";
            this.CantidadD.MinimumWidth = 6;
            this.CantidadD.Name = "CantidadD";
            this.CantidadD.Width = 125;
            // 
            // SubTotalD
            // 
            this.SubTotalD.HeaderText = "Sub total";
            this.SubTotalD.MinimumWidth = 6;
            this.SubTotalD.Name = "SubTotalD";
            this.SubTotalD.Width = 125;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.MinimumWidth = 8;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Width = 150;
            // 
            // gbInfoClienteDocumento
            // 
            this.gbInfoClienteDocumento.Controls.Add(this.txtIdProveedorD);
            this.gbInfoClienteDocumento.Controls.Add(this.txtNombreClienteDocumentoVenta);
            this.gbInfoClienteDocumento.Controls.Add(this.txtNumeroDocumentoCliente);
            this.gbInfoClienteDocumento.Controls.Add(this.lblNombreClienteVentaDocumento);
            this.gbInfoClienteDocumento.Controls.Add(this.label21);
            this.gbInfoClienteDocumento.Location = new System.Drawing.Point(374, 46);
            this.gbInfoClienteDocumento.Name = "gbInfoClienteDocumento";
            this.gbInfoClienteDocumento.Size = new System.Drawing.Size(350, 87);
            this.gbInfoClienteDocumento.TabIndex = 4;
            this.gbInfoClienteDocumento.TabStop = false;
            this.gbInfoClienteDocumento.Text = "Información del cliente";
            // 
            // txtIdProveedorD
            // 
            this.txtIdProveedorD.Location = new System.Drawing.Point(280, 25);
            this.txtIdProveedorD.Name = "txtIdProveedorD";
            this.txtIdProveedorD.Size = new System.Drawing.Size(50, 20);
            this.txtIdProveedorD.TabIndex = 6;
            // 
            // txtNombreClienteDocumentoVenta
            // 
            this.txtNombreClienteDocumentoVenta.Location = new System.Drawing.Point(168, 47);
            this.txtNombreClienteDocumentoVenta.Name = "txtNombreClienteDocumentoVenta";
            this.txtNombreClienteDocumentoVenta.Size = new System.Drawing.Size(162, 20);
            this.txtNombreClienteDocumentoVenta.TabIndex = 4;
            // 
            // txtNumeroDocumentoCliente
            // 
            this.txtNumeroDocumentoCliente.Location = new System.Drawing.Point(9, 45);
            this.txtNumeroDocumentoCliente.Name = "txtNumeroDocumentoCliente";
            this.txtNumeroDocumentoCliente.Size = new System.Drawing.Size(137, 20);
            this.txtNumeroDocumentoCliente.TabIndex = 2;
            // 
            // lblNombreClienteVentaDocumento
            // 
            this.lblNombreClienteVentaDocumento.AutoSize = true;
            this.lblNombreClienteVentaDocumento.Location = new System.Drawing.Point(165, 30);
            this.lblNombreClienteVentaDocumento.Name = "lblNombreClienteVentaDocumento";
            this.lblNombreClienteVentaDocumento.Size = new System.Drawing.Size(44, 13);
            this.lblNombreClienteVentaDocumento.TabIndex = 1;
            this.lblNombreClienteVentaDocumento.Text = "Nombre";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 29);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Numero Documento";
            // 
            // gbInfoVentaDocumento
            // 
            this.gbInfoVentaDocumento.Controls.Add(this.cmbTipoDocumentoD);
            this.gbInfoVentaDocumento.Controls.Add(this.txtFechaD);
            this.gbInfoVentaDocumento.Controls.Add(this.label22);
            this.gbInfoVentaDocumento.Controls.Add(this.label23);
            this.gbInfoVentaDocumento.Location = new System.Drawing.Point(19, 46);
            this.gbInfoVentaDocumento.Name = "gbInfoVentaDocumento";
            this.gbInfoVentaDocumento.Size = new System.Drawing.Size(327, 87);
            this.gbInfoVentaDocumento.TabIndex = 1;
            this.gbInfoVentaDocumento.TabStop = false;
            this.gbInfoVentaDocumento.Text = "Información de la venta";
            // 
            // cmbTipoDocumentoD
            // 
            this.cmbTipoDocumentoD.FormattingEnabled = true;
            this.cmbTipoDocumentoD.Location = new System.Drawing.Point(152, 45);
            this.cmbTipoDocumentoD.Name = "cmbTipoDocumentoD";
            this.cmbTipoDocumentoD.Size = new System.Drawing.Size(159, 21);
            this.cmbTipoDocumentoD.TabIndex = 3;
            // 
            // txtFechaD
            // 
            this.txtFechaD.Location = new System.Drawing.Point(9, 45);
            this.txtFechaD.Name = "txtFechaD";
            this.txtFechaD.Size = new System.Drawing.Size(100, 20);
            this.txtFechaD.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(149, 29);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Tipo documento";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Fecha";
            // 
            // lblDetalleVentaDocumento
            // 
            this.lblDetalleVentaDocumento.AutoSize = true;
            this.lblDetalleVentaDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleVentaDocumento.Location = new System.Drawing.Point(12, 9);
            this.lblDetalleVentaDocumento.Name = "lblDetalleVentaDocumento";
            this.lblDetalleVentaDocumento.Size = new System.Drawing.Size(159, 20);
            this.lblDetalleVentaDocumento.TabIndex = 0;
            this.lblDetalleVentaDocumento.Text = "Detalle de la venta";
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 125;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.Width = 125;
            // 
            // precioventa
            // 
            this.precioventa.HeaderText = "Precio Venta";
            this.precioventa.MinimumWidth = 6;
            this.precioventa.Name = "precioventa";
            this.precioventa.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 125;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Sub total";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.Width = 125;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.MinimumWidth = 8;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Width = 150;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(892, 563);
            this.Controls.Add(this.tbcVentas);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.tbcVentas.ResumeLayout(false);
            this.tpRegistrarVenta.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.gbInformacionCliente.ResumeLayout(false);
            this.gbInformacionCliente.PerformLayout();
            this.groupBoxVenta.ResumeLayout(false);
            this.groupBoxVenta.PerformLayout();
            this.tpVerDetalleVenta.ResumeLayout(false);
            this.pnlDetalleVenta.ResumeLayout(false);
            this.pnlDetalleVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.gbInfoClienteDocumento.ResumeLayout(false);
            this.gbInfoClienteDocumento.PerformLayout();
            this.gbInfoVentaDocumento.ResumeLayout(false);
            this.gbInfoVentaDocumento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcVentas;
        private System.Windows.Forms.TabPage tpRegistrarVenta;
        private System.Windows.Forms.TabPage tpVerDetalleVenta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.Button btnbuscarproducto;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.TextBox txtcodproducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNuevodoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnBorrarC;
        private System.Windows.Forms.Button btnBuscarC;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.GroupBox gbInformacionCliente;
        private System.Windows.Forms.TextBox txtidproveedor;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtNombreClienteRegistroVenta;
        private System.Windows.Forms.TextBox txtDocClienteRegistroVenta;
        private System.Windows.Forms.Label lblNombreClienteVentaRegistro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxVenta;
        private System.Windows.Forms.ComboBox cbotipodocumento;
        private System.Windows.Forms.TextBox txtFechaC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDetalleVenta;
        private System.Windows.Forms.Panel pnlDetalleVenta;
        private System.Windows.Forms.Button btnDescargarPDF;
        private System.Windows.Forms.TextBox txtBuscarD;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMontoTotalD;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnBorrarD;
        private System.Windows.Forms.Button btnBuscarD;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompraD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotalD;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.GroupBox gbInfoClienteDocumento;
        private System.Windows.Forms.TextBox txtIdProveedorD;
        private System.Windows.Forms.TextBox txtNombreClienteDocumentoVenta;
        private System.Windows.Forms.TextBox txtNumeroDocumentoCliente;
        private System.Windows.Forms.Label lblNombreClienteVentaDocumento;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox gbInfoVentaDocumento;
        private System.Windows.Forms.ComboBox cmbTipoDocumentoD;
        private System.Windows.Forms.TextBox txtFechaD;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblDetalleVentaDocumento;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblPagaCon;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.TextBox txtPagaCon;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Button BtnCrearVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}