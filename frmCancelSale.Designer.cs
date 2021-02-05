namespace BlackBox
{
    partial class frmCancelSale
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCajero = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVentaTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumArt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkCancelado = new System.Windows.Forms.CheckBox();
            this.chkEnCorte = new System.Windows.Forms.CheckBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.lstArticulos = new System.Windows.Forms.ListBox();
            this.prtdImprimir = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Recibo";
            // 
            // txtRecibo
            // 
            this.txtRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecibo.Location = new System.Drawing.Point(158, 12);
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.Size = new System.Drawing.Size(98, 23);
            this.txtRecibo.TabIndex = 1;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(281, 12);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 2;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cajero";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCajero
            // 
            this.txtCajero.Enabled = false;
            this.txtCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCajero.Location = new System.Drawing.Point(6, 61);
            this.txtCajero.Name = "txtCajero";
            this.txtCajero.Size = new System.Drawing.Size(208, 21);
            this.txtCajero.TabIndex = 4;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(220, 61);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(136, 21);
            this.txtFecha.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha / Hora";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVentaTotal
            // 
            this.txtVentaTotal.Enabled = false;
            this.txtVentaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVentaTotal.Location = new System.Drawing.Point(92, 327);
            this.txtVentaTotal.Name = "txtVentaTotal";
            this.txtVentaTotal.Size = new System.Drawing.Size(83, 21);
            this.txtVentaTotal.TabIndex = 8;
            this.txtVentaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Importe Venta";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumArt
            // 
            this.txtNumArt.Enabled = false;
            this.txtNumArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumArt.Location = new System.Drawing.Point(281, 327);
            this.txtNumArt.Name = "txtNumArt";
            this.txtNumArt.Size = new System.Drawing.Size(75, 21);
            this.txtNumArt.TabIndex = 10;
            this.txtNumArt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(189, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Num. Articulos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkCancelado
            // 
            this.chkCancelado.AutoSize = true;
            this.chkCancelado.Enabled = false;
            this.chkCancelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCancelado.Location = new System.Drawing.Point(25, 359);
            this.chkCancelado.Name = "chkCancelado";
            this.chkCancelado.Size = new System.Drawing.Size(94, 19);
            this.chkCancelado.TabIndex = 11;
            this.chkCancelado.Text = "Cancelado";
            this.chkCancelado.UseVisualStyleBackColor = true;
            // 
            // chkEnCorte
            // 
            this.chkEnCorte.AutoSize = true;
            this.chkEnCorte.Enabled = false;
            this.chkEnCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnCorte.Location = new System.Drawing.Point(129, 359);
            this.chkEnCorte.Name = "chkEnCorte";
            this.chkEnCorte.Size = new System.Drawing.Size(81, 19);
            this.chkEnCorte.TabIndex = 12;
            this.chkEnCorte.Text = "En Corte";
            this.chkEnCorte.UseVisualStyleBackColor = true;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.cmdCancelar.Location = new System.Drawing.Point(281, 359);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 13;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // lstArticulos
            // 
            this.lstArticulos.FormattingEnabled = true;
            this.lstArticulos.Location = new System.Drawing.Point(6, 94);
            this.lstArticulos.Name = "lstArticulos";
            this.lstArticulos.Size = new System.Drawing.Size(349, 225);
            this.lstArticulos.TabIndex = 14;
            // 
            // frmCancelSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 389);
            this.Controls.Add(this.lstArticulos);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.chkEnCorte);
            this.Controls.Add(this.chkCancelado);
            this.Controls.Add(this.txtNumArt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVentaTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCajero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.txtRecibo);
            this.Controls.Add(this.label1);
            this.Name = "frmCancelSale";
            this.Text = "Cancelación de Recibo";
            this.Load += new System.EventHandler(this.frmCancelSale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCajero;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVentaTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumArt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkCancelado;
        private System.Windows.Forms.CheckBox chkEnCorte;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.ListBox lstArticulos;
        private System.Drawing.Printing.PrintDocument prtdImprimir;
    }
}