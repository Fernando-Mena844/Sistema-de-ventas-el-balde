namespace CapaVisual
{
    partial class frmAcercaDe
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
            this.lblAcercade = new System.Windows.Forms.Label();
            this.pnlSoporte = new System.Windows.Forms.Panel();
            this.btnDescargarPDF = new System.Windows.Forms.Button();
            this.lblSoporte = new System.Windows.Forms.Label();
            this.pnlSoporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAcercade
            // 
            this.lblAcercade.BackColor = System.Drawing.Color.Transparent;
            this.lblAcercade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcercade.Location = new System.Drawing.Point(26, 128);
            this.lblAcercade.Name = "lblAcercade";
            this.lblAcercade.Size = new System.Drawing.Size(658, 40);
            this.lblAcercade.TabIndex = 2;
            this.lblAcercade.Text = "Ante culaquier duda o problema, puedes consultar con nuestro manual de uso ubicad" +
    "o en el\r\n siguiente PDF.";
            // 
            // pnlSoporte
            // 
            this.pnlSoporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSoporte.BackColor = System.Drawing.Color.White;
            this.pnlSoporte.Controls.Add(this.btnDescargarPDF);
            this.pnlSoporte.Controls.Add(this.lblSoporte);
            this.pnlSoporte.Controls.Add(this.lblAcercade);
            this.pnlSoporte.Location = new System.Drawing.Point(51, 21);
            this.pnlSoporte.Name = "pnlSoporte";
            this.pnlSoporte.Size = new System.Drawing.Size(707, 413);
            this.pnlSoporte.TabIndex = 3;
            // 
            // btnDescargarPDF
            // 
            this.btnDescargarPDF.BackColor = System.Drawing.Color.LightGray;
            this.btnDescargarPDF.Location = new System.Drawing.Point(288, 278);
            this.btnDescargarPDF.Name = "btnDescargarPDF";
            this.btnDescargarPDF.Size = new System.Drawing.Size(119, 23);
            this.btnDescargarPDF.TabIndex = 15;
            this.btnDescargarPDF.Text = "Descargar a PDF";
            this.btnDescargarPDF.UseVisualStyleBackColor = false;
            this.btnDescargarPDF.Click += new System.EventHandler(this.btnDescargarPDF_Click);
            // 
            // lblSoporte
            // 
            this.lblSoporte.AutoSize = true;
            this.lblSoporte.BackColor = System.Drawing.Color.Transparent;
            this.lblSoporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoporte.Location = new System.Drawing.Point(301, 0);
            this.lblSoporte.Name = "lblSoporte";
            this.lblSoporte.Size = new System.Drawing.Size(106, 29);
            this.lblSoporte.TabIndex = 3;
            this.lblSoporte.Text = "Soporte";
            // 
            // frmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSoporte);
            this.Name = "frmAcercaDe";
            this.Text = "frmAcercaDe";
            this.pnlSoporte.ResumeLayout(false);
            this.pnlSoporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAcercade;
        private System.Windows.Forms.Panel pnlSoporte;
        private System.Windows.Forms.Label lblSoporte;
        private System.Windows.Forms.Button btnDescargarPDF;
    }
}