namespace CapaVisual.Modales
{
    partial class mdCliente
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBorrarBusqueda = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.cmbBusca = new System.Windows.Forms.ComboBox();
            this.lblBusca = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnBorrarBusqueda);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.txtBusca);
            this.panel2.Controls.Add(this.cmbBusca);
            this.panel2.Controls.Add(this.lblBusca);
            this.panel2.Controls.Add(this.lblUsuarios);
            this.panel2.Location = new System.Drawing.Point(11, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 73);
            this.panel2.TabIndex = 10;
            // 
            // btnBorrarBusqueda
            // 
            this.btnBorrarBusqueda.BackColor = System.Drawing.Color.IndianRed;
            this.btnBorrarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnBorrarBusqueda.Location = new System.Drawing.Point(537, 31);
            this.btnBorrarBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarBusqueda.Name = "btnBorrarBusqueda";
            this.btnBorrarBusqueda.Size = new System.Drawing.Size(58, 25);
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
            this.btnBuscar.Location = new System.Drawing.Point(464, 31);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(58, 25);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(378, 31);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(79, 20);
            this.txtBusca.TabIndex = 3;
            // 
            // cmbBusca
            // 
            this.cmbBusca.FormattingEnabled = true;
            this.cmbBusca.Location = new System.Drawing.Point(262, 30);
            this.cmbBusca.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBusca.Name = "cmbBusca";
            this.cmbBusca.Size = new System.Drawing.Size(107, 21);
            this.cmbBusca.TabIndex = 2;
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Location = new System.Drawing.Point(200, 33);
            this.lblBusca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(58, 13);
            this.lblBusca.TabIndex = 1;
            this.lblBusca.Text = "Busca por:";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(15, 27);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(118, 20);
            this.lblUsuarios.TabIndex = 0;
            this.lblUsuarios.Text = "Lista Clientes";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroDocumento,
            this.Nombre});
            this.dgvdata.Location = new System.Drawing.Point(12, 99);
            this.dgvdata.Margin = new System.Windows.Forms.Padding(2);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowHeadersWidth = 62;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(641, 321);
            this.dgvdata.TabIndex = 11;
            this.dgvdata.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellDoubleClick);
            // 
            // NroDocumento
            // 
            this.NroDocumento.HeaderText = "Nro Documento";
            this.NroDocumento.MinimumWidth = 8;
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.ReadOnly = true;
            this.NroDocumento.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 180;
            // 
            // mdCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 431);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.panel2);
            this.Name = "mdCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdCliente";
            this.Load += new System.EventHandler(this.mdCliente_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBorrarBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.ComboBox cmbBusca;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}