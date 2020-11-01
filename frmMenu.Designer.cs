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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSidebarButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BlackBox.Properties.Resources.tabPopular;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pnlSideContainer);
            this.panel1.Location = new System.Drawing.Point(13, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 577);
            this.panel1.TabIndex = 0;
            // 
            // pnlSideContainer
            // 
            this.pnlSideContainer.AutoScroll = true;
            this.pnlSideContainer.Location = new System.Drawing.Point(34, 3);
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
            this.pnlMenu.Location = new System.Drawing.Point(292, 63);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(764, 663);
            this.pnlMenu.TabIndex = 2;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackBox.Properties.Resources.MenuTemplate;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1430, 841);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.imgSidebarButton);
            this.Controls.Add(this.panel1);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSidebarButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSideContainer;
        private System.Windows.Forms.PictureBox imgSidebarButton;
        private System.Windows.Forms.Panel pnlMenu;
    }
}