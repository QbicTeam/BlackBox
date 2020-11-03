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
            LoadMenu("sample");
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

        }

        private void Btn_MenuClicked(object sender)
        {
            Articulo itm = (Articulo)sender;
            MessageBox.Show(itm.Producto);
        }

        private void LoadMenu(string menuId)
        {
            int left = 0;

            for (int x = 0; x <= 16; x++)
            {
                if (x >= 13)
                {
                    left = 382;
                }


                cmdMenuButton btn = new cmdMenuButton("Pizza " + x.ToString(), 135, imgMenuHnr.Image);
                if (x < 13)
                {
                    btn.Top = x * 50;
                }
                else
                {
                    btn.Top = (x-13) * 50;
                }
                    
                btn.Left = left;
                btn.MenuClicked += Btn_MenuClicked;

                pnlMenu.Controls.Add(btn);

            }

        }

        private void cmdMenuSelected(object sender, EventArgs e)
        {

        }
    }
}
