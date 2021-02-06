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
        CustomCheckBox ccb = null;
        CustomCheckBox ccb2 = null;
        string _nomProducto = string.Empty;
        bool _applyEvent = true;

        public cmdMenuButton()
        {
            InitializeComponent();
        }

        public cmdMenuButton(Articulo art, Image backImg, int cols, int Raciones_Checks = 0, int MediaRacion = 0, bool cheked = false) // string description, decimal price, Image backImg, int cols)
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
            _nomProducto = art.Producto;

            if (Raciones_Checks == 0)
            {
                lblTitle.Text = item.Producto;
                lblPrice.Text = string.Format("{0:C}", item.Precio);
                lblSubOpcion.Visible = false;
            }
            else
            {
                lblSubOpcion.Visible = true;
                lblSubOpcion.Text = item.Producto;
                lblTitle.Visible = false;
                lblPrice.Visible = false;
            }
            if (cols == 3)
            {
                lblTitle.Width = 255;
                lblPrice.Width = 255;
                lblSubOpcion.Width = 255;
                this.Width = 255;
            }

            if (Raciones_Checks > 0)
            {
                ccb = new CustomCheckBox(this.Height);
                ccb.Top = 10;
                ccb.Left = this.Width - this.Height + 15;
                ccb.CheckedChanged += Ccb_CheckedChanged;
                

                this.Controls.Add(ccb);
                this.Controls.SetChildIndex(ccb, 1);
                ccb.BringToFront();

                if (cheked && (MediaRacion == 0 || MediaRacion == 1))
                    ccb.Checked = true;
            }

            if (Raciones_Checks > 1)
            {
                ccb2 = new CustomCheckBox(this.Height);
                ccb2.Top = 10;
                ccb2.Left = ccb.Left - this.Height + 15;
                ccb2.CheckedChanged += Ccb_CheckedChanged;

                this.Controls.Add(ccb2);
                this.Controls.SetChildIndex(ccb2, 2);
                ccb2.BringToFront();

                if (cheked && (MediaRacion == 0 || MediaRacion == 2))
                    ccb2.Checked = true;
            }

        }

        private void Ccb_CheckedChanged(object sender, EventArgs e)
        {
            item.AddSubOpcion = false;
            item.MediaRacion = 0;
            //((CheckBox)sender).Checked 
            bool c1 = false;
            bool c2 = false;
            if (ccb != null && ccb.Checked)
                c1 = ccb.Checked;
            if (ccb2 != null && ccb2.Checked)
                c2 = ccb2.Checked;

            if (c1 || c2)
            {
                item.AddSubOpcion = true;
                lblSubOpcion.Text = _nomProducto.ToUpper();
                lblSubOpcion.Font = new Font(lblSubOpcion.Font, FontStyle.Bold);
            }
            else
            {
                lblSubOpcion.Text = _nomProducto;
                lblSubOpcion.Font = new Font(lblSubOpcion.Font, FontStyle.Regular);
            }

            item.Producto = _nomProducto;

            


            if (ccb != null && ccb2 != null)
            {
                if (c1 && !c2)
                {
                    // item.Producto = _nomProducto + " 2";
                    item.MediaRacion = 2;
                }
                if (!c1 && c2)
                {
                    // item.Producto = _nomProducto + " 1";
                    item.MediaRacion = 1;
                }
            }

            if (MenuClicked != null && _applyEvent)
                MenuClicked(item);
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

        public void UnCheck(string producto)
        {
            _applyEvent = false;

            if (item.Producto != producto)
                ccb.Checked = false;

            _applyEvent = true;
        }
    }
}
