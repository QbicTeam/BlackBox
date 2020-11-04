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
        private Comanda comanda;
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

            pnlTotal.Location = new Point(1200, 643);
            pnlTotal.Size = new Size(308, 574);

            pnlPie.Location = new Point(44, 729);
            pnlPie.Size = new Size(1321, 39);

            pnlArtVendido artVta = new pnlArtVendido("Articulo", 123);
            pnlComanda.Controls.Add(artVta);
            artVta.Top = 0;
            artVta.ToRegular();

            pnlArtVendido artVta2 = new pnlArtVendido("Articulo2", 56.35);
            artVta2.Top = 20;
            pnlComanda.Controls.Add(artVta2);
            
            pnlArtVendido artVta3 = new pnlArtVendido("Articulo3", 1356);
            artVta3.Top = 40;
            pnlComanda.Controls.Add(artVta3);

            comanda = new Comanda();
        }

        private void LoadSideMenu()
        {
            var arts = _datos.PantallaVentas.Especiales;
            // Definir la imagen a utilizar.
            var img = imgSidebarButton.Image;

            for (int x = 0; x < arts.Count; x++)
            {
                //Button btn = new Button();
                //btn.Text = "sample " + x.ToString();
                //btn.Top = x * 100;

                cmdSideBarButton btn = new cmdSideBarButton(arts[x].Producto, arts[x].Precio, img);
                btn.Top = x * 50;
                btn.MenuClicked += Btn_MenuClicked;
                

                pnlSideContainer.Controls.Add(btn);

            }

        }

        private void Btn_MenuClicked(object sender)
        {
            Articulo itm = (Articulo)sender;
            //MessageBox.Show(itm.Producto);
            double taza = _datos.Login.Taza + 1;

            pnlArtVendido artVta = new pnlArtVendido(itm.Producto, itm.Precio);

            foreach(Control ctrl in pnlComanda.Controls)
                ((pnlArtVendido)ctrl).ToRegular();

            artVta.Top = pnlComanda.Controls.Count * 20;
            pnlComanda.Controls.Add(artVta);

            comanda.Articulos.Add(itm);

            
            comanda.Total += itm.Precio;
            comanda.SubTotal = comanda.Total / taza;
            comanda.Impuesto = comanda.Total - comanda.SubTotal;

            lblNumArts.Text = comanda.Articulos.Count().ToString();
            lblSubTotal.Text = string.Format("{0:C}", comanda.SubTotal);
            lblImpu.Text = string.Format("{0:C}", comanda.Impuesto);
            lblTotal.Text = string.Format("{0:C}", comanda.Total);

            Console.WriteLine("NumArt " + lblNumArts.Text);
            Console.WriteLine("SubTotal " + lblSubTotal.Text);
            Console.WriteLine("Impuesto " + lblImpu.Text);
            Console.WriteLine("Total " + lblTotal.Text);
            Console.WriteLine("- - - - - ");

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

            Image imagenF = imagen;
            int left = 0;

            for (int x = 0; x < menu.Count; x++)
            {
                var art = menu[x];
                if (x >= 13)
                {
                    left = 382;
                }

                if (!string.IsNullOrEmpty(art.Tipo))
                {
                    imagenF = GetImagen(art.Tipo + tamano);
                }
                // cmdMenuButton btn = new cmdMenuButton("Pizza " + x.ToString(), 135, imgMenuHnr.Image);
                cmdMenuButton btn = new cmdMenuButton(art.Producto, art.Precio, imagenF);
                imagenF = imagen;

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
                if (child.Name.ToLower() == ("imgMenu" + nombre).ToLower())
                {
                    return ((PictureBox)child).Image;
                }
            }

            return imgMenuHnr.Image;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraActual.Text = DateTime.Now.ToString("hh : mm") + (DateTime.Now.Hour <= 12 ? "a" : "p"); // "11:57a";  spa-es ddd
        }
    }
}
