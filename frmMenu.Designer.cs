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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.grdRelojMarcador = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grdEventos = new System.Windows.Forms.DataGridView();
            this.Comienza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdHorario = new System.Windows.Forms.DataGridView();
            this.grdTrabajando = new System.Windows.Forms.DataGridView();
            this.NombreT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrabajoT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalidaH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdMensajeria = new System.Windows.Forms.DataGridView();
            this.DeM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsuntoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdRelojMarcador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTrabajando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMensajeria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // grdRelojMarcador
            // 
            this.grdRelojMarcador.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdRelojMarcador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdRelojMarcador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRelojMarcador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Entrada,
            this.Salida,
            this.Horas});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdRelojMarcador.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdRelojMarcador.EnableHeadersVisualStyles = false;
            this.grdRelojMarcador.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grdRelojMarcador.Location = new System.Drawing.Point(1, 12);
            this.grdRelojMarcador.Name = "grdRelojMarcador";
            this.grdRelojMarcador.Size = new System.Drawing.Size(294, 225);
            this.grdRelojMarcador.TabIndex = 0;
            // 
            // grdEventos
            // 
            this.grdEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Comienza,
            this.NombreEvento});
            this.grdEventos.Location = new System.Drawing.Point(301, 12);
            this.grdEventos.Name = "grdEventos";
            this.grdEventos.Size = new System.Drawing.Size(240, 150);
            this.grdEventos.TabIndex = 1;
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
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha:";
            this.Fecha.Name = "Fecha";
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fecha.Width = 50;
            // 
            // Entrada
            // 
            this.Entrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Entrada.DataPropertyName = "Entrada";
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            // 
            // Salida
            // 
            this.Salida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Salida.DataPropertyName = "Salida";
            this.Salida.HeaderText = "Salida";
            this.Salida.Name = "Salida";
            // 
            // Horas
            // 
            this.Horas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Horas.DataPropertyName = "Horas";
            this.Horas.HeaderText = "Horas";
            this.Horas.Name = "Horas";
            // 
            // grdHorario
            // 
            this.grdHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaH,
            this.EntradaH,
            this.SalidaH,
            this.HorasH});
            this.grdHorario.Location = new System.Drawing.Point(1, 243);
            this.grdHorario.Name = "grdHorario";
            this.grdHorario.Size = new System.Drawing.Size(247, 129);
            this.grdHorario.TabIndex = 2;
            // 
            // grdTrabajando
            // 
            this.grdTrabajando.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTrabajando.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreT,
            this.TrabajoT,
            this.HorasT});
            this.grdTrabajando.Location = new System.Drawing.Point(547, 12);
            this.grdTrabajando.Name = "grdTrabajando";
            this.grdTrabajando.Size = new System.Drawing.Size(240, 150);
            this.grdTrabajando.TabIndex = 3;
            // 
            // NombreT
            // 
            this.NombreT.DataPropertyName = "Nombre";
            this.NombreT.HeaderText = "Nombre";
            this.NombreT.Name = "NombreT";
            // 
            // TrabajoT
            // 
            this.TrabajoT.DataPropertyName = "Trabajo";
            this.TrabajoT.HeaderText = "Trabajo";
            this.TrabajoT.Name = "TrabajoT";
            // 
            // HorasT
            // 
            this.HorasT.DataPropertyName = "Horas";
            this.HorasT.HeaderText = "Horas";
            this.HorasT.Name = "HorasT";
            // 
            // FechaH
            // 
            this.FechaH.DataPropertyName = "Fecha";
            this.FechaH.HeaderText = "Fecha";
            this.FechaH.Name = "FechaH";
            // 
            // EntradaH
            // 
            this.EntradaH.DataPropertyName = "Entrada";
            this.EntradaH.HeaderText = "Entrada";
            this.EntradaH.Name = "EntradaH";
            // 
            // SalidaH
            // 
            this.SalidaH.DataPropertyName = "Salida";
            this.SalidaH.HeaderText = "Salida";
            this.SalidaH.Name = "SalidaH";
            // 
            // HorasH
            // 
            this.HorasH.DataPropertyName = "Horas";
            this.HorasH.HeaderText = "Horas";
            this.HorasH.Name = "HorasH";
            // 
            // grdMensajeria
            // 
            this.grdMensajeria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMensajeria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeM,
            this.AsuntoM,
            this.FechaM});
            this.grdMensajeria.Location = new System.Drawing.Point(324, 243);
            this.grdMensajeria.Name = "grdMensajeria";
            this.grdMensajeria.Size = new System.Drawing.Size(334, 113);
            this.grdMensajeria.TabIndex = 4;
            // 
            // DeM
            // 
            this.DeM.DataPropertyName = "De";
            this.DeM.HeaderText = "De";
            this.DeM.Name = "DeM";
            // 
            // AsuntoM
            // 
            this.AsuntoM.DataPropertyName = "Asunto";
            this.AsuntoM.HeaderText = "Asunto:";
            this.AsuntoM.Name = "AsuntoM";
            // 
            // FechaM
            // 
            this.FechaM.DataPropertyName = "Fecha";
            this.FechaM.HeaderText = "Fecha";
            this.FechaM.Name = "FechaM";
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(324, 181);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(14, 14);
            this.picBox.TabIndex = 5;
            this.picBox.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 423);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.grdMensajeria);
            this.Controls.Add(this.grdTrabajando);
            this.Controls.Add(this.grdHorario);
            this.Controls.Add(this.grdEventos);
            this.Controls.Add(this.grdRelojMarcador);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdRelojMarcador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTrabajando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMensajeria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdRelojMarcador;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView grdEventos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comienza;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridView grdHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaH;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntradaH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalidaH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasH;
        private System.Windows.Forms.DataGridView grdTrabajando;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrabajoT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasT;
        private System.Windows.Forms.DataGridView grdMensajeria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeM;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsuntoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaM;
        private System.Windows.Forms.PictureBox picBox;
    }
}