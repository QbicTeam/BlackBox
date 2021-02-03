namespace BlackBox.Controls
{
    partial class cmdSideBarButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmdOption = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Image = global::BlackBox.Properties.Resources.lblSideBarPrice;
            this.lblPrice.Location = new System.Drawing.Point(3, 30);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(212, 7);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "$ 12.00";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Image = global::BlackBox.Properties.Resources.lblSidebarName;
            this.lblName.Location = new System.Drawing.Point(3, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(212, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Classic Pepperoni";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // cmdOption
            // 
            this.cmdOption.BackColor = System.Drawing.Color.Transparent;
            this.cmdOption.BackgroundImage = global::BlackBox.Properties.Resources.cmdSidebarTemplate;
            this.cmdOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdOption.FlatAppearance.BorderSize = 0;
            this.cmdOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOption.Location = new System.Drawing.Point(0, 0);
            this.cmdOption.Name = "cmdOption";
            this.cmdOption.Size = new System.Drawing.Size(219, 50);
            this.cmdOption.TabIndex = 2;
            this.cmdOption.UseVisualStyleBackColor = false;
            this.cmdOption.Click += new System.EventHandler(this.cmdOption_Click);
            // 
            // cmdSideBarButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmdOption);
            this.Name = "cmdSideBarButton";
            this.Size = new System.Drawing.Size(219, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button cmdOption;
    }
}
