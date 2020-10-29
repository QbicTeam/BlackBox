namespace BlackBox
{
    partial class frmMain
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
            this.pnlInicio = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdInicio = new System.Windows.Forms.Button();
            this.cmdAdmon = new System.Windows.Forms.Button();
            this.cmdHorario = new System.Windows.Forms.Button();
            this.cmdMensajeria = new System.Windows.Forms.Button();
            this.pnlAdmon = new System.Windows.Forms.Panel();
            this.pnlHorario = new System.Windows.Forms.Panel();
            this.pnlMensajeria = new System.Windows.Forms.Panel();
            this.pnlInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInicio
            // 
            this.pnlInicio.BackgroundImage = global::BlackBox.Properties.Resources.pnlInicio;
            this.pnlInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlInicio.Controls.Add(this.panel1);
            this.pnlInicio.Location = new System.Drawing.Point(86, 166);
            this.pnlInicio.Name = "pnlInicio";
            this.pnlInicio.Size = new System.Drawing.Size(337, 256);
            this.pnlInicio.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BlackBox.Properties.Resources.pnlInicioContent;
            this.panel1.Location = new System.Drawing.Point(20, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 560);
            this.panel1.TabIndex = 0;
            // 
            // cmdInicio
            // 
            this.cmdInicio.BackColor = System.Drawing.Color.Transparent;
            this.cmdInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdInicio.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInicio.Location = new System.Drawing.Point(22, 730);
            this.cmdInicio.Name = "cmdInicio";
            this.cmdInicio.Size = new System.Drawing.Size(226, 21);
            this.cmdInicio.TabIndex = 1;
            this.cmdInicio.UseVisualStyleBackColor = false;
            this.cmdInicio.Click += new System.EventHandler(this.cmdShowPanel);
            // 
            // cmdAdmon
            // 
            this.cmdAdmon.BackColor = System.Drawing.Color.Transparent;
            this.cmdAdmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAdmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdmon.Location = new System.Drawing.Point(254, 730);
            this.cmdAdmon.Name = "cmdAdmon";
            this.cmdAdmon.Size = new System.Drawing.Size(231, 21);
            this.cmdAdmon.TabIndex = 2;
            this.cmdAdmon.UseVisualStyleBackColor = false;
            this.cmdAdmon.Click += new System.EventHandler(this.cmdShowPanel);
            // 
            // cmdHorario
            // 
            this.cmdHorario.BackColor = System.Drawing.Color.Transparent;
            this.cmdHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdHorario.Location = new System.Drawing.Point(491, 728);
            this.cmdHorario.Name = "cmdHorario";
            this.cmdHorario.Size = new System.Drawing.Size(227, 23);
            this.cmdHorario.TabIndex = 3;
            this.cmdHorario.UseVisualStyleBackColor = false;
            this.cmdHorario.Click += new System.EventHandler(this.cmdShowPanel);
            // 
            // cmdMensajeria
            // 
            this.cmdMensajeria.BackColor = System.Drawing.Color.Transparent;
            this.cmdMensajeria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMensajeria.Location = new System.Drawing.Point(738, 728);
            this.cmdMensajeria.Name = "cmdMensajeria";
            this.cmdMensajeria.Size = new System.Drawing.Size(239, 23);
            this.cmdMensajeria.TabIndex = 4;
            this.cmdMensajeria.UseVisualStyleBackColor = false;
            this.cmdMensajeria.Click += new System.EventHandler(this.cmdShowPanel);
            // 
            // pnlAdmon
            // 
            this.pnlAdmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.pnlAdmon.BackgroundImage = global::BlackBox.Properties.Resources.pnlAdmon;
            this.pnlAdmon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlAdmon.Location = new System.Drawing.Point(766, 110);
            this.pnlAdmon.Name = "pnlAdmon";
            this.pnlAdmon.Size = new System.Drawing.Size(200, 100);
            this.pnlAdmon.TabIndex = 5;
            this.pnlAdmon.Visible = false;
            // 
            // pnlHorario
            // 
            this.pnlHorario.Location = new System.Drawing.Point(481, 513);
            this.pnlHorario.Name = "pnlHorario";
            this.pnlHorario.Size = new System.Drawing.Size(200, 100);
            this.pnlHorario.TabIndex = 6;
            this.pnlHorario.Visible = false;
            // 
            // pnlMensajeria
            // 
            this.pnlMensajeria.Location = new System.Drawing.Point(738, 542);
            this.pnlMensajeria.Name = "pnlMensajeria";
            this.pnlMensajeria.Size = new System.Drawing.Size(200, 100);
            this.pnlMensajeria.TabIndex = 7;
            this.pnlMensajeria.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::BlackBox.Properties.Resources.MainTemplateV2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1209, 772);
            this.Controls.Add(this.cmdInicio);
            this.Controls.Add(this.pnlAdmon);
            this.Controls.Add(this.pnlMensajeria);
            this.Controls.Add(this.pnlHorario);
            this.Controls.Add(this.cmdMensajeria);
            this.Controls.Add(this.cmdHorario);
            this.Controls.Add(this.cmdAdmon);
            this.Controls.Add(this.pnlInicio);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlInicio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInicio;
        private System.Windows.Forms.Button cmdInicio;
        private System.Windows.Forms.Button cmdAdmon;
        private System.Windows.Forms.Button cmdHorario;
        private System.Windows.Forms.Button cmdMensajeria;
        private System.Windows.Forms.Panel pnlAdmon;
        private System.Windows.Forms.Panel pnlHorario;
        private System.Windows.Forms.Panel pnlMensajeria;
        private System.Windows.Forms.Panel panel1;
    }
}