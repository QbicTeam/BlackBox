namespace BlackBox
{
    partial class frmMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdRelojMarcador = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grdTest = new System.Windows.Forms.DataGridView();
            this.Comienza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdRelojMarcador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTest)).BeginInit();
            this.SuspendLayout();
            // 
            // grdRelojMarcador
            // 
            this.grdRelojMarcador.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdRelojMarcador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdRelojMarcador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRelojMarcador.EnableHeadersVisualStyles = false;
            this.grdRelojMarcador.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grdRelojMarcador.Location = new System.Drawing.Point(39, 34);
            this.grdRelojMarcador.Name = "grdRelojMarcador";
            this.grdRelojMarcador.Size = new System.Drawing.Size(294, 225);
            this.grdRelojMarcador.TabIndex = 0;
            // 
            // grdTest
            // 
            this.grdTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Comienza,
            this.NombreEvento});
            this.grdTest.Location = new System.Drawing.Point(395, 81);
            this.grdTest.Name = "grdTest";
            this.grdTest.Size = new System.Drawing.Size(240, 150);
            this.grdTest.TabIndex = 1;
            // 
            // Comienza
            // 
            this.Comienza.DataPropertyName = "Comienza";
            this.Comienza.HeaderText = "Comienza:";
            this.Comienza.Name = "Comienza";
            // 
            // NombreEvento
            // 
            this.NombreEvento.DataPropertyName = "NombreEvento";
            this.NombreEvento.HeaderText = "Nombre del Evento";
            this.NombreEvento.Name = "NombreEvento";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 423);
            this.Controls.Add(this.grdTest);
            this.Controls.Add(this.grdRelojMarcador);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdRelojMarcador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdRelojMarcador;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView grdTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comienza;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEvento;
    }
}