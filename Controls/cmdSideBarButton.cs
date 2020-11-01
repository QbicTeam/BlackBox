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
    public partial class cmdSideBarButton : UserControl
    {
        public delegate void onMenuOtionSelected(object sender);

        public event onMenuOtionSelected MenuClicked;

        Articulo item;

        public cmdSideBarButton()
        {
            InitializeComponent();
        }

        public cmdSideBarButton(string description, double price, Image backImg)
        {
            InitializeComponent();
            cmdOption.BackgroundImage = backImg;

            lblName.Text = description;
            lblPrice.Text = string.Format("{0:C}", price);

            item = new Articulo();
            item.Producto = description;
            item.Precio = price;
        }

        private void cmdOption_Click(object sender, EventArgs e)
        {
            MenuClicked(item);
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            MenuClicked(item);
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
            MenuClicked(item);
        }
    }
}
