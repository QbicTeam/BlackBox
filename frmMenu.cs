using BlackBox.Controls;
using BlackBox.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBox
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            LoadSideMenu();
        }

        private void LoadSideMenu()
        {
            for (int x = 0; x <= 15; x++)
            {
                //Button btn = new Button();
                //btn.Text = "sample " + x.ToString();
                //btn.Top = x * 100;

                cmdSideBarButton btn = new cmdSideBarButton("Pizza", 135, imgSidebarButton.Image);
                btn.Top = x * 50;
                btn.MenuClicked += Btn_MenuClicked;
                

                pnlSideContainer.Controls.Add(btn);

            }

            cmdMenuButton btnMenu = new cmdMenuButton();
            pnlMenu.Controls.Add(btnMenu);
        }

        private void Btn_MenuClicked(object sender)
        {
            Articulo itm = (Articulo)sender;

            MessageBox.Show(itm.Producto);
        }


    }
}
