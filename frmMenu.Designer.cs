﻿namespace BlackBox
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSideContainer = new System.Windows.Forms.Panel();
            this.imgSidebarButton = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.imgMenuHnr = new System.Windows.Forms.PictureBox();
            this.cmdHnr = new System.Windows.Forms.Button();
            this.cmdPizza = new System.Windows.Forms.Button();
            this.cmdPan = new System.Windows.Forms.Button();
            this.cmdBebidas = new System.Windows.Forms.Button();
            this.cmdAlas = new System.Windows.Forms.Button();
            this.cmdComplementos = new System.Windows.Forms.Button();
            this.cmdNoComida = new System.Windows.Forms.Button();
            this.cmdOtrasComidas = new System.Windows.Forms.Button();
            this.cmdUber = new System.Windows.Forms.Button();
            this.cmdRappi = new System.Windows.Forms.Button();
            this.imgMenuPizza = new System.Windows.Forms.PictureBox();
            this.imgMenuPan = new System.Windows.Forms.PictureBox();
            this.imgMenuBebidas = new System.Windows.Forms.PictureBox();
            this.imgMenuAlas = new System.Windows.Forms.PictureBox();
            this.imgMenuComplementos = new System.Windows.Forms.PictureBox();
            this.imgMenuNoComida = new System.Windows.Forms.PictureBox();
            this.imgMenuOtrasComidas = new System.Windows.Forms.PictureBox();
            this.imgMenuUber = new System.Windows.Forms.PictureBox();
            this.imgMenuRappi = new System.Windows.Forms.PictureBox();
            this.pnlComanda = new System.Windows.Forms.Panel();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblNumArts = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblImpu = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlPie = new System.Windows.Forms.Panel();
            this.lblCajero = new System.Windows.Forms.Label();
            this.lblArticulosPie = new System.Windows.Forms.Label();
            this.lblHoraActual = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSidebarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuHnr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuPan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuAlas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuComplementos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuNoComida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuOtrasComidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuUber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuRappi)).BeginInit();
            this.pnlTotal.SuspendLayout();
            this.pnlPie.SuspendLayout();
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
            // imgMenuHnr
            // 
            this.imgMenuHnr.Image = global::BlackBox.Properties.Resources.cmdMenuButtonV5;
            this.imgMenuHnr.Location = new System.Drawing.Point(1385, 145);
            this.imgMenuHnr.Name = "imgMenuHnr";
            this.imgMenuHnr.Size = new System.Drawing.Size(100, 50);
            this.imgMenuHnr.TabIndex = 3;
            this.imgMenuHnr.TabStop = false;
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
            // cmdRappi
            // 
            this.cmdRappi.Location = new System.Drawing.Point(985, 34);
            this.cmdRappi.Name = "cmdRappi";
            this.cmdRappi.Size = new System.Drawing.Size(53, 23);
            this.cmdRappi.TabIndex = 13;
            this.cmdRappi.Text = "button10";
            this.cmdRappi.UseVisualStyleBackColor = true;
            this.cmdRappi.Click += new System.EventHandler(this.cmdMenuSelected);
            // 
            // imgMenuPizza
            // 
            this.imgMenuPizza.Image = global::BlackBox.Properties.Resources.cmdMenuButtonV5;
            this.imgMenuPizza.Location = new System.Drawing.Point(1385, 201);
            this.imgMenuPizza.Name = "imgMenuPizza";
            this.imgMenuPizza.Size = new System.Drawing.Size(100, 50);
            this.imgMenuPizza.TabIndex = 14;
            this.imgMenuPizza.TabStop = false;
            // 
            // imgMenuPan
            // 
            this.imgMenuPan.Image = global::BlackBox.Properties.Resources.cmdPan;
            this.imgMenuPan.Location = new System.Drawing.Point(1385, 257);
            this.imgMenuPan.Name = "imgMenuPan";
            this.imgMenuPan.Size = new System.Drawing.Size(100, 50);
            this.imgMenuPan.TabIndex = 15;
            this.imgMenuPan.TabStop = false;
            // 
            // imgMenuBebidas
            // 
            this.imgMenuBebidas.Image = global::BlackBox.Properties.Resources.cmdMenuButtonV5;
            this.imgMenuBebidas.Location = new System.Drawing.Point(1385, 313);
            this.imgMenuBebidas.Name = "imgMenuBebidas";
            this.imgMenuBebidas.Size = new System.Drawing.Size(100, 50);
            this.imgMenuBebidas.TabIndex = 16;
            this.imgMenuBebidas.TabStop = false;
            // 
            // imgMenuAlas
            // 
            this.imgMenuAlas.Image = global::BlackBox.Properties.Resources.cmdMenuButtonV5;
            this.imgMenuAlas.Location = new System.Drawing.Point(1385, 369);
            this.imgMenuAlas.Name = "imgMenuAlas";
            this.imgMenuAlas.Size = new System.Drawing.Size(100, 50);
            this.imgMenuAlas.TabIndex = 17;
            this.imgMenuAlas.TabStop = false;
            // 
            // imgMenuComplementos
            // 
            this.imgMenuComplementos.Image = global::BlackBox.Properties.Resources.cmdMenuButtonV5;
            this.imgMenuComplementos.Location = new System.Drawing.Point(1385, 425);
            this.imgMenuComplementos.Name = "imgMenuComplementos";
            this.imgMenuComplementos.Size = new System.Drawing.Size(100, 50);
            this.imgMenuComplementos.TabIndex = 18;
            this.imgMenuComplementos.TabStop = false;
            // 
            // imgMenuNoComida
            // 
            this.imgMenuNoComida.Image = global::BlackBox.Properties.Resources.cmdMenuButtonV5;
            this.imgMenuNoComida.Location = new System.Drawing.Point(1385, 481);
            this.imgMenuNoComida.Name = "imgMenuNoComida";
            this.imgMenuNoComida.Size = new System.Drawing.Size(100, 50);
            this.imgMenuNoComida.TabIndex = 19;
            this.imgMenuNoComida.TabStop = false;
            // 
            // imgMenuOtrasComidas
            // 
            this.imgMenuOtrasComidas.Image = global::BlackBox.Properties.Resources.cmdMenuButtonV5;
            this.imgMenuOtrasComidas.Location = new System.Drawing.Point(1385, 537);
            this.imgMenuOtrasComidas.Name = "imgMenuOtrasComidas";
            this.imgMenuOtrasComidas.Size = new System.Drawing.Size(100, 50);
            this.imgMenuOtrasComidas.TabIndex = 20;
            this.imgMenuOtrasComidas.TabStop = false;
            // 
            // imgMenuUber
            // 
            this.imgMenuUber.Image = global::BlackBox.Properties.Resources.cmdMenuButtonV5;
            this.imgMenuUber.Location = new System.Drawing.Point(1385, 593);
            this.imgMenuUber.Name = "imgMenuUber";
            this.imgMenuUber.Size = new System.Drawing.Size(100, 50);
            this.imgMenuUber.TabIndex = 21;
            this.imgMenuUber.TabStop = false;
            // 
            // imgMenuRappi
            // 
            this.imgMenuRappi.Image = global::BlackBox.Properties.Resources.cmdMenuButtonV5;
            this.imgMenuRappi.Location = new System.Drawing.Point(1385, 649);
            this.imgMenuRappi.Name = "imgMenuRappi";
            this.imgMenuRappi.Size = new System.Drawing.Size(100, 50);
            this.imgMenuRappi.TabIndex = 22;
            this.imgMenuRappi.TabStop = false;
            // 
            // pnlComanda
            // 
            this.pnlComanda.BackColor = System.Drawing.Color.Transparent;
            this.pnlComanda.Location = new System.Drawing.Point(1058, 62);
            this.pnlComanda.Name = "pnlComanda";
            this.pnlComanda.Size = new System.Drawing.Size(308, 574);
            this.pnlComanda.TabIndex = 23;
            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.Transparent;
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Controls.Add(this.lblImpu);
            this.pnlTotal.Controls.Add(this.lblSubTotal);
            this.pnlTotal.Controls.Add(this.lblNumArts);
            this.pnlTotal.Location = new System.Drawing.Point(1200, 643);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(165, 82);
            this.pnlTotal.TabIndex = 24;
            // 
            // lblNumArts
            // 
            this.lblNumArts.Location = new System.Drawing.Point(56, 4);
            this.lblNumArts.Name = "lblNumArts";
            this.lblNumArts.Size = new System.Drawing.Size(93, 12);
            this.lblNumArts.TabIndex = 0;
            this.lblNumArts.Text = "Items 0";
            this.lblNumArts.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSubTotal.Location = new System.Drawing.Point(56, 19);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(93, 13);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.Text = "$0.00";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblImpu
            // 
            this.lblImpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblImpu.Location = new System.Drawing.Point(56, 34);
            this.lblImpu.Name = "lblImpu";
            this.lblImpu.Size = new System.Drawing.Size(93, 13);
            this.lblImpu.TabIndex = 2;
            this.lblImpu.Text = "$0.00";
            this.lblImpu.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotal.Location = new System.Drawing.Point(60, 50);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(93, 22);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "$0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlPie
            // 
            this.pnlPie.BackColor = System.Drawing.Color.Transparent;
            this.pnlPie.Controls.Add(this.lblHoraActual);
            this.pnlPie.Controls.Add(this.lblArticulosPie);
            this.pnlPie.Controls.Add(this.lblCajero);
            this.pnlPie.Location = new System.Drawing.Point(44, 729);
            this.pnlPie.Name = "pnlPie";
            this.pnlPie.Size = new System.Drawing.Size(1321, 39);
            this.pnlPie.TabIndex = 25;
            // 
            // lblCajero
            // 
            this.lblCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCajero.Location = new System.Drawing.Point(-1, 3);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(227, 35);
            this.lblCajero.TabIndex = 0;
            this.lblCajero.Text = "Omar Carranza Garcia";
            this.lblCajero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArticulosPie
            // 
            this.lblArticulosPie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblArticulosPie.Location = new System.Drawing.Point(230, 2);
            this.lblArticulosPie.Name = "lblArticulosPie";
            this.lblArticulosPie.Size = new System.Drawing.Size(973, 36);
            this.lblArticulosPie.TabIndex = 1;
            this.lblArticulosPie.Text = "Articulos Vencidos: 273";
            this.lblArticulosPie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoraActual
            // 
            this.lblHoraActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblHoraActual.Location = new System.Drawing.Point(1214, 2);
            this.lblHoraActual.Name = "lblHoraActual";
            this.lblHoraActual.Size = new System.Drawing.Size(100, 33);
            this.lblHoraActual.TabIndex = 2;
            this.lblHoraActual.Text = "12 : 01p";
            this.lblHoraActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackBox.Properties.Resources.MenuTemplateV4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1430, 841);
            this.Controls.Add(this.pnlPie);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.pnlComanda);
            this.Controls.Add(this.imgMenuRappi);
            this.Controls.Add(this.imgMenuUber);
            this.Controls.Add(this.imgMenuOtrasComidas);
            this.Controls.Add(this.imgMenuNoComida);
            this.Controls.Add(this.imgMenuComplementos);
            this.Controls.Add(this.imgMenuAlas);
            this.Controls.Add(this.imgMenuBebidas);
            this.Controls.Add(this.imgMenuPan);
            this.Controls.Add(this.imgMenuPizza);
            this.Controls.Add(this.cmdRappi);
            this.Controls.Add(this.cmdUber);
            this.Controls.Add(this.cmdOtrasComidas);
            this.Controls.Add(this.cmdNoComida);
            this.Controls.Add(this.cmdComplementos);
            this.Controls.Add(this.cmdAlas);
            this.Controls.Add(this.cmdBebidas);
            this.Controls.Add(this.cmdPan);
            this.Controls.Add(this.cmdPizza);
            this.Controls.Add(this.cmdHnr);
            this.Controls.Add(this.imgMenuHnr);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.imgSidebarButton);
            this.Controls.Add(this.panel1);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSidebarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuHnr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuPan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuAlas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuComplementos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuNoComida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuOtrasComidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuUber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuRappi)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.pnlPie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSideContainer;
        private System.Windows.Forms.PictureBox imgSidebarButton;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox imgMenuHnr;
        private System.Windows.Forms.Button cmdHnr;
        private System.Windows.Forms.Button cmdPizza;
        private System.Windows.Forms.Button cmdPan;
        private System.Windows.Forms.Button cmdBebidas;
        private System.Windows.Forms.Button cmdAlas;
        private System.Windows.Forms.Button cmdComplementos;
        private System.Windows.Forms.Button cmdNoComida;
        private System.Windows.Forms.Button cmdOtrasComidas;
        private System.Windows.Forms.Button cmdUber;
        private System.Windows.Forms.Button cmdRappi;
        private System.Windows.Forms.PictureBox imgMenuPizza;
        private System.Windows.Forms.PictureBox imgMenuPan;
        private System.Windows.Forms.PictureBox imgMenuBebidas;
        private System.Windows.Forms.PictureBox imgMenuAlas;
        private System.Windows.Forms.PictureBox imgMenuComplementos;
        private System.Windows.Forms.PictureBox imgMenuNoComida;
        private System.Windows.Forms.PictureBox imgMenuOtrasComidas;
        private System.Windows.Forms.PictureBox imgMenuUber;
        private System.Windows.Forms.PictureBox imgMenuRappi;
        private System.Windows.Forms.Panel pnlComanda;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblNumArts;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblImpu;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Label lblArticulosPie;
        private System.Windows.Forms.Label lblCajero;
        private System.Windows.Forms.Label lblHoraActual;
    }
}