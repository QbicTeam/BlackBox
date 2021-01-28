namespace BlackBox
{
    partial class frmCortes
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
            this.cboReportes = new System.Windows.Forms.ComboBox();
            this.grdVentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdEjecutarRep = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCajeros = new System.Windows.Forms.ComboBox();
            this.Cajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnCorte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancelado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCorteZ = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCorteZ)).BeginInit();
            this.SuspendLayout();
            // 
            // cboReportes
            // 
            this.cboReportes.FormattingEnabled = true;
            this.cboReportes.Items.AddRange(new object[] {
            "",
            "Ventas (Todas)",
            "Por Cajero (Corte)",
            "Ventas sin Corte",
            "Corte Z"});
            this.cboReportes.Location = new System.Drawing.Point(82, 12);
            this.cboReportes.Name = "cboReportes";
            this.cboReportes.Size = new System.Drawing.Size(145, 21);
            this.cboReportes.TabIndex = 0;
            this.cboReportes.SelectedIndexChanged += new System.EventHandler(this.cboReportes_SelectedIndexChanged);
            // 
            // grdVentas
            // 
            this.grdVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cajero,
            this.Recibo,
            this.CantArt,
            this.Total,
            this.EnCorte,
            this.Cancelado});
            this.grdVentas.Location = new System.Drawing.Point(12, 65);
            this.grdVentas.Name = "grdVentas";
            this.grdVentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdVentas.Size = new System.Drawing.Size(703, 428);
            this.grdVentas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reportes";
            // 
            // cmdEjecutarRep
            // 
            this.cmdEjecutarRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEjecutarRep.Location = new System.Drawing.Point(269, 22);
            this.cmdEjecutarRep.Name = "cmdEjecutarRep";
            this.cmdEjecutarRep.Size = new System.Drawing.Size(149, 31);
            this.cmdEjecutarRep.TabIndex = 3;
            this.cmdEjecutarRep.Text = "Ejecutar Reporte";
            this.cmdEjecutarRep.UseVisualStyleBackColor = true;
            this.cmdEjecutarRep.Click += new System.EventHandler(this.cmdEjecutarRep_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Location = new System.Drawing.Point(434, 22);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(91, 31);
            this.cmdCerrar.TabIndex = 4;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cajeros";
            // 
            // cboCajeros
            // 
            this.cboCajeros.FormattingEnabled = true;
            this.cboCajeros.Location = new System.Drawing.Point(82, 41);
            this.cboCajeros.Name = "cboCajeros";
            this.cboCajeros.Size = new System.Drawing.Size(164, 21);
            this.cboCajeros.TabIndex = 6;
            this.cboCajeros.SelectedIndexChanged += new System.EventHandler(this.cboCajeros_SelectedIndexChanged);
            // 
            // Cajero
            // 
            this.Cajero.DataPropertyName = "Cajero";
            this.Cajero.HeaderText = "Cajero";
            this.Cajero.Name = "Cajero";
            this.Cajero.ReadOnly = true;
            // 
            // Recibo
            // 
            this.Recibo.DataPropertyName = "Recibo";
            this.Recibo.HeaderText = "Recibo";
            this.Recibo.Name = "Recibo";
            this.Recibo.ReadOnly = true;
            // 
            // CantArt
            // 
            this.CantArt.DataPropertyName = "CantidadArticulos";
            this.CantArt.HeaderText = "Cant. Art.";
            this.CantArt.Name = "CantArt";
            this.CantArt.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // EnCorte
            // 
            this.EnCorte.DataPropertyName = "EnCorte";
            this.EnCorte.HeaderText = "Corte";
            this.EnCorte.Name = "EnCorte";
            this.EnCorte.ReadOnly = true;
            // 
            // Cancelado
            // 
            this.Cancelado.DataPropertyName = "Cancelado";
            this.Cancelado.HeaderText = "Cancelado";
            this.Cancelado.Name = "Cancelado";
            this.Cancelado.ReadOnly = true;
            // 
            // grdCorteZ
            // 
            this.grdCorteZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCorteZ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.grdCorteZ.Location = new System.Drawing.Point(12, 65);
            this.grdCorteZ.Name = "grdCorteZ";
            this.grdCorteZ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdCorteZ.Size = new System.Drawing.Size(703, 428);
            this.grdCorteZ.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Producto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NoProductos";
            this.dataGridViewTextBoxColumn3.HeaderText = "Num. Productos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Venta";
            this.dataGridViewTextBoxColumn4.HeaderText = "Venta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(588, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Ventas";
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentas.Location = new System.Drawing.Point(586, 33);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(89, 20);
            this.lblTotalVentas.TabIndex = 9;
            this.lblTotalVentas.Text = "$1,000.00";
            // 
            // frmCortes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 494);
            this.Controls.Add(this.lblTotalVentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grdCorteZ);
            this.Controls.Add(this.cboCajeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdEjecutarRep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdVentas);
            this.Controls.Add(this.cboReportes);
            this.Name = "frmCortes";
            this.Text = "frmCortes";
            ((System.ComponentModel.ISupportInitialize)(this.grdVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCorteZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboReportes;
        private System.Windows.Forms.DataGridView grdVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdEjecutarRep;
        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnCorte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cancelado;
        private System.Windows.Forms.DataGridView grdCorteZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalVentas;
    }
}