namespace BlackBox.Controls
{
    partial class pnlArtVendido
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblArticulo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblFondo = new System.Windows.Forms.Label();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblArticulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblArticulo.Location = new System.Drawing.Point(-2, 2);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(77, 25);
            this.lblArticulo.TabIndex = 0;
            this.lblArticulo.Text = "Articulo";
            this.lblArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblArticulo.Click += new System.EventHandler(this.lblArticulo_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrecio.Location = new System.Drawing.Point(212, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrecio.Size = new System.Drawing.Size(94, 25);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "$9192.00";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // lblFondo
            // 
            this.lblFondo.Location = new System.Drawing.Point(0, 0);
            this.lblFondo.Name = "lblFondo";
            this.lblFondo.Size = new System.Drawing.Size(309, 27);
            this.lblFondo.TabIndex = 2;
            this.lblFondo.Text = "label1";
            this.lblFondo.Click += new System.EventHandler(this.lblFondo_Click);
            // 
            // lblOpcion
            // 
            this.lblOpcion.BackColor = System.Drawing.Color.Transparent;
            this.lblOpcion.CausesValidation = false;
            this.lblOpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblOpcion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOpcion.Location = new System.Drawing.Point(-2, 27);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(308, 25);
            this.lblOpcion.TabIndex = 3;
            this.lblOpcion.Text = "Opcion";
            this.lblOpcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOpcion.Visible = false;
            this.lblOpcion.Click += new System.EventHandler(this.lblOpcion_Click);
            // 
            // pnlArtVendido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.lblFondo);
            this.Name = "pnlArtVendido";
            this.Size = new System.Drawing.Size(309, 55);
            this.Click += new System.EventHandler(this.pnlArtVendido_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblFondo;
        private System.Windows.Forms.Label lblOpcion;
    }
}
