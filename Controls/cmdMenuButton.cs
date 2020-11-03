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

        public cmdMenuButton(string description, double price, Image backImg)
        {
            InitializeComponent();
            pnlButton.BackgroundImage = backImg;

            lblTitle.Text = description;
            lblPrice.Text = string.Format("{0:C}", price);

            item = new Articulo();
            item.Producto = description;
            item.Precio = price;
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
