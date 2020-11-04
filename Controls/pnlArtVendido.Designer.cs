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
            this.SuspendLayout();
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblArticulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblArticulo.Location = new System.Drawing.Point(3, 0);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(77, 25);
            this.lblArticulo.TabIndex = 0;
            this.lblArticulo.Text = "Articulo";
            this.lblArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPrecio.Location = new System.Drawing.Point(199, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrecio.Size = new System.Drawing.Size(115, 21);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "$7,892.00";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlArtVendido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblArticulo);
            this.Name = "pnlArtVendido";
            this.Size = new System.Drawing.Size(309, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblPrecio;
    }
}
