using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackBox.Model;

namespace BlackBox.Controls
{
    public partial class cmdMenuButton : UserControl
    {
        public delegate void onMenuOtionSelected(object sender);

        public event onMenuOtionSelected MenuClicked;

        Articulo item;

        public cmdMenuButton()
        {
            InitializeComponent();
        }

        public cmdMenuButton(Articulo art, Image backImg, int cols) // string description, decimal price, Image backImg, int cols)
        {
            InitializeComponent();
            pnlButton.BackgroundImage = backImg;

            /*lblTitle.Text = description;
            lblPrice.Text = string.Format("{0:C}", price);
            
            item = new Articulo();
            item.Producto = description;
            item.Precio = price;
            */

            item = art;
            lblTitle.Text = item.Producto;
            lblPrice.Text = string.Format("{0:C}", item.Precio);

            if (cols == 3)
            {
                lblTitle.Width = 255;
                lblPrice.Width = 255;
                this.Width = 255;
            }

            CustomCheckBox ccb = new CustomCheckBox();
            ccb.Top = 5;
            ccb.Left = 5;

            this.Controls.Add(ccb);
            this.Controls.SetChildIndex(ccb, 1);
            ccb.BringToFront();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            MenuClicked(item);
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
            MenuClicked(item);
        }

        private void pnlButton_Click(object sender, EventArgs e)
        {
            MenuClicked(item);
        }
    }
}
