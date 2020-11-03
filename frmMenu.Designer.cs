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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSideContainer = new System.Windows.Forms.Panel();
            this.imgSidebarButton = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.imgMenuButton = new System.Windows.Forms.PictureBox();
            this.cmdHnr = new System.Windows.Forms.Button();
            this.cmdPizza = new System.Windows.Forms.Button();
            this.cmdPan = new System.Windows.Forms.Button();
            this.cmdBebidas = new System.Windows.Forms.Button();
            this.cmdAlas = new System.Windows.Forms.Button();
            this.cmdComplementos = new System.Windows.Forms.Button();
            this.cmdNoComida = new System.Windows.Forms.Button();
            this.cmdOtrasComidas = new System.Windows.Forms.Button();
            this.cmdUber = new System.Windows.Forms.Button();
            this.cmdRanni = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSidebarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BlackBox.Properties.Resources.tabPopular;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pnlSideContainer);
            this.panel1.Location = new System.Drawing.Point(11, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 577);
            this.panel1.TabIndex = 0;
            // 
            // pnlSideContainer
            // 
            this.pnlSideContainer.AutoScroll = true;
            this.pnlSideContainer.Location = new System.Drawing.Point(32, 3);
            this.pnlSideContainer.Name = "pnlSideContainer";
            this.pnlSideContainer.Size = new System.Drawing.Size(239, 571);
            this.pnlSideContainer.TabIndex = 0;
            // 
            // imgSidebarButton
            // 
            this.imgSidebarButton.Image = global::BlackBox.Properties.Resources.cmdSideBar;
            this.imgSidebarButton.Location = new System.Drawing.Point(1385, 79);
            this.imgSidebarButton.Name = "imgSidebarButton";
            this.imgSidebarButton.Size = new System.Drawing.Size(100, 50);
            this.imgSidebarButton.TabIndex = 1;
            this.imgSidebarButton.TabStop = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.Location = new System.Drawing.Point(290, 63);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(764, 663);
            this.pnlMenu.TabIndex = 2;
            // 
            // imgMenuButton
            // 
            this.imgMenuButton.Image = global::BlackBox.Properties.Resources.cmdMenuButtonV5;
            this.imgMenuButton.Location = new System.Drawing.Point(1385, 145);
            this.imgMenuButton.Name = "imgMenuButton";
            this.imgMenuButton.Size = new System.Drawing.Size(100, 50);
            this.imgMenuButton.TabIndex = 3;
            this.imgMenuButton.TabStop = false;
            // 
            // cmdHnr
            // 
            this.cmdHnr.Location = new System.Drawing.Point(305, 34);
            this.cmdHnr.Name = "cmdHnr";
            this.cmdHnr.Size = new System.Drawing.Size(53, 23);
            this.cmdHnr.TabIndex = 4;
            this.cmdHnr.Text = "button1";
            this.cmdHnr.UseVisualStyleBackColor = true;
            this.cmdHnr.Click += new System.EventHandler(this.cmdMenuSelected);
            // 
            // cmdPizza
            // 
            this.cmdPizza.Location = new System.Drawing.Point(378, 34);
            this.cmdPizza.Name = "cmdPizza";
            this.cmdPizza.Size = new System.Drawing.Size(53, 23);
            this.cmdPizza.TabIndex = 5;
            this.cmdPizza.Text = "button2";
            this.cmdPizza.UseVisualStyleBackColor = true;
            this.cmdPizza.Click += new System.EventHandler(this.cmdMenuSelected);
            // 
            // cmdPan
            // 
            this.cmdPan.Location = new System.Drawing.Point(448, 34);
            this.cmdPan.Name = "cmdPan";
            this.cmdPan.Size = new System.Drawing.Size(53, 23);
            this.cmdPan.TabIndex = 6;
            this.cmdPan.Text = "button3";
            this.cmdPan.UseVisualStyleBackColor = true;
            this.cmdPan.Click += new System.EventHandler(this.cmdMenuSelected);
            // 
            // cmdBebidas
            // 
            this.cmdBebidas.Location = new System.Drawing.Point(528, 34);
            this.cmdBebidas.Name = "cmdBebidas";
            this.cmdBebidas.Size = new System.Drawing.Size(53, 23);
            this.cmdBebidas.TabIndex = 7;
            this.cmdBebidas.Text = "button4";
            this.cmdBebidas.UseVisualStyleBackColor = true;
            this.cmdBebidas.Click += new System.EventHandler(this.cmdMenuSelected);
            // 
            // cmdAlas
            // 
            this.cmdAlas.Location = new System.Drawing.Point(609, 34);
            this.cmdAlas.Name = "cmdAlas";
            this.cmdAlas.Size = new System.Drawing.Size(53, 23);
            this.cmdAlas.TabIndex = 8;
            this.cmdAlas.Text = "button5";
            this.cmdAlas.UseVisualStyleBackColor = true;
            this.cmdAlas.Click += new System.EventHandler(this.cmdMenuSelected);
            // 
            // cmdComplementos
            // 
            this.cmdComplementos.Location = new System.Drawing.Point(686, 34);
            this.cmdComplementos.Name = "cmdComplementos";
            this.cmdComplementos.Size = new System.Drawing.Size(53, 23);
            this.cmdComplementos.TabIndex = 9;
            this.cmdComplementos.Text = "button6";
            this.cmdComplementos.UseVisualStyleBackColor = true;
            this.cmdComplementos.Click += new System.EventHandler(this.cmdMenuSelected);
            // 
            // cmdNoComida
            // 
            this.cmdNoComida.Location = new System.Drawing.Point(767, 34);
            this.cmdNoComida.Name = "cmdNoComida";
            this.cmdNoComida.Size = new System.Drawing.Size(53, 23);
            this.cmdNoComida.TabIndex = 10;
            this.cmdNoComida.Text = "button7";
            this.cmdNoComida.UseVisualStyleBackColor = true;
            this.cmdNoComida.Click += new System.EventHandler(this.cmdMenuSelected);
            // 
            // cmdOtrasComidas
            // 
            this.cmdOtrasComidas.Location = new System.Drawing.Point(841, 34);
            this.cmdOtrasComidas.Name = "cmdOtrasComidas";
            this.cmdOtrasComidas.Size = new System.Drawing.Size(53, 23);
            this.cmdOtrasComidas.TabIndex = 11;
            this.cmdOtrasComidas.Text = "button8";
            this.cmdOtrasComidas.UseVisualStyleBackColor = true;
            this.cmdOtrasComidas.Click += new System.EventHandler(this.cmdMenuSelected);
            // 
            // cmdUber
            // 
            this.cmdUber.Location = new System.Drawing.Point(914, 34);
            this.cmdUber.Name = "cmdUber";
            this.cmdUber.Size = new System.Drawing.Size(53, 23);
            this.cmdUber.TabIndex = 12;
            this.cmdUber.Text = "button9";
            this.cmdUber.UseVisualStyleBackColor = true;
            this.cmdUber.Click += new System.EventHandler(this.cmdMenuSelected);
            // 
            // cmdRanni
            // 
            this.cmdRanni.Location = new System.Drawing.Point(985, 34);
            this.cmdRanni.Name = "cmdRanni";
            this.cmdRanni.Size = new System.Drawing.Size(53, 23);
            this.cmdRanni.TabIndex = 13;
            this.cmdRanni.Text = "button10";
            this.cmdRanni.UseVisualStyleBackColor = true;
            this.cmdRanni.Click += new System.EventHandler(this.cmdMenuSelected);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackBox.Properties.Resources.MenuTemplateV3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1430, 841);
            this.Controls.Add(this.cmdRanni);
            this.Controls.Add(this.cmdUber);
            this.Controls.Add(this.cmdOtrasComidas);
            this.Controls.Add(this.cmdNoComida);
            this.Controls.Add(this.cmdComplementos);
            this.Controls.Add(this.cmdAlas);
            this.Controls.Add(this.cmdBebidas);
            this.Controls.Add(this.cmdPan);
            this.Controls.Add(this.cmdPizza);
            this.Controls.Add(this.cmdHnr);
            this.Controls.Add(this.imgMenuButton);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.imgSidebarButton);
            this.Controls.Add(this.panel1);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSidebarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSideContainer;
        private System.Windows.Forms.PictureBox imgSidebarButton;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox imgMenuButton;
        private System.Windows.Forms.Button cmdHnr;
        private System.Windows.Forms.Button cmdPizza;
        private System.Windows.Forms.Button cmdPan;
        private System.Windows.Forms.Button cmdBebidas;
        private System.Windows.Forms.Button cmdAlas;
        private System.Windows.Forms.Button cmdComplementos;
        private System.Windows.Forms.Button cmdNoComida;
        private System.Windows.Forms.Button cmdOtrasComidas;
        private System.Windows.Forms.Button cmdUber;
        private System.Windows.Forms.Button cmdRanni;
    }
}