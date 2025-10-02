namespace CapaVisual
{
    partial class frmNegocio
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
            this.pnlNegocio = new System.Windows.Forms.Panel();
            this.pbLogoNegocio = new System.Windows.Forms.PictureBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnSubirLogo = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.txtNombreNegocio = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNIT = new System.Windows.Forms.Label();
            this.lblNombreNegocio = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblDetalleNegocio = new System.Windows.Forms.Label();
            this.pnlNegocio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoNegocio)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNegocio
            // 
            this.pnlNegocio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNegocio.BackColor = System.Drawing.Color.White;
            this.pnlNegocio.Controls.Add(this.pbLogoNegocio);
            this.pnlNegocio.Controls.Add(this.btnGuardarCambios);
            this.pnlNegocio.Controls.Add(this.btnSubirLogo);
            this.pnlNegocio.Controls.Add(this.txtDireccion);
            this.pnlNegocio.Controls.Add(this.txtNIT);
            this.pnlNegocio.Controls.Add(this.txtNombreNegocio);
            this.pnlNegocio.Controls.Add(this.lblDireccion);
            this.pnlNegocio.Controls.Add(this.lblNIT);
            this.pnlNegocio.Controls.Add(this.lblNombreNegocio);
            this.pnlNegocio.Controls.Add(this.lblLogo);
            this.pnlNegocio.Controls.Add(this.lblDetalleNegocio);
            this.pnlNegocio.Location = new System.Drawing.Point(182, 36);
            this.pnlNegocio.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNegocio.Name = "pnlNegocio";
            this.pnlNegocio.Size = new System.Drawing.Size(435, 379);
            this.pnlNegocio.TabIndex = 1;
            // 
            // pbLogoNegocio
            // 
            this.pbLogoNegocio.Location = new System.Drawing.Point(24, 63);
            this.pbLogoNegocio.Name = "pbLogoNegocio";
            this.pbLogoNegocio.Size = new System.Drawing.Size(135, 135);
            this.pbLogoNegocio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoNegocio.TabIndex = 10;
            this.pbLogoNegocio.TabStop = false;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnGuardarCambios.Image = global::CapaVisual.Properties.Resources.save_icon;
            this.btnGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCambios.Location = new System.Drawing.Point(220, 240);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(150, 29);
            this.btnGuardarCambios.TabIndex = 9;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnSubirLogo
            // 
            this.btnSubirLogo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSubirLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSubirLogo.Image = global::CapaVisual.Properties.Resources.upload;
            this.btnSubirLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubirLogo.Location = new System.Drawing.Point(24, 240);
            this.btnSubirLogo.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubirLogo.Name = "btnSubirLogo";
            this.btnSubirLogo.Size = new System.Drawing.Size(145, 29);
            this.btnSubirLogo.TabIndex = 1;
            this.btnSubirLogo.Text = "Subir";
            this.btnSubirLogo.UseVisualStyleBackColor = false;
            this.btnSubirLogo.Click += new System.EventHandler(this.btnSubirLogo_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtDireccion.Location = new System.Drawing.Point(220, 171);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDireccion.Size = new System.Drawing.Size(140, 60);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtNIT
            // 
            this.txtNIT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNIT.Location = new System.Drawing.Point(220, 119);
            this.txtNIT.Margin = new System.Windows.Forms.Padding(2);
            this.txtNIT.MaxLength = 17;
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(140, 21);
            this.txtNIT.TabIndex = 6;
            this.txtNIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIT_KeyPress);
            // 
            // txtNombreNegocio
            // 
            this.txtNombreNegocio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNombreNegocio.Location = new System.Drawing.Point(220, 63);
            this.txtNombreNegocio.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreNegocio.MaxLength = 20;
            this.txtNombreNegocio.Name = "txtNombreNegocio";
            this.txtNombreNegocio.ShortcutsEnabled = false;
            this.txtNombreNegocio.Size = new System.Drawing.Size(140, 21);
            this.txtNombreNegocio.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDireccion.Location = new System.Drawing.Point(218, 156);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(59, 15);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNIT
            // 
            this.lblNIT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNIT.AutoSize = true;
            this.lblNIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNIT.Location = new System.Drawing.Point(218, 104);
            this.lblNIT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNIT.Name = "lblNIT";
            this.lblNIT.Size = new System.Drawing.Size(26, 15);
            this.lblNIT.TabIndex = 3;
            this.lblNIT.Text = "NIT";
            // 
            // lblNombreNegocio
            // 
            this.lblNombreNegocio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreNegocio.AutoSize = true;
            this.lblNombreNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNombreNegocio.Location = new System.Drawing.Point(218, 48);
            this.lblNombreNegocio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreNegocio.Name = "lblNombreNegocio";
            this.lblNombreNegocio.Size = new System.Drawing.Size(119, 15);
            this.lblNombreNegocio.TabIndex = 2;
            this.lblNombreNegocio.Text = "Nombre del negocio";
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblLogo.Location = new System.Drawing.Point(21, 48);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(35, 15);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Logo";
            // 
            // lblDetalleNegocio
            // 
            this.lblDetalleNegocio.AutoSize = true;
            this.lblDetalleNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleNegocio.Location = new System.Drawing.Point(21, 10);
            this.lblDetalleNegocio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetalleNegocio.Name = "lblDetalleNegocio";
            this.lblDetalleNegocio.Size = new System.Drawing.Size(177, 20);
            this.lblDetalleNegocio.TabIndex = 0;
            this.lblDetalleNegocio.Text = "Detalles del  negocio";
            // 
            // frmNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlNegocio);
            this.Name = "frmNegocio";
            this.Text = "frmNegocio";
            this.Load += new System.EventHandler(this.frmNegocio_Load);
            this.pnlNegocio.ResumeLayout(false);
            this.pnlNegocio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoNegocio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNegocio;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnSubirLogo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.TextBox txtNombreNegocio;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNIT;
        private System.Windows.Forms.Label lblNombreNegocio;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblDetalleNegocio;
        private System.Windows.Forms.PictureBox pbLogoNegocio;
    }
}