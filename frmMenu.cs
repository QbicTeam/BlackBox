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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBox
{
    public partial class frmMenu : Form
    {
        private ObjBlackBox _datos;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

            // Lectura de Datos.
            var json = File.ReadAllText("appSettings.json");
            _datos = JsonConvert.DeserializeObject<ObjBlackBox>(json);

            LoadSideMenu();
            LoadMenu("HNR");
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
            pnlMenu.Controls.Clear();
            var menu = GetMenu(menuId);
            var tamano = "";
            if (menu.Count > 26) // Si son mas de 2 Columnas
                tamano = "3";
            if (menu.Count > 39) // si son mas de 3 Columnas
                tamano = "4";

            Image imagen = GetImagen(menuId + tamano);

            int left = 0;

            for (int x = 0; x < menu.Count; x++)
            {
                var art = menu[x];
                if (x >= 13)
                {
                    left = 382;
                }


                // cmdMenuButton btn = new cmdMenuButton("Pizza " + x.ToString(), 135, imgMenuHnr.Image);
                cmdMenuButton btn = new cmdMenuButton(art.Producto, art.Precio, imagen);
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
            // Console.WriteLine(sender.ToString());
            var menuTipo = ((Button)sender).Name.Substring(3);
            LoadMenu(menuTipo);

        }


        private List<Articulo> GetMenu(string nombre)
        {
            var result = new List<Articulo>();
            
            foreach (PropertyInfo prop in _datos.PantallaVentas.GetType().GetProperties())
            {
                if (prop.Name.ToLower() == nombre.ToLower())
                {
                    result = (List<Articulo>) prop.GetValue(_datos.PantallaVentas);
                    return result;
                }
            }
            return result;
        }

        private Image GetImagen(string nombre)
        {
            //this.Controls.Find("imgMenu" + nombre, true);

            foreach(Control child in Controls)
            {
                if (child.Name.ToLower() == "imgMenu" + nombre)
                {
                    return ((PictureBox)child).Image;
                }
            }

            return imgMenuHnr.Image;
        }
    }
}
