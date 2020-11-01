namespace BlackBox
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblFooter1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFooter2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.cmdFaq = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(173)))));
            this.lblVersion.Location = new System.Drawing.Point(299, 59);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(35, 12);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "label1";
            // 
            // lblFooter1
            // 
            this.lblFooter1.AutoSize = true;
            this.lblFooter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.lblFooter1.Location = new System.Drawing.Point(38, 5);
            this.lblFooter1.Name = "lblFooter1";
            this.lblFooter1.Size = new System.Drawing.Size(54, 12);
            this.lblFooter1.TabIndex = 5;
            this.lblFooter1.Text = "lblFotter1";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::BlackBox.Properties.Resources.LoginFotter;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.lblFooter2);
            this.panel2.Controls.Add(this.lblFooter1);
            this.panel2.Location = new System.Drawing.Point(0, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 23);
            this.panel2.TabIndex = 10;
            // 
            // lblFooter2
            // 
            this.lblFooter2.AutoSize = true;
            this.lblFooter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.lblFooter2.Location = new System.Drawing.Point(359, 5);
            this.lblFooter2.Name = "lblFooter2";
            this.lblFooter2.Size = new System.Drawing.Size(54, 12);
            this.lblFooter2.TabIndex = 6;
            this.lblFooter2.Text = "lblFotter1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BlackBox.Properties.Resources.LoginIntro;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(85, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 91);
            this.panel1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::BlackBox.Properties.Resources.Photo;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Location = new System.Drawing.Point(12, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(65, 78);
            this.panel3.TabIndex = 8;
            // 
            // cmdLogin
            // 
            this.cmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLogin.Image = global::BlackBox.Properties.Resources.Login;
            this.cmdLogin.Location = new System.Drawing.Point(12, 171);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(65, 28);
            this.cmdLogin.TabIndex = 4;
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // cmdFaq
            // 
            this.cmdFaq.BackgroundImage = global::BlackBox.Properties.Resources.FaqBtn;
            this.cmdFaq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdFaq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFaq.Location = new System.Drawing.Point(417, 75);
            this.cmdFaq.Name = "cmdFaq";
            this.cmdFaq.Size = new System.Drawing.Size(22, 22);
            this.cmdFaq.TabIndex = 2;
            this.cmdFaq.UseVisualStyleBackColor = true;
            // 
            // cmdClose
            // 
            this.cmdClose.BackgroundImage = global::BlackBox.Properties.Resources.CloseBtn;
            this.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdClose.FlatAppearance.BorderSize = 0;
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Location = new System.Drawing.Point(417, 0);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(21, 22);
            this.cmdClose.TabIndex = 1;
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Image = global::BlackBox.Properties.Resources.LoginHeader1;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(440, 76);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(440, 233);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.cmdFaq);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pnlHeader;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdFaq;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.Label lblFooter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFooter2;
        private System.Windows.Forms.Timer timer1;
    }
}

