namespace BlackBox
{
    partial class frmPagos
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
            this.cmdEfectivo = new System.Windows.Forms.Button();
            this.cmd200 = new System.Windows.Forms.Button();
            this.cmd500 = new System.Windows.Forms.Button();
            this.cmd50c = new System.Windows.Forms.Button();
            this.cmd1 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.cmd5 = new System.Windows.Forms.Button();
            this.cmd10 = new System.Windows.Forms.Button();
            this.cmdR200 = new System.Windows.Forms.Button();
            this.cmdR100 = new System.Windows.Forms.Button();
            this.cmd0 = new System.Windows.Forms.Button();
            this.cmd100 = new System.Windows.Forms.Button();
            this.cmd50 = new System.Windows.Forms.Button();
            this.cmd20 = new System.Windows.Forms.Button();
            this.cmdSigno = new System.Windows.Forms.Button();
            this.cmdMas = new System.Windows.Forms.Button();
            this.cmdRegalo = new System.Windows.Forms.Button();
            this.cmdTarjeta = new System.Windows.Forms.Button();
            this.cmdCheque = new System.Windows.Forms.Button();
            this.cmdPagar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.imgEfectivo = new System.Windows.Forms.PictureBox();
            this.imgCheque = new System.Windows.Forms.PictureBox();
            this.imgTarjeta = new System.Windows.Forms.PictureBox();
            this.imgRegalo = new System.Windows.Forms.PictureBox();
            this.imgMas = new System.Windows.Forms.PictureBox();
            this.imgTipo = new System.Windows.Forms.PictureBox();
            this.imgSTipo = new System.Windows.Forms.PictureBox();
            this.imgSMas = new System.Windows.Forms.PictureBox();
            this.imgSRegalo = new System.Windows.Forms.PictureBox();
            this.imgSTarjeta = new System.Windows.Forms.PictureBox();
            this.imgSCheque = new System.Windows.Forms.PictureBox();
            this.imgSEfectivo = new System.Windows.Forms.PictureBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblPagos = new System.Windows.Forms.Label();
            this.lblTotalOrden = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgEfectivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRegalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSMas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSRegalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSCheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSEfectivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdEfectivo
            // 
            this.cmdEfectivo.BackColor = System.Drawing.Color.Transparent;
            this.cmdEfectivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdEfectivo.FlatAppearance.BorderSize = 0;
            this.cmdEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEfectivo.Location = new System.Drawing.Point(24, 185);
            this.cmdEfectivo.Name = "cmdEfectivo";
            this.cmdEfectivo.Size = new System.Drawing.Size(65, 44);
            this.cmdEfectivo.TabIndex = 0;
            this.cmdEfectivo.UseVisualStyleBackColor = false;
            this.cmdEfectivo.Click += new System.EventHandler(this.TipoPago);
            // 
            // cmd200
            // 
            this.cmd200.BackColor = System.Drawing.Color.Transparent;
            this.cmd200.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd200.FlatAppearance.BorderSize = 0;
            this.cmd200.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd200.Location = new System.Drawing.Point(77, 243);
            this.cmd200.Name = "cmd200";
            this.cmd200.Size = new System.Drawing.Size(54, 54);
            this.cmd200.TabIndex = 1;
            this.cmd200.Tag = "200";
            this.cmd200.UseVisualStyleBackColor = false;
            this.cmd200.Click += new System.EventHandler(this.Importe);
            // 
            // cmd500
            // 
            this.cmd500.BackColor = System.Drawing.Color.Transparent;
            this.cmd500.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd500.FlatAppearance.BorderSize = 0;
            this.cmd500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd500.Location = new System.Drawing.Point(18, 243);
            this.cmd500.Name = "cmd500";
            this.cmd500.Size = new System.Drawing.Size(54, 54);
            this.cmd500.TabIndex = 2;
            this.cmd500.Tag = "500";
            this.cmd500.UseVisualStyleBackColor = false;
            this.cmd500.Click += new System.EventHandler(this.Importe);
            // 
            // cmd50c
            // 
            this.cmd50c.BackColor = System.Drawing.Color.Transparent;
            this.cmd50c.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd50c.FlatAppearance.BorderSize = 0;
            this.cmd50c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd50c.Location = new System.Drawing.Point(254, 302);
            this.cmd50c.Name = "cmd50c";
            this.cmd50c.Size = new System.Drawing.Size(54, 54);
            this.cmd50c.TabIndex = 3;
            this.cmd50c.Tag = ".50";
            this.cmd50c.UseVisualStyleBackColor = false;
            this.cmd50c.Click += new System.EventHandler(this.Importe);
            // 
            // cmd1
            // 
            this.cmd1.BackColor = System.Drawing.Color.Transparent;
            this.cmd1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd1.FlatAppearance.BorderSize = 0;
            this.cmd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd1.Location = new System.Drawing.Point(195, 302);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(54, 54);
            this.cmd1.TabIndex = 4;
            this.cmd1.Tag = "1";
            this.cmd1.UseVisualStyleBackColor = false;
            this.cmd1.Click += new System.EventHandler(this.Importe);
            // 
            // cmd2
            // 
            this.cmd2.BackColor = System.Drawing.Color.Transparent;
            this.cmd2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd2.FlatAppearance.BorderSize = 0;
            this.cmd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd2.Location = new System.Drawing.Point(136, 302);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(54, 54);
            this.cmd2.TabIndex = 5;
            this.cmd2.Tag = "2";
            this.cmd2.UseVisualStyleBackColor = false;
            this.cmd2.Click += new System.EventHandler(this.Importe);
            // 
            // cmd5
            // 
            this.cmd5.BackColor = System.Drawing.Color.Transparent;
            this.cmd5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd5.FlatAppearance.BorderSize = 0;
            this.cmd5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd5.Location = new System.Drawing.Point(77, 302);
            this.cmd5.Name = "cmd5";
            this.cmd5.Size = new System.Drawing.Size(54, 54);
            this.cmd5.TabIndex = 6;
            this.cmd5.Tag = "5";
            this.cmd5.UseVisualStyleBackColor = false;
            this.cmd5.Click += new System.EventHandler(this.Importe);
            // 
            // cmd10
            // 
            this.cmd10.BackColor = System.Drawing.Color.Transparent;
            this.cmd10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd10.FlatAppearance.BorderSize = 0;
            this.cmd10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd10.Location = new System.Drawing.Point(18, 302);
            this.cmd10.Name = "cmd10";
            this.cmd10.Size = new System.Drawing.Size(54, 54);
            this.cmd10.TabIndex = 7;
            this.cmd10.Tag = "10";
            this.cmd10.UseVisualStyleBackColor = false;
            this.cmd10.Click += new System.EventHandler(this.Importe);
            // 
            // cmdR200
            // 
            this.cmdR200.BackColor = System.Drawing.Color.Transparent;
            this.cmdR200.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdR200.FlatAppearance.BorderSize = 0;
            this.cmdR200.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdR200.Location = new System.Drawing.Point(141, 374);
            this.cmdR200.Name = "cmdR200";
            this.cmdR200.Size = new System.Drawing.Size(48, 44);
            this.cmdR200.TabIndex = 8;
            this.cmdR200.Tag = "200";
            this.cmdR200.UseVisualStyleBackColor = false;
            this.cmdR200.Click += new System.EventHandler(this.Importe);
            // 
            // cmdR100
            // 
            this.cmdR100.BackColor = System.Drawing.Color.Transparent;
            this.cmdR100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdR100.FlatAppearance.BorderSize = 0;
            this.cmdR100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdR100.Location = new System.Drawing.Point(198, 374);
            this.cmdR100.Name = "cmdR100";
            this.cmdR100.Size = new System.Drawing.Size(48, 44);
            this.cmdR100.TabIndex = 9;
            this.cmdR100.Tag = "100";
            this.cmdR100.UseVisualStyleBackColor = false;
            this.cmdR100.Click += new System.EventHandler(this.Importe);
            // 
            // cmd0
            // 
            this.cmd0.BackColor = System.Drawing.Color.Transparent;
            this.cmd0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd0.FlatAppearance.BorderSize = 0;
            this.cmd0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd0.Location = new System.Drawing.Point(18, 369);
            this.cmd0.Name = "cmd0";
            this.cmd0.Size = new System.Drawing.Size(54, 54);
            this.cmd0.TabIndex = 10;
            this.cmd0.Tag = "0";
            this.cmd0.UseVisualStyleBackColor = false;
            this.cmd0.Click += new System.EventHandler(this.Importe);
            // 
            // cmd100
            // 
            this.cmd100.BackColor = System.Drawing.Color.Transparent;
            this.cmd100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd100.FlatAppearance.BorderSize = 0;
            this.cmd100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd100.Location = new System.Drawing.Point(136, 243);
            this.cmd100.Name = "cmd100";
            this.cmd100.Size = new System.Drawing.Size(54, 54);
            this.cmd100.TabIndex = 11;
            this.cmd100.Tag = "100";
            this.cmd100.UseVisualStyleBackColor = false;
            this.cmd100.Click += new System.EventHandler(this.Importe);
            // 
            // cmd50
            // 
            this.cmd50.BackColor = System.Drawing.Color.Transparent;
            this.cmd50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd50.FlatAppearance.BorderSize = 0;
            this.cmd50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd50.Location = new System.Drawing.Point(195, 243);
            this.cmd50.Name = "cmd50";
            this.cmd50.Size = new System.Drawing.Size(54, 54);
            this.cmd50.TabIndex = 12;
            this.cmd50.Tag = "50";
            this.cmd50.UseVisualStyleBackColor = false;
            this.cmd50.Click += new System.EventHandler(this.Importe);
            // 
            // cmd20
            // 
            this.cmd20.BackColor = System.Drawing.Color.Transparent;
            this.cmd20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd20.FlatAppearance.BorderSize = 0;
            this.cmd20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd20.Location = new System.Drawing.Point(254, 243);
            this.cmd20.Name = "cmd20";
            this.cmd20.Size = new System.Drawing.Size(54, 54);
            this.cmd20.TabIndex = 13;
            this.cmd20.Tag = "20";
            this.cmd20.UseVisualStyleBackColor = false;
            this.cmd20.Click += new System.EventHandler(this.Importe);
            // 
            // cmdSigno
            // 
            this.cmdSigno.BackColor = System.Drawing.Color.Transparent;
            this.cmdSigno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdSigno.FlatAppearance.BorderSize = 0;
            this.cmdSigno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSigno.Location = new System.Drawing.Point(389, 186);
            this.cmdSigno.Name = "cmdSigno";
            this.cmdSigno.Size = new System.Drawing.Size(44, 42);
            this.cmdSigno.TabIndex = 14;
            this.cmdSigno.UseVisualStyleBackColor = false;
            this.cmdSigno.Click += new System.EventHandler(this.TipoPago);
            // 
            // cmdMas
            // 
            this.cmdMas.BackColor = System.Drawing.Color.Transparent;
            this.cmdMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdMas.FlatAppearance.BorderSize = 0;
            this.cmdMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMas.Location = new System.Drawing.Point(305, 185);
            this.cmdMas.Name = "cmdMas";
            this.cmdMas.Size = new System.Drawing.Size(65, 44);
            this.cmdMas.TabIndex = 15;
            this.cmdMas.UseVisualStyleBackColor = false;
            this.cmdMas.Click += new System.EventHandler(this.TipoPago);
            // 
            // cmdRegalo
            // 
            this.cmdRegalo.BackColor = System.Drawing.Color.Transparent;
            this.cmdRegalo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdRegalo.FlatAppearance.BorderSize = 0;
            this.cmdRegalo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRegalo.Location = new System.Drawing.Point(235, 185);
            this.cmdRegalo.Name = "cmdRegalo";
            this.cmdRegalo.Size = new System.Drawing.Size(65, 44);
            this.cmdRegalo.TabIndex = 16;
            this.cmdRegalo.UseVisualStyleBackColor = false;
            this.cmdRegalo.Click += new System.EventHandler(this.TipoPago);
            // 
            // cmdTarjeta
            // 
            this.cmdTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.cmdTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdTarjeta.FlatAppearance.BorderSize = 0;
            this.cmdTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTarjeta.Location = new System.Drawing.Point(165, 185);
            this.cmdTarjeta.Name = "cmdTarjeta";
            this.cmdTarjeta.Size = new System.Drawing.Size(65, 44);
            this.cmdTarjeta.TabIndex = 17;
            this.cmdTarjeta.UseVisualStyleBackColor = false;
            this.cmdTarjeta.Click += new System.EventHandler(this.TipoPago);
            // 
            // cmdCheque
            // 
            this.cmdCheque.BackColor = System.Drawing.Color.Transparent;
            this.cmdCheque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdCheque.FlatAppearance.BorderSize = 0;
            this.cmdCheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCheque.Location = new System.Drawing.Point(95, 185);
            this.cmdCheque.Name = "cmdCheque";
            this.cmdCheque.Size = new System.Drawing.Size(65, 44);
            this.cmdCheque.TabIndex = 18;
            this.cmdCheque.UseVisualStyleBackColor = false;
            this.cmdCheque.Click += new System.EventHandler(this.TipoPago);
            // 
            // cmdPagar
            // 
            this.cmdPagar.FlatAppearance.BorderSize = 0;
            this.cmdPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPagar.Image = global::BlackBox.Properties.Resources.cmdPagarOn;
            this.cmdPagar.Location = new System.Drawing.Point(22, 515);
            this.cmdPagar.Name = "cmdPagar";
            this.cmdPagar.Size = new System.Drawing.Size(138, 50);
            this.cmdPagar.TabIndex = 20;
            this.cmdPagar.UseVisualStyleBackColor = true;
            this.cmdPagar.Click += new System.EventHandler(this.cmdPagar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.Transparent;
            this.cmdCancelar.FlatAppearance.BorderSize = 0;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.Location = new System.Drawing.Point(367, 516);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(73, 48);
            this.cmdCancelar.TabIndex = 21;
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // imgEfectivo
            // 
            this.imgEfectivo.Location = new System.Drawing.Point(492, 12);
            this.imgEfectivo.Name = "imgEfectivo";
            this.imgEfectivo.Size = new System.Drawing.Size(63, 38);
            this.imgEfectivo.TabIndex = 22;
            this.imgEfectivo.TabStop = false;
            // 
            // imgCheque
            // 
            this.imgCheque.Image = global::BlackBox.Properties.Resources.cmdPagosCheque;
            this.imgCheque.Location = new System.Drawing.Point(492, 56);
            this.imgCheque.Name = "imgCheque";
            this.imgCheque.Size = new System.Drawing.Size(63, 38);
            this.imgCheque.TabIndex = 23;
            this.imgCheque.TabStop = false;
            // 
            // imgTarjeta
            // 
            this.imgTarjeta.Image = global::BlackBox.Properties.Resources.cmdPagosTarjeta;
            this.imgTarjeta.Location = new System.Drawing.Point(492, 101);
            this.imgTarjeta.Name = "imgTarjeta";
            this.imgTarjeta.Size = new System.Drawing.Size(63, 38);
            this.imgTarjeta.TabIndex = 24;
            this.imgTarjeta.TabStop = false;
            // 
            // imgRegalo
            // 
            this.imgRegalo.Image = global::BlackBox.Properties.Resources.cmdPagosRegalo;
            this.imgRegalo.Location = new System.Drawing.Point(492, 145);
            this.imgRegalo.Name = "imgRegalo";
            this.imgRegalo.Size = new System.Drawing.Size(63, 38);
            this.imgRegalo.TabIndex = 25;
            this.imgRegalo.TabStop = false;
            // 
            // imgMas
            // 
            this.imgMas.Image = global::BlackBox.Properties.Resources.cmdPagosMas;
            this.imgMas.Location = new System.Drawing.Point(492, 189);
            this.imgMas.Name = "imgMas";
            this.imgMas.Size = new System.Drawing.Size(63, 38);
            this.imgMas.TabIndex = 26;
            this.imgMas.TabStop = false;
            // 
            // imgTipo
            // 
            this.imgTipo.Image = global::BlackBox.Properties.Resources.cmdPagosTipo;
            this.imgTipo.Location = new System.Drawing.Point(492, 233);
            this.imgTipo.Name = "imgTipo";
            this.imgTipo.Size = new System.Drawing.Size(63, 38);
            this.imgTipo.TabIndex = 27;
            this.imgTipo.TabStop = false;
            // 
            // imgSTipo
            // 
            this.imgSTipo.Location = new System.Drawing.Point(561, 233);
            this.imgSTipo.Name = "imgSTipo";
            this.imgSTipo.Size = new System.Drawing.Size(63, 38);
            this.imgSTipo.TabIndex = 33;
            this.imgSTipo.TabStop = false;
            // 
            // imgSMas
            // 
            this.imgSMas.Location = new System.Drawing.Point(561, 189);
            this.imgSMas.Name = "imgSMas";
            this.imgSMas.Size = new System.Drawing.Size(63, 38);
            this.imgSMas.TabIndex = 32;
            this.imgSMas.TabStop = false;
            // 
            // imgSRegalo
            // 
            this.imgSRegalo.Location = new System.Drawing.Point(561, 145);
            this.imgSRegalo.Name = "imgSRegalo";
            this.imgSRegalo.Size = new System.Drawing.Size(63, 38);
            this.imgSRegalo.TabIndex = 31;
            this.imgSRegalo.TabStop = false;
            // 
            // imgSTarjeta
            // 
            this.imgSTarjeta.Location = new System.Drawing.Point(561, 101);
            this.imgSTarjeta.Name = "imgSTarjeta";
            this.imgSTarjeta.Size = new System.Drawing.Size(63, 38);
            this.imgSTarjeta.TabIndex = 30;
            this.imgSTarjeta.TabStop = false;
            // 
            // imgSCheque
            // 
            this.imgSCheque.Location = new System.Drawing.Point(561, 56);
            this.imgSCheque.Name = "imgSCheque";
            this.imgSCheque.Size = new System.Drawing.Size(63, 38);
            this.imgSCheque.TabIndex = 29;
            this.imgSCheque.TabStop = false;
            // 
            // imgSEfectivo
            // 
            this.imgSEfectivo.Image = global::BlackBox.Properties.Resources.cmdPagosSEfectivo;
            this.imgSEfectivo.Location = new System.Drawing.Point(561, 12);
            this.imgSEfectivo.Name = "imgSEfectivo";
            this.imgSEfectivo.Size = new System.Drawing.Size(63, 38);
            this.imgSEfectivo.TabIndex = 28;
            this.imgSEfectivo.TabStop = false;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(108, 42);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(118, 23);
            this.lblSubtotal.TabIndex = 34;
            this.lblSubtotal.Text = "$73.15";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuesto.Location = new System.Drawing.Point(109, 79);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(118, 23);
            this.lblImpuesto.TabIndex = 35;
            this.lblImpuesto.Text = "$5.85";
            this.lblImpuesto.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPagos
            // 
            this.lblPagos.BackColor = System.Drawing.Color.Transparent;
            this.lblPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagos.Location = new System.Drawing.Point(109, 116);
            this.lblPagos.Name = "lblPagos";
            this.lblPagos.Size = new System.Drawing.Size(118, 23);
            this.lblPagos.TabIndex = 36;
            this.lblPagos.Text = "$0.00";
            this.lblPagos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalOrden
            // 
            this.lblTotalOrden.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrden.Location = new System.Drawing.Point(109, 151);
            this.lblTotalOrden.Name = "lblTotalOrden";
            this.lblTotalOrden.Size = new System.Drawing.Size(118, 23);
            this.lblTotalOrden.TabIndex = 37;
            this.lblTotalOrden.Text = "$79.00";
            this.lblTotalOrden.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSaldo
            // 
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(345, 41);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(118, 23);
            this.lblSaldo.TabIndex = 38;
            this.lblSaldo.Text = "$79.00";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(345, 112);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(118, 23);
            this.lblTotal.TabIndex = 39;
            this.lblTotal.Text = "$79.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlackBox.Properties.Resources.cmdPagarOff;
            this.pictureBox1.Location = new System.Drawing.Point(492, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BlackBox.Properties.Resources.cmdPagarOn;
            this.pictureBox2.Location = new System.Drawing.Point(492, 333);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(217)))));
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(120, 435);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(182, 33);
            this.txtCliente.TabIndex = 42;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(337, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 31);
            this.textBox1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(324, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 44;
            this.label1.Text = "$79.00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(325, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "$79.00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(325, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 46;
            this.label3.Text = "$0.00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackBox.Properties.Resources.PagoV2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(477, 587);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblTotalOrden);
            this.Controls.Add(this.lblPagos);
            this.Controls.Add(this.lblImpuesto);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.imgSTipo);
            this.Controls.Add(this.imgSMas);
            this.Controls.Add(this.imgSRegalo);
            this.Controls.Add(this.imgSTarjeta);
            this.Controls.Add(this.imgSCheque);
            this.Controls.Add(this.imgSEfectivo);
            this.Controls.Add(this.imgTipo);
            this.Controls.Add(this.imgMas);
            this.Controls.Add(this.imgRegalo);
            this.Controls.Add(this.imgTarjeta);
            this.Controls.Add(this.imgCheque);
            this.Controls.Add(this.imgEfectivo);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdPagar);
            this.Controls.Add(this.cmdCheque);
            this.Controls.Add(this.cmdTarjeta);
            this.Controls.Add(this.cmdRegalo);
            this.Controls.Add(this.cmdMas);
            this.Controls.Add(this.cmdSigno);
            this.Controls.Add(this.cmd20);
            this.Controls.Add(this.cmd50);
            this.Controls.Add(this.cmd100);
            this.Controls.Add(this.cmd0);
            this.Controls.Add(this.cmdR100);
            this.Controls.Add(this.cmdR200);
            this.Controls.Add(this.cmd10);
            this.Controls.Add(this.cmd5);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.cmd50c);
            this.Controls.Add(this.cmd500);
            this.Controls.Add(this.cmd200);
            this.Controls.Add(this.cmdEfectivo);
            this.Name = "frmPagos";
            this.Text = "frmPagos";
            ((System.ComponentModel.ISupportInitialize)(this.imgEfectivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRegalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSMas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSRegalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSCheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSEfectivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdEfectivo;
        private System.Windows.Forms.Button cmd200;
        private System.Windows.Forms.Button cmd500;
        private System.Windows.Forms.Button cmd50c;
        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.Button cmd2;
        private System.Windows.Forms.Button cmd5;
        private System.Windows.Forms.Button cmd10;
        private System.Windows.Forms.Button cmdR200;
        private System.Windows.Forms.Button cmdR100;
        private System.Windows.Forms.Button cmd0;
        private System.Windows.Forms.Button cmd100;
        private System.Windows.Forms.Button cmd50;
        private System.Windows.Forms.Button cmd20;
        private System.Windows.Forms.Button cmdSigno;
        private System.Windows.Forms.Button cmdMas;
        private System.Windows.Forms.Button cmdRegalo;
        private System.Windows.Forms.Button cmdTarjeta;
        private System.Windows.Forms.Button cmdCheque;
        private System.Windows.Forms.Button cmdPagar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.PictureBox imgEfectivo;
        private System.Windows.Forms.PictureBox imgCheque;
        private System.Windows.Forms.PictureBox imgTarjeta;
        private System.Windows.Forms.PictureBox imgRegalo;
        private System.Windows.Forms.PictureBox imgMas;
        private System.Windows.Forms.PictureBox imgTipo;
        private System.Windows.Forms.PictureBox imgSTipo;
        private System.Windows.Forms.PictureBox imgSMas;
        private System.Windows.Forms.PictureBox imgSRegalo;
        private System.Windows.Forms.PictureBox imgSTarjeta;
        private System.Windows.Forms.PictureBox imgSCheque;
        private System.Windows.Forms.PictureBox imgSEfectivo;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblPagos;
        private System.Windows.Forms.Label lblTotalOrden;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}