using BlackBox.Bussiness;
using BlackBox.Controls;
using BlackBox.Helper;
using BlackBox.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BlackBox
{
    public partial class frmMenu : Form
    {
        private ObjBlackBox _datos;
        private Comanda comanda;
        private Form _entryForm;
        private pnlArtVendido _artVendidoSeleccionado;
        private int _opcionLocationY;
        private MMenu _menu;
        private int _noRecibo;

        private int caracteresMaximos = 56;
        private string[] dias = { "Dom", "Lun", "Mar", "Mie", "Jue", "Vie", "Sab" };
        private string[] meses = { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };
        private string _format = "{0:$#######.00}";

        
        private VentasManager vtasManager = new VentasManager(ConfigurationManager.ConnectionStrings["FBBCS"].ConnectionString);

        public frmMenu()
        {
            InitializeComponent();
        }

        public void SetEntryForm(Form entryForm)
        {
            this._entryForm = entryForm;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            resetMenuButtons();
            SetMenuSettings();
            this.FormBorderStyle = FormBorderStyle.None;

            // Lectura de Datos.
            var json = File.ReadAllText("appSettings.json");
            _datos = JsonConvert.DeserializeObject<ObjBlackBox>(json);

            var jsonMenu = File.ReadAllText("appConfigM.json");
            _menu = JsonConvert.DeserializeObject<MMenu>(jsonMenu);

            _noRecibo = _datos.Login.NoRecibo;

            // this._conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FBBCS"].ConnectionString);

            LoadSideMenu();
            cmdHnr.Image = imgSHnr.Image;
            FillMenus();

            pnlTotal.Location = new Point(1200, 643);
            pnlTotal.Size = new Size(308, 574);

            pnlPie.Location = new Point(44, 729);
            pnlPie.Size = new Size(1321, 39);

            lblCajero.Text = _datos.Login.Cajero;
            lblArticulosPie.Text = _datos.PantallaVentas.ArticulosVencidosPie;

            comanda = new Comanda();
            BotonesMasMenosBorrar();
        }

        private void SetMenuSettings()
        {

            pnlMenu.Height = 663;
            pnlMenu.Width = 764;
            pnlMenu.Location = new Point(290, 63);

            pnlSubMenu.Height = 663;
            pnlSubMenu.Width = 764;
            pnlSubMenu.Location = new Point(290, 63);
            pnlSubMenu.Visible = false;
            

            pnlPizzas.Height = 663;
            pnlPizzas.Width = 764;
            pnlPizzas.Location = new Point(290, 63);

            pnlPanes.Height = 663;
            pnlPanes.Width = 764;
            pnlPanes.Location = new Point(290, 63);

            pnlBebidas.Height = 663;
            pnlBebidas.Width = 764;
            pnlBebidas.Location = new Point(290, 63);

            pnlAlas.Height = 663;
            pnlAlas.Width = 764;
            pnlAlas.Location = new Point(290, 63);

            pnlComplementos.Height = 663;
            pnlComplementos.Width = 764;
            pnlComplementos.Location = new Point(290, 63);

            pnlNoComidas.Height = 663;
            pnlNoComidas.Width = 764;
            pnlNoComidas.Location = new Point(290, 63);

            pnlOtrasComidas.Height = 663;
            pnlOtrasComidas.Width = 764;
            pnlOtrasComidas.Location = new Point(290, 63);

            pnlUbers.Height = 663;
            pnlUbers.Width = 764;
            pnlUbers.Location = new Point(290, 63);

            pnlRappis.Height = 663;
            pnlRappis.Width = 764;
            pnlRappis.Location = new Point(290, 63);

        }

        private void FillMenus()
        {
            LoadMenu("HNR", pnlMenu);
            LoadMenu("Pizza", pnlPizzas);
            LoadMenu("Pan", pnlPanes);
            LoadMenu("Bebidas", pnlBebidas);
            LoadMenu("Alas", pnlAlas);
            LoadMenu("Complementos", pnlComplementos);
            LoadMenu("NoComida", pnlNoComidas);
            LoadMenu("OtrasComidas", pnlOtrasComidas);
            LoadMenu("Uber", pnlUbers);
            LoadMenu("Rappi", pnlRappis);
        }

        private void TurnOffMenus()
        {
            pnlMenu.Visible = false;
            pnlSubMenu.Visible = false;
            pnlPizzas.Visible = false;
            pnlPanes.Visible = false;
            pnlBebidas.Visible = false;
            pnlAlas.Visible = false;
            pnlComplementos.Visible = false;
            pnlNoComidas.Visible = false;
            pnlOtrasComidas.Visible = false;
            pnlUbers.Visible = false;
            pnlRappis.Visible = false;
        }

        private void TurnOnMenu(string menu)
        {
            _artVendidoSeleccionado = null;
            _opcionLocationY = 0;
            switch (menu)
            {
                case "Hnr":
                    pnlMenu.Visible = true;
                    break;
                case "Pizza":
                    pnlPizzas.Visible = true;
                    break;
                case "Pan":
                    pnlPanes.Visible = true;
                    break;
                case "Bebidas":
                    pnlBebidas.Visible = true;
                    break;
                case "Alas":
                    pnlAlas.Visible = true;
                    break;
                case "Complementos":
                    pnlComplementos.Visible = true;
                    break;
                case "NoComida":
                    pnlNoComidas.Visible = true;
                    break;
                case "OtrasComidas":
                    pnlOtrasComidas.Visible = true;
                    break;
                case "Uber":
                    pnlUbers.Visible = true;
                    break;
                case "Rappi":
                    pnlRappis.Visible = true;
                    break;
                default:
                    break;
            }
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
            var arts = _menu.Especiales; // _datos.PantallaVentas.Especiales;
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
            // decimal taza = _datos.Login.Taza + 1;

            // TODO Remover, es temporal
            /*if (itm.Producto.ToLower() == "combo crazy crunsh")
            {
                itm.Cantidad = 2;
                itm.Opciones = new List<ArticuloOpcion>();
                itm.Opciones.Add(new ArticuloOpcion() { 
                     ArticuloOp = new Articulo() { Producto = "Crazy Crunch"},
                     Intercambiable = false
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Crazy Bread Relleno" },
                    Intercambiable = false
                });
                itm.ComboTipo = "Combo";
            }*/
            /*if (itm.Producto.ToLower() == "combo cu4tro2.0")
            {
                itm.Cantidad = 2;
                itm.Opciones = new List<ArticuloOpcion>();
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Cu4tro2.0" },
                    Intercambiable = false
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Crazy Bread Relleno" },
                    Intercambiable = false
                });
                itm.ComboTipo = "Combo";
            }*/
            /*if (itm.Producto.ToLower() == "italian pack")
            {
                itm.Cantidad = 3;
                itm.Opciones = new List<ArticuloOpcion>();
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Classic Pepperoni", 
                         Opciones = new List<ArticuloOpcion>() { 
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Classic Pepperoni" } },
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "3 Meat" } },
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Cu4tro2.0" } }
                         }
                    },
                    Intercambiable = true,
                    Default = true
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "ICB" },
                    Intercambiable = false
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Refresco 2L", ComboTipo = "CustomEsp", Validar = true,
                        Opciones = new List<ArticuloOpcion>() { 
                            new ArticuloOpcion() { Articulo = new Articulo() { Producto = "Pepsi" } }
                            ,new ArticuloOpcion() { Articulo = new Articulo() { Producto = "Pepsi Light" } }
                            ,new ArticuloOpcion() { Articulo = new Articulo() { Producto = "7 Up" } }
                            ,new ArticuloOpcion() { Articulo = new Articulo() { Producto = "Manzanita Sol" } }
                            ,new ArticuloOpcion() { Articulo = new Articulo() { Producto = "Mirinda" } }
                            ,new ArticuloOpcion() { Articulo = new Articulo() { Producto = "Sangria" } }
                            ,new ArticuloOpcion() { Articulo = new Articulo() { Producto = "Squirt" } }
                        } 
                    },
                    Intercambiable = true
                });
                itm.ComboTipo = "Combo";
            }*/
            /*if (itm.Producto.ToLower() == "2x15 aderezos")
            {
                itm.Opciones = new List<ArticuloOpcion>();
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo()
                    {
                        Producto = "[ADEREZOS]",
                        Opciones = new List<ArticuloOpcion>() {
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Buffalo Ranch Dip" } },
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Ranch Dip" } },
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Buffalo Dip" } },
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Cheesy Jalapeno Dip" } }
                         }
                    },
                    Intercambiable = true,
                    Default = false
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo()
                    {
                        Producto = "[ADEREZOS]",
                        Opciones = new List<ArticuloOpcion>() {
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Buffalo Ranch Dip" } },
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Ranch Dip" } },
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Buffalo Dip" } },
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Cheesy Jalapeno Dip" } }
                         }
                    },
                    Intercambiable = true,
                    Default = false
                });
                itm.ComboTipo = "Combo";
            }*/
            /*if (itm.Producto.ToLower() == "3x20 aderezos")
            {
                itm.Opciones = new List<ArticuloOpcion>();
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo()
                    {
                        Producto = "[ADEREZOS]",
                        Opciones = new List<ArticuloOpcion>() {
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Buffalo Ranch Dip" } },
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Ranch Dip" } },
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Buffalo Dip" } },
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Cheesy Jalapeno Dip" } }
                         }
                    },
                    Intercambiable = true,
                    Default = false
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo()
                    {
                        Producto = "[ADEREZOS]",
                        Opciones = new List<ArticuloOpcion>() {
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Buffalo Ranch Dip" } },
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Ranch Dip" } },
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Buffalo Dip" } },
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Cheesy Jalapeno Dip" } }
                         }
                    },
                    Intercambiable = true,
                    Default = false
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo()
                    {
                        Producto = "[ADEREZOS]",
                        Opciones = new List<ArticuloOpcion>() {
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Buffalo Ranch Dip" } },
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Ranch Dip" } },
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Buffalo Dip" } },
                             new ArticuloOpcion() { Default = false, Intercambiable = true, Articulo = new Articulo() { Producto = "Cheesy Jalapeno Dip" } }
                         }
                    },
                    Intercambiable = true,
                    Default = false
                });
                itm.ComboTipo = "Combo";
            }*/
            /*if (itm.Producto.ToLower() == "custom pizza")
            {
                itm.Cantidad = 1;
                itm.Opciones = new List<ArticuloOpcion>();
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Salsa" },
                    Intercambiable = true,
                    Default = true
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Queso" },
                    Intercambiable = false,
                    Default = true
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Extra Queso" },
                    Intercambiable = false,
                    Default = false
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Pepperoni" },
                    Intercambiable = false,
                    Default = false
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Salchicha Italiana" },
                    Intercambiable = false,
                    Default = false
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Jamon" },
                    Intercambiable = false,
                    Default = false
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Pimento Verde" },
                    Intercambiable = false,
                    Default = false
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Champinones" },
                    Intercambiable = false,
                    Default = false
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Cebolla" },
                    Intercambiable = false,
                    Default = false
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Aceitunas Negras" },
                    Intercambiable = false,
                    Default = false
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Jalapeno" },
                    Intercambiable = false,
                    Default = false
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Pina" },
                    Intercambiable = false,
                    Default = false
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Chorizo" },
                    Intercambiable = false,
                    Default = false
                });
                itm.ComboTipo = "Custom";
            }*/
            /*if (itm.Producto.ToLower() == "caesar wings")
            {
                itm.Cantidad = 1;
                itm.Opciones = new List<ArticuloOpcion>();
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Over Roasted" },
                    Intercambiable = true,
                    Default = false
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Buffalo" },
                    Intercambiable = false,
                    Default = false
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "BBQ" },
                    Intercambiable = false,
                    Default = false
                });
                itm.Opciones.Add(new ArticuloOpcion()
                {
                    ArticuloOp = new Articulo() { Producto = "Spicy BBQ" },
                    Intercambiable = false,
                    Default = false
                });
                itm.ComboTipo = "Custom";
            }*/
            //--


            if (_artVendidoSeleccionado != null && _opcionLocationY > 0 && pnlSubMenu.Visible) // Aqui validar que se trate de un sub Menu
            {
                var mas = true;
                var racion = 0;
                _artVendidoSeleccionado.ArticuloOpcion(itm, _opcionLocationY, mas, racion); // true);
                // TODO: Validar si se sale o no.
                return;
            }


            pnlArtVendido artVta = new pnlArtVendido(itm); // itm.Producto, itm.Precio);

            int height = 0;
            foreach (Control ctrl in pnlComanda.Controls)
            {
                ((pnlArtVendido)ctrl).ToRegular();
                height += ctrl.Height;
            }


            artVta.Top = height; // pnlComanda.Controls.Count * 27;
            artVta.OpcionClicked += OpcionClicked;
            artVta.ArticuloYsChange += ArticuloYsChange;
            artVta.ArticuloMasMenosChange += ArticuloMasMenosChange;

            pnlComanda.Controls.Add(artVta);
            _artVendidoSeleccionado = artVta;

            comanda.Articulos.Add(itm);

            _artVendidoSeleccionado.ToSelected(_artVendidoSeleccionado._opAutoSelectLocationY, true);

            CalcularTotal();
            BotonesMasMenosBorrar();
            /*
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
            */
        }

        private void LoadMenu(string menuId, Panel container)
        {
            // container.Controls.Clear();
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
                cmdMenuButton btn = new cmdMenuButton(art, imagenF, tamanoN); // art.Producto, art.Precio, imagenF, tamanoN);
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

                container.Controls.Add(btn);

            }

        }

        private void cmdMenuSelected(object sender, EventArgs e)
        {
            //Console.WriteLine(sender.ToString());
            var menuTipo = ((Button)sender).Name.Substring(3);
            //MessageBox.Show(menuTipo);
            TurnOffMenus();
            TurnOnMenu(menuTipo);
            // LoadMenu(menuTipo);
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
            
            foreach (PropertyInfo prop in _menu.GetType().GetProperties()) // _datos.PantallaVentas.GetType().GetProperties())
            {
                if (prop.Name.ToLower() == nombre.ToLower())
                {
                    result = (List<Articulo>)prop.GetValue(_menu); //_datos.PantallaVentas);
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
            lblSubTotal.Text = string.Format(_format, comanda.SubTotal);
            lblImpu.Text = string.Format(_format, comanda.Impuesto);
            lblTotal.Text = string.Format(_format, comanda.Total);

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
            // MessageBox.Show("printing sale...");

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
            Font font = new Font("Courier New", 10, FontStyle.Regular, GraphicsUnit.Point);
            Font fontBold = new Font("Courier New", 11, FontStyle.Bold, GraphicsUnit.Point);
            Font fontS = new Font("Courier New", 10, FontStyle.Underline, GraphicsUnit.Point);
            Font font_1 = new Font("Courier New", 9, FontStyle.Regular, GraphicsUnit.Point);
            Font font_2 = new Font("Courier New", 8, FontStyle.Regular, GraphicsUnit.Point);
            Font font1 = new Font("Courier New", 11, FontStyle.Regular, GraphicsUnit.Point);
            Font font2 = new Font("Courier New", 12, FontStyle.Regular, GraphicsUnit.Point);

            var vta = new Venta();
            vta.Productos = new List<VentaDT>();
            var vDT = new VentaDT();

            vta.FechaHora = DateTime.Now;
            vta.Cajero = _datos.Login.Cajero;
            vta.Recibo = _noRecibo.ToString();
            vta.CantidadArticulos = Convert.ToInt32(lblNumArts.Text);
            vta.SubTotal = comanda.SubTotal;
            vta.Impuestos = comanda.Impuesto;
            vta.Total = comanda.Total;
            vta.EnCorte = 0;
            vta.Cancelado = false;

            // TODO: Mandar a grabar la venta.

            // vta.VentaId = vtasManager.SaveVenta(vta); 

            var nivelP = 0;
            var espaciosTap = 5;


            // int caracteresMaximos = 56;
            int width = 490;
            int y = 20;
            string txt = string.Empty;

            //string hoy = string.Empty;
            var diai = (int)DateTime.Today.DayOfWeek;
            var dia = dias[diai];
            var mes = meses[DateTime.Today.Month - 1];


            var hoy = string.Format("{0}, {1} {2}, {3} {4}{5}",dia,mes, DateTime.Today.Day, DateTime.Today.Year, DateTime.Now.ToString("hh:mm"), (DateTime.Now.Hour <= 12 ? "am" : "pm"));  // dia + " " + DateTime.Now.ToString("hh:mm") + (DateTime.Now.Hour <= 12 ? "am" : "pm"); // "Lun 11:57 am";  spa-es ddd

            _noRecibo++;

            // e.Graphics.DrawString("12345678901234567890123456789012345678901234567890123456XXX", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            txt = "Store ID 04122 - 00007";
            e.Graphics.DrawString(CentrarRenglonRecibo(txt), font, Brushes.Black, new RectangleF(0, y += 20, width, 20)); // Centrar.
            e.Graphics.DrawString(CentrarRenglonRecibo("Phone"), font, Brushes.Black, new RectangleF(0, y += 21, width, 20));// Centrar
            e.Graphics.DrawString("", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("LITTLE CAESARS PIZZA", font1, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString(_datos.Login.Empresa, font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString(_datos.Login.RFC, font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString(_datos.Login.DireccionR1, font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString(_datos.Login.DireccionR2, font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString(CentrarRenglonRecibo("Orden " + _datos.Login.Caja + " " + _noRecibo.ToString()), font, Brushes.Black, new RectangleF(0, y += 20, width, 20)); // Centrar
            e.Graphics.DrawString(CentrarRenglonRecibo("nombre cliente pelon"), font, Brushes.Black, new RectangleF(0, y += 20, width, 20)); // Centrar
            e.Graphics.DrawString(CentrarRenglonRecibo(hoy), font, Brushes.Black, new RectangleF(0, y += 20, width, 20)); // "Vie. Oct. 30. 2020 08:11pm"
            e.Graphics.DrawString(CentrarRenglonRecibo("Estimado para " + hoy, 2), font2, Brushes.Black, new RectangleF(0, y += 22, width, 20)); // Vie, Oct 30, 2020 08:11pm"
            e.Graphics.DrawString(CentrarRenglonRecibo("Su cajero del dia de hoy es " + _datos.Login.Cajero, -1), font_1, Brushes.Black, new RectangleF(0, y += 19, width, 20));
            e.Graphics.DrawString("", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString(CentrarRenglonRecibo("SALE"), font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString(RenglonProductoTextosRecibo("Articulo","Precio"), fontS, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            
            foreach (Articulo art in comanda.Articulos)
            {
                
                e.Graphics.DrawString(RenglonProductoRecibo(art.Producto, art.Precio), font, Brushes.Black, new RectangleF(0, y += 20, width, 20));

                nivelP = 0;
                vDT = new VentaDT();
                vDT.VentaId = vta.VentaId;
                vDT.Producto = art.Producto;
                vDT.Cantidad = art.Cantidad;
                vDT.Precio = art.Precio;
                vDT.Nivel = nivelP;
                vDT.ProductoPadre = string.Empty;
                vta.Productos.Add(vDT);

                if (art.Opciones != null && art.Opciones.Count() > 0)
                {
                    foreach(ArticuloOpcion artOp in art.Opciones)
                    {
                        if (art.ComboTipo.ToLower().StartsWith("custom") && !artOp.Default)
                            continue;
                        
                        nivelP = 1;
                        vDT = new VentaDT();
                        vDT.VentaId = vta.VentaId;
                        vDT.Producto = artOp.ArticuloOp.Producto;
                        //vDT.Cantidad = art.Cantidad;
                        //vDT.Precio = art.Precio;
                        vDT.Nivel = nivelP;
                        vDT.ProductoPadre = art.Producto;

                        vta.Productos.Add(vDT);

                        e.Graphics.DrawString(RenglonProductoRecibo(new string(' ', espaciosTap * nivelP) + artOp.ArticuloOp.Producto, 0), font_2, Brushes.Black, new RectangleF(0, y += 15, width, 20));

                        if (!string.IsNullOrEmpty(artOp.ArticuloOp.ComboTipo) && artOp.ArticuloOp.ComboTipo.ToLower() == "customesp" 
                            && artOp.ArticuloOp.Opciones != null && artOp.ArticuloOp.Opciones.Count() > 0)
                        {
                            foreach (ArticuloOpcion artOpN2 in artOp.ArticuloOp.Opciones)
                            {
                                if (!artOpN2.Default)
                                    continue;

                                nivelP = 2;
                                vDT = new VentaDT();
                                vDT.VentaId = vta.VentaId;
                                vDT.Producto = artOpN2.Articulo.Producto;
                                //vDT.Cantidad = art.Cantidad;
                                //vDT.Precio = art.Precio;
                                vDT.Nivel = nivelP;
                                vDT.ProductoPadre = artOp.ArticuloOp.Producto;

                                vta.Productos.Add(vDT);

                                e.Graphics.DrawString(RenglonProductoRecibo(new string(' ', espaciosTap * nivelP) + artOpN2.Articulo.Producto, 0), font_2, Brushes.Black, new RectangleF(0, y += 15, width, 20));

                            }
                        }

                    }
                }
                //new string(' ', espacios)
            }

            e.Graphics.DrawString(new string('_', caracteresMaximos), font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString(RenglonProductoRecibo("Conteo de Art", comanda.Articulos.Count()), font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString(RenglonProductoRecibo("Taxble Total", comanda.SubTotal), fontS, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString(RenglonProductoRecibo("Ventas Imp.", comanda.Impuesto), font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString(RenglonProductoRecibo("TOTAL", comanda.Total, 1), fontBold, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString(RenglonProductoRecibo("Efectivo", comanda.Total), font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString(RenglonProductoTextosRecibo("2334" , "000033", -1), font_1, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            // e.Graphics.DrawString("12345678901234567890123456789012345678901234567890123456XXX", fontBold, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            // e.Graphics.DrawString("123456789012345678901234567890123456789012345678901234567890123456789", font_1, Brushes.Black, new RectangleF(0, y += 20, width, 20));


            // TODO: Mandar a grabar el detalle de la venta.

        }

        private string CentrarRenglonRecibo(string text, int tipo = 0)
        {
            var len = text.Length;
            if (tipo == -1)
                len = (int)(len / 1.4);
            if (tipo == 1)
                len = (int)(len * 1.1);
            if (tipo == 2)
                len = (int)(len * 1.2);


            var libre = caracteresMaximos - len;
            var mitad = libre / 2;

            return new string(' ', mitad) + text;
        }

        private string RenglonProductoRecibo(string nombre, decimal precio, int tipo = 0)
        {
            var precioS = string.Empty;
            if (precio > 0)
                precioS = string.Format(_format, precio);

            var cUsados = precioS.Length + nombre.Length;
            var espacios = caracteresMaximos - cUsados;

            if (tipo == 1)
                espacios = espacios - (caracteresMaximos - 51);

            return nombre + (precio > 0 ? new string(' ', espacios) + precioS : "");
        }
        private string RenglonProductoTextosRecibo(string texto1, string texto2, int tipo = 0)
        {
            var espacios = caracteresMaximos - (texto1.Length + texto2.Length);
            if (tipo == -1)
                espacios = espacios + (62 - caracteresMaximos);

            return texto1 + new string(' ', espacios) + texto2;
        }
        private void cmdClose_Click(object sender, EventArgs e)
        {
            this._entryForm.Close();
        }

        private void cmdEspeciales_Click(object sender, EventArgs e)
        {
            pnlTabs.BackgroundImage = imgEspeciales.Image;
        }

        private void cmdEnEspera_Click(object sender, EventArgs e)
        {
            pnlTabs.BackgroundImage = imgEnEspera.Image;

        }

        private void cmdOnline_Click(object sender, EventArgs e)
        {
            pnlTabs.BackgroundImage = imgOnline.Image;

        }

        private void cmdReciente_Click(object sender, EventArgs e)
        {
            pnlTabs.BackgroundImage = imgRecientes.Image;
        }

        private void OpcionClicked(object sender, int articuloPadreLocacionY, int intercambiableLocacionY, Articulo artOp)
        {
            Console.WriteLine("Click en opcion Comanda - frmMenu");
            var artVdo = (Articulo)sender;
            pnlSubMenu.Visible = false;

            foreach (Control ctrl in pnlComanda.Controls)
            {
                ((pnlArtVendido)ctrl).ToRegular();

                if (((pnlArtVendido)ctrl).Location.Y == articuloPadreLocacionY) 
                    _artVendidoSeleccionado = ((pnlArtVendido)ctrl);
            }
            BotonesMasMenosBorrar();

            _artVendidoSeleccionado.ToSelected(intercambiableLocacionY);
            if (intercambiableLocacionY > 0)
                _opcionLocationY = intercambiableLocacionY;
            else
                _opcionLocationY = 0;

            if (_opcionLocationY > 0)
            {
                pnlSubMenu.Controls.Clear(); // TODO: esto debe de ser el panel del submenu.
                List<Articulo> arts;
                if (artVdo.ComboTipo.ToLower().StartsWith("custom")) // Si es un Custom
                {
                    arts = artVdo.Opciones.Select(ar => ar.ArticuloOp).ToList();
                }
                else // Si es un Intercambiable
                {
                    if (artOp == null)
                        return;

                    arts = artOp.Opciones.Select(ar => ar.Articulo).ToList();
                }

                // var arts = _datos.PantallaVentas.Especiales;
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


                    pnlSubMenu.Controls.Add(btn);

                }
                pnlSubMenu.Visible = true;
            }
            
        }

        private void ArticuloMasMenosChange()
        {
            CalcularTotal();
            BotonesMasMenosBorrar();
        }
        private void ArticuloYsChange(int y, int altura, bool mas)
        {
            // TODO: Reorganizar los articulos de acuerdo a las nuevas Ys
            foreach (Control ctrl in pnlComanda.Controls)
            {
                if (ctrl.Location.Y > y)
                {
                    if (mas)
                        ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y + altura);
                    else
                        ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y - altura);
                }
            }
        }
        private void CalcularTotal()
        {
            pnlArtVendido art;
            decimal taza = _datos.Login.Taza + 1;

            decimal total = 0;
            int cantArts = 0;

            foreach (Control ctrl in pnlComanda.Controls)
            {
                art = (pnlArtVendido)ctrl;
                total += art.PrecioArticuloTotal();
                cantArts += art.CantidadArticulosTotal();
            }

            comanda.Total = total;
            comanda.SubTotal = comanda.Total / taza;
            comanda.Impuesto = comanda.Total - comanda.SubTotal;

            lblNumArts.Text = cantArts.ToString();
            lblSubTotal.Text = string.Format(_format, comanda.SubTotal);
            lblImpu.Text = string.Format(_format, comanda.Impuesto);
            lblTotal.Text = string.Format(_format, comanda.Total);

            Console.WriteLine("NumArt " + lblNumArts.Text);
            Console.WriteLine("SubTotal " + lblSubTotal.Text);
            Console.WriteLine("Impuesto " + lblImpu.Text);
            Console.WriteLine("Total " + lblTotal.Text);
            Console.WriteLine("- - - - - ");


        }

        private void BotonesMasMenosBorrar()
        {
            if (_artVendidoSeleccionado == null)
            {
                cmdMas.Visible = false;
                cmdMenos.Visible = false;
                cmdBorrar.Visible = false;
                return;
            }
            cmdMas.Visible = true;
            cmdBorrar.Visible = true;

            if (_artVendidoSeleccionado.Cantidad() > 1)
                cmdMenos.Visible = true;
            else
                cmdMenos.Visible = false;
        }

        private void cmdMas_Click(object sender, EventArgs e)
        {
            if (_artVendidoSeleccionado != null)
                _artVendidoSeleccionado.MasUno();
        }

        private void cmdMenos_Click(object sender, EventArgs e)
        {
            if (_artVendidoSeleccionado != null)
                _artVendidoSeleccionado.MenosUno();

        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            if (_artVendidoSeleccionado != null)
            {
                var altura = _artVendidoSeleccionado.Height;
                var locationY = _artVendidoSeleccionado.Location.Y;
                pnlComanda.Controls.Remove(_artVendidoSeleccionado);
                _artVendidoSeleccionado = null;

                ArticuloYsChange(locationY, altura, false);
                CalcularTotal();
                BotonesMasMenosBorrar();
            }
        }
    }
}
