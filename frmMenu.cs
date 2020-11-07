using BlackBox.Controls;
using BlackBox.Helper;
using BlackBox.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
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
            resetMenuButtons();

            // Lectura de Datos.
            var json = File.ReadAllText("appSettings.json");
            _datos = JsonConvert.DeserializeObject<ObjBlackBox>(json);

            LoadSideMenu();
            LoadMenu("HNR");
            cmdHnr.Image = imgSHnr.Image;

            pnlTotal.Location = new Point(1200, 643);
            pnlTotal.Size = new Size(308, 574);

            pnlPie.Location = new Point(44, 729);
            pnlPie.Size = new Size(1321, 39);

            lblCajero.Text = _datos.Login.Cajero;
            lblArticulosPie.Text = _datos.PantallaVentas.ArticulosVencidosPie;

            comanda = new Comanda();
        }

        private void resetMenuButtons()
        {
            cmdHnr.Image = imgHnr.Image;
            cmdPizza.Image = imgPizza.Image;
            cmdPan.Image = imgPan.Image;
            cmdBebidas.Image = imgBebidas.Image;
            cmdAlas.Image = imgAlas.Image;
            cmdComplementos.Image = imgComplementos.Image;
            cmdNoComida.Image = imgNoComida.Image;
            cmdOtrasComidas.Image = imgOtrasComidas.Image;
            cmdUber.Image = imgUber.Image;
            cmdRappi.Image = imgRappi.Image;
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

            artVta.Top = pnlComanda.Controls.Count * 27;
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

            var tamanoN = 0;
            if (tamano != "")
                tamanoN = Convert.ToInt32(tamano);

            Image imagenF = imagen;
            int left = 0;
            int top = -1;
            // 2 col: 382; 3 col: 255 w 
            for (int x = 0; x < menu.Count; x++)
            {
                var art = menu[x];
                if (x >= 13 && x < 26 && tamanoN == 0 )
                    left = 382;

                if (x >= 13 && x < 26 && tamanoN == 3)
                    left = 255;

                if (x >= 26 && tamanoN == 3)
                    left = 510;

                if (!string.IsNullOrEmpty(art.Tipo))
                {
                    imagenF = GetImagen(art.Tipo + tamano);
                }
                // cmdMenuButton btn = new cmdMenuButton("Pizza " + x.ToString(), 135, imgMenuHnr.Image);
                cmdMenuButton btn = new cmdMenuButton(art.Producto, art.Precio, imagenF, tamanoN);
                imagenF = imagen;

                //if (x < 13)
                //{
                //    btn.Top = x * 50;
                //}
                //else
                //{
                //    btn.Top = (x-13) * 50;
                //}

                if (top >= 12)
                    top = -1;

                top++;
                
                btn.Top = top * 50;                    
                btn.Left = left;
                
                //if (tamano == "3")
                //    btn.Width = 255;

                btn.MenuClicked += Btn_MenuClicked;

                pnlMenu.Controls.Add(btn);

            }

        }

        private void cmdMenuSelected(object sender, EventArgs e)
        {
            // Console.WriteLine(sender.ToString());
            var menuTipo = ((Button)sender).Name.Substring(3);
            LoadMenu(menuTipo);
            SetMenuButton(menuTipo);
        }

        private void SetMenuButton(string mnu)
        {
            resetMenuButtons();
            switch (mnu.ToLower())
            {
                case "hnr":
                    cmdHnr.Image = imgSHnr.Image;
                    break;
                case "pizza":
                    cmdPizza.Image = imgSPizza.Image;
                    break;
                case "pan":
                    cmdPan.Image = imgSPan.Image;
                    break;
                case "bebidas":
                    cmdBebidas.Image = imgSBebidas.Image;
                    break;
                case "alas":
                    cmdAlas.Image = imgSAlas.Image;
                    break;
                case "complementos":
                    cmdComplementos.Image = imgSComplementos.Image;
                    break;
                case "nocomida":
                    cmdNoComida.Image = imgSNoComida.Image;
                    break;
                case "otrascomidas":
                    cmdOtrasComidas.Image = imgSOtrasComidas.Image;
                    break;
                case "uber":
                    cmdUber.Image = imgSUber.Image;
                    break;
                case "rappi":
                    cmdRappi.Image = imgSRappi.Image;
                    break;
                default:
                    break;
            }
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

            foreach(Control child in pnlMenuColores.Controls)
            {
                if (child.Name.ToLower() == ("imgMenu" + nombre).ToLower())
                {
                    return ((PictureBox)child).Image;
                }
            }

            return imgMenuHnr.Image;
        }

        public void ComandaNueva()
        {
            pnlComanda.Controls.Clear();

            comanda = new Comanda();

            lblNumArts.Text = comanda.Articulos.Count().ToString();
            lblSubTotal.Text = string.Format("{0:C}", comanda.SubTotal);
            lblImpu.Text = string.Format("{0:C}", comanda.Impuesto);
            lblTotal.Text = string.Format("{0:C}", comanda.Total);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraActual.Text = DateTime.Now.ToString("hh : mm") + (DateTime.Now.Hour <= 12 ? "a" : "p"); // "11:57a";  spa-es ddd
        }

        private void cmdPagos_Click(object sender, EventArgs e)
        {
            frmPagos pagos = new frmPagos();
            if (pagos.PaySale())
            {
                PrintSale();
            }
        }

        private void PrintSale()
        {
            MessageBox.Show("printing sale...");

            var strRecibo = new StringBuilder();

            strRecibo.AppendLine("Store ID 04122-00007"); // Centrar.
            strRecibo.AppendLine("Phone");// Centrar
            strRecibo.AppendLine("");
            strRecibo.AppendLine("LITTLE CAESARS PIZZA");
            strRecibo.AppendLine("GRUPO LICA BAJA S.A DE C.V");
            strRecibo.AppendLine("RFC GLB150904CU1");
            strRecibo.AppendLine("BLCD. DIAZ ORDAZ #12678 EL PRADO");
            strRecibo.AppendLine("TIJUANA BAJA CALIFORNIA C.P. 22105");
            strRecibo.AppendLine("");
            strRecibo.AppendLine("Orden #13 121 "); // Centrar
            strRecibo.AppendLine("LUIS"); // Centrar
            strRecibo.AppendLine("Vie. Oct. 30. 2020 08:11pm");
            strRecibo.AppendLine("Estimado para Vie, Oct 30, 2020 08:11pm");
            strRecibo.AppendLine("Su cajero del dia de hoy es SAMANTA Q.");
            strRecibo.AppendLine("");
            strRecibo.AppendLine("SALE");
            strRecibo.AppendLine("");
            strRecibo.AppendLine("Articulo                             Precio");
            foreach (Articulo art in comanda.Articulos)
            {
                strRecibo.AppendLine(art.Producto + new string(' ' , 5) + art.Precio.ToString());
            }

            strRecibo.AppendLine("Conteo de Art                             " + comanda.Articulos.Count.ToString());
            strRecibo.AppendLine("Taxble Total                             " + comanda.SubTotal.ToString());
            strRecibo.AppendLine("");
            strRecibo.AppendLine("Ventas Imp.                             " + comanda.Impuesto.ToString());
            strRecibo.AppendLine("");
            strRecibo.AppendLine("TOTAL                             " + comanda.Total.ToString());
            strRecibo.AppendLine("Efectivo                             " + comanda.Total.ToString());
            strRecibo.AppendLine("2334                             000033");


            var printText = new PrintText(strRecibo.ToString(), new Font("Monospace Please...", 8));

            var AvailableWidth = 80;

            if (PrinterSettings.InstalledPrinters.Count == 0)
                return;

            var printerList = new List<string>();
            foreach (String printer in PrinterSettings.InstalledPrinters)
            {
                // printersList.Itmes.Add(printer.ToString());
                printerList.Add(printer.ToString());
            }

            prtdImprimir = new PrintDocument();
            var ps = new PrinterSettings();
            prtdImprimir.PrinterSettings = ps;
            prtdImprimir.PrintPage += Imprimir;
            prtdImprimir.Print();

           /* var e = PrinterSettings.InstalledPrinters[0];
            var layoutArea = new SizeF(AvailableWidth, 0);
            e.
            Graphics g = e.Graphics;
            SizeF stringSize = g.MeasureString(printText.Text, printText.Font, layoutArea, printText.StringFormat);

            RectangleF rectf = new RectangleF(new PointF(), new SizeF(AvailableWidth, stringSize.Height));

            g.DrawString(printText.Text, printText.Font, Brushes.Black, rectf, printText.StringFormat);


            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;


            ComandaNueva();*/
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Aria", 14, FontStyle.Regular, GraphicsUnit.Point);
            int width = 200;
            int y = 20;
            e.Graphics.DrawString("Un ticket Felix", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Un ticket Felix 2", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
        }
    }
}
