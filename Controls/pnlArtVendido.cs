using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackBox.Enum;
using BlackBox.Model;

namespace BlackBox.Controls
{
    public partial class pnlArtVendido : UserControl
    {
        public delegate void onArticuloSelected(object sender, int articuloPadreLocacionY, int intercambiableLocacionY, Articulo artOp);
        public event onArticuloSelected OpcionClicked;

        public delegate void onArticuloMasMenos();
        public event onArticuloMasMenos ArticuloMasMenosChange;

        public delegate void onArticuloCambioYs(int y, int altura, bool mas);
        public event onArticuloCambioYs ArticuloYsChange;

        private decimal _precioAdicional = 0;
        private int _cantidad = 1;
        
        private int _renglonAlturaNormal = 27;
        private int _renglonAlturaCustom = 14;
        private int _opcionAlturaInicial = 27;
        private int _marginBottonCustom = 5;

        private Font fontCustom;
        private Color _verdeFuerte = Color.FromArgb(0, 128, 0);
        private Color _verdeClaro = Color.FromArgb(127, 191, 127);

        public Articulo _articulo;
        // private bool _intercambiables;
        private List<int> _sinAsignar;
        /// <summary>
        /// Localizacion Y del Intercambiable dentro del Articulo Padre
        /// </summary>
        public List<int> _intercambiablesY;
        /// <summary>
        /// Nombre de las Opciones soportadas por los Intercambiables.
        /// </summary>
        public List<string> _intercambiablesNombres;


        public pnlArtVendido()
        {
            InitializeComponent();
        }
        public pnlArtVendido(Articulo articulo) // string nombre, double precio, List<Articulo> articulos = null, ComboTipo tipo = ComboTipo.Normal)
        {
            InitializeComponent();
            /* 
             * Comportamiento de ComboTipo: 
             *		Normal: Se manejan el nombre y precio de forma normal, sin mas detalle. ArticuloCantidad: 1
             *		Combo:	Se manejan con un titulo y X cantidad de articulos fijos, pueden ser Intercambiables o No. ArticuloCantidad: Por definir.
             *		Custom:	Se manejan con un titulo y X cantidad de articulos variables, no hay intercambiables, los articulos (Ingredientes) tendran costo extra.. ArticuloCantidad: 1
             *		CustomEsp:	Se majean con un titulo y X cantidad de articulos variables, no hay intercambiables, los articulos (espesificaciones) no tiene costo extra.. ArticuloCantidad: 1
             *		
             * Caracteristicas:
             *      Combo:  Letras en Bold, si son intercambiables se mostraran en Verde.
             *      Custom: Letras en Italicas y mas pequeñas. Mostraran ultimo renglon en el caso de tener mas articulos de los predefinidos. Abriran un Submenu con las opciones que se pueden agregar.
             *      CustomEsp:  Letras en Italicas y mas pequeñas. No tendran articulos por defecto. Abriran un Submenu con las opciones que se pueden agregar.
             * 
             * Intercambiables:
             *      Los articulos pertenecientes a un Combo pueden ser intercambiados por otra opcion.
             *      Los articulos puede o no tener un articulo predeterminado (Dips/Pizzas).
             *      Se identificaran con un color verde en Bold.
             *      Si no tiene una seleccion valida (un articulo predeterminado) se mostrara en Italica Bold pero en color mas claro.
             *      Cuando se de Click en un Articulo Intercambiable: Se abrira un menu con las opciones correspondientes.
             *      
             * Parametros:
             *      Tipo: Determina el tipo de comportamiento del Articulo Principal.
             *      Articulos:  Determina los articulos predeterminados para Combos y Customs, en caso de Combos es fijo, en caso de Especial son solo los defaul y los articulos son variables.
             *          Los nuevos articulos se ingresaran/Elminaran por medio de Metodos: AddArticulo, DeleteArticulo
             *          
             * Comportamiento Adicional por definir:
             *      El Add y Remove (Botones +,- ) 
             *      El articulo se debe poder seleccionar, y se debe marcar como selecionado (Color gris de fondo)
             *      Los SubArticulos se mostraran con una sangria, sin definir un precio al final y cargados a la Izq.
             *      En el caso de los Custom el renglo final que indica el precio total/PorArticulo se mostrara cargado a la Derecha.
            */

            string precioF = string.Empty;
            precioF = string.Format("{0:C}", articulo.Precio);  //precio);
            fontCustom = new Font(lblArticulo.Font.FontFamily, 10, FontStyle.Regular);

            // Valore Iniciales
            lblFondo.Location = new Point(0, 0);
            lblOpcion.Location = new Point(13, 27);
            lblCantidad.Location = new Point(185, -1);
            lblPrecio.Location = new Point(209, 0);
            lblCantidad.Font = new Font(lblArticulo.Font, FontStyle.Bold);

            _articulo = articulo;
            _intercambiablesY = new List<int>();
            _intercambiablesNombres = new List<string>();
            _sinAsignar = new List<int>();


            lblArticulo.Text = articulo.Producto; // nombre;
            lblPrecio.Text = precioF;
            
            /* Normal, Combo, Custom, CustomEst */
            articulo.ComboTipo = articulo.ComboTipo == null ? "normal" : articulo.ComboTipo;
            switch (articulo.ComboTipo.ToLower())
            {
                //case "normal":
                //    break;
                case "combo":
                    this.Size = new Size(309, _renglonAlturaNormal * (articulo.Opciones.Count + 1));
                    break;
                case "custom":
                    this.Size = new Size(309, _renglonAlturaNormal + (_renglonAlturaCustom * articulo.Opciones.Count(o => o.Default) + _marginBottonCustom));
                    break;
                case "customesp":
                    this.Size = new Size(309, _renglonAlturaNormal + (_renglonAlturaCustom * articulo.Opciones.Count(o => o.Default) + _marginBottonCustom));
                    break;
                default:  // Los Normales... si no esta definido es tratado como Normal
                    this.Size = new Size(309, _renglonAlturaNormal); // 27 Altura base Normal
                    break;
            }
            lblFondo.Size = this.Size;

            // Articulos Opciones con Combo
            if (articulo.ComboTipo.ToLower() == "combo")
            {
                for (var i = 1; i <= articulo.Opciones.Count; i++)
                {
                    var nCtrl = new Label()
                    {
                        Size = lblOpcion.Size, //picBox.Size,
                        Visible = true,
                        Text = articulo.Opciones[i - 1].ArticuloOp.Producto,
                        Font = new Font(lblArticulo.Font, FontStyle.Bold),
                        Name = articulo.Opciones[i - 1].ArticuloOp.Producto + "_" + i.ToString(),
                        //BackColor = SystemColors.ControlDark,
                        //AutoSize = true,
                        Location = new Point(0, _opcionAlturaInicial + (_renglonAlturaNormal * (i - 1))),
                        Padding = new Padding(13, 0, 0, 0)
                    };
                    
                    if (articulo.Opciones[i - 1].Intercambiable)
                    {
                        _intercambiablesY.Add(nCtrl.Location.Y);
                        _articulo.Opciones[i - 1].LocationY = nCtrl.Location.Y;
                        _intercambiablesNombres.AddRange(_articulo.Opciones[i - 1].ArticuloOp.Opciones.Select(o => o.Articulo.Producto).ToList());

                        if (articulo.Opciones[i - 1].Default)
                        {
                            nCtrl.ForeColor = _verdeFuerte;
                            nCtrl.CausesValidation = false;
                        } else
                        {
                            nCtrl.ForeColor = _verdeClaro;
                            nCtrl.Font = new Font(lblArticulo.Font, FontStyle.Bold | FontStyle.Italic );
                            nCtrl.CausesValidation = true;
                            _sinAsignar.Add(nCtrl.Location.Y);
                        }

                    }
                    nCtrl.Click += lblOpcion_Click;

                    this.Controls.Add(nCtrl);
                    this.Controls.SetChildIndex(nCtrl, 1);
                    nCtrl.BringToFront();
                }
            }

            // Articulos Opciones con Custom y CustomEsp
            if (articulo.ComboTipo.ToLower().StartsWith("custom"))
            {
                var ingre = articulo.Opciones.Where(o => o.Default).ToList();
                for (var z = 1; z <= ingre.Count; z++) // articulo.Opciones.Count; i++)
                {
                    var nCtrl = new Label()
                    {
                        Size = lblOpcion.Size, //picBox.Size,
                        Visible = true,
                        Text = articulo.Opciones[z - 1].ArticuloOp.Producto,
                        Font = fontCustom, // new Font(lblArticulo.Font, FontStyle.Bold),
                        Name = articulo.Opciones[z - 1].ArticuloOp.Producto + "_" + z.ToString(),
                        Location = new Point(0, _opcionAlturaInicial + (_renglonAlturaCustom * (z - 1))),
                        Padding = new Padding(13, 0, 0, 0)
                    };

                    nCtrl.Click += lblOpcion_Click;

                    this.Controls.Add(nCtrl);
                    this.Controls.SetChildIndex(nCtrl, 1);
                    nCtrl.BringToFront();
                }
            }

            //pnlArtVendido.DefaultBackColor = SystemColors.ControlDark;
            /*
            lblPrecio.Font = new Font(lblPrecio.Font, FontStyle.Bold);
            lblArticulo.Font = new Font(lblArticulo.Font, FontStyle.Bold);
            lblFondo.BackColor = SystemColors.ControlDark;
            lblArticulo.BackColor = SystemColors.ControlDark;
            lblPrecio.BackColor = SystemColors.ControlDark;
            */

            ToSelected();


        }

        public void ToRegular()
        {
            Color foreColor = SystemColors.GrayText;

            lblFondo.BackColor = Color.White;
            lblArticulo.BackColor = Color.White;
            lblPrecio.BackColor = Color.White;
            lblCantidad.BackColor = Color.White;

            if (_articulo.ComboTipo.ToLower() == "combo")
            {
                foreColor = SystemColors.ControlText;
            }

            lblArticulo.ForeColor = foreColor;
            lblPrecio.ForeColor = foreColor;
            lblCantidad.ForeColor = foreColor;

            if (_articulo.ComboTipo.ToLower() != "combo")
            {
                lblArticulo.Font = new Font(lblArticulo.Font, FontStyle.Regular);
                lblPrecio.Font = new Font(lblPrecio.Font, FontStyle.Regular);
                lblCantidad.Font = new Font(lblPrecio.Font, FontStyle.Regular);
            }

            foreach (Control child in this.Controls)
            {
                if (child.BackColor == _verdeClaro)
                    child.ForeColor =  child.CausesValidation ? _verdeClaro : _verdeFuerte;
                child.BackColor = Color.White;
            }
                
        }

        public void ToSelected(int i = -1)
        {
            Color backColor;
            if (_intercambiablesY.Count > 0)
                backColor = Color.White;
            else
                backColor = SystemColors.ControlDark;

            lblPrecio.Font = new Font(lblPrecio.Font, FontStyle.Bold);
            lblPrecio.ForeColor = SystemColors.ControlText;
            lblCantidad.Font = new Font(lblPrecio.Font, FontStyle.Bold);
            lblCantidad.ForeColor = SystemColors.ControlText;
            lblArticulo.Font = new Font(lblArticulo.Font, FontStyle.Bold);
            lblArticulo.ForeColor = SystemColors.ControlText;

            // Investigar si es necesario validar el "ComboTipo"

            foreach (Control child in this.Controls)
            {
                child.BackColor = backColor;
                if (i >= 0 && child.Location.Y == i)
                {
                    var op = _articulo.Opciones.Where(o => o.LocationY == i && o.Intercambiable).FirstOrDefault();
                    if (op == null)
                        child.BackColor = SystemColors.ControlDark;
                    else
                    {
                        child.BackColor = _verdeClaro;
                        child.ForeColor = Color.White;
                    }
                        
                }
                    
            }
                

        }       
        
        public bool OpcionesSinAsignar()
        {
            return _sinAsignar.Count > 0 ? true : false;
        }
        public void MasUno()
        {
            _cantidad++;
            lblCantidad.Text = string.Format("({0})", _cantidad);
            lblCantidad.Visible = true;
            lblPrecio.Text = string.Format("{0:C}", _cantidad * _articulo.Precio);

            ArticuloMasMenosChange();
        }
        public void MenosUno()
        {
            if (_cantidad == 1)
                return;

            _cantidad--;
            if(_cantidad == 1)
                lblCantidad.Visible = false;

            lblCantidad.Text = string.Format("({0})", _cantidad);
            lblPrecio.Text = string.Format("{0:C}", _cantidad * _articulo.Precio);

            ArticuloMasMenosChange();
        }
        public int CantidadArticulosTotal()
        {
            return _cantidad * (_articulo.Cantidad == 0 ? 1 : _articulo.Cantidad);
        }
        public decimal PrecioArticuloTotal()
        {
            return _cantidad * (_articulo.Precio + _precioAdicional);
            
        }
        public void ArticuloOpcion(Articulo articuloOp, int locacionY, bool mas)
        {
            if (!((_articulo.ComboTipo.ToLower() == "combo" && _intercambiablesY.Count > 0)
                || (_articulo.ComboTipo.ToLower().StartsWith("custom")))) // == "custom" || _articulo.ComboTipo.ToLower() == "customesp")))
                return;

            if (_articulo.ComboTipo.ToLower().StartsWith("custom")) // Significa que se trata de un Custom / CustomEsp
            {
                var ingrediente = _articulo.Opciones.Where(i => i.ArticuloOp.Producto == articuloOp.Producto).FirstOrDefault();
                if (mas)
                {
                    
                    var nCtrl = new Label()
                    {
                        Size = lblOpcion.Size, //picBox.Size,
                        Visible = true,
                        Text = articuloOp.Producto,
                        Font = fontCustom, // new Font(lblArticulo.Font.FontFamily, 12 , FontStyle.Regular),
                        Location = new Point(0, _opcionAlturaInicial + (_renglonAlturaCustom * (_articulo.Opciones.Count(o => o.Default)))),
                        BackColor = SystemColors.ControlDark,
                        Padding = new Padding(13, 0, 0, 0)
                    };
                    _articulo.Opciones.Find(o => o.ArticuloOp.Producto == articuloOp.Producto).Default = true;
                    this.Size = new Size(309, _renglonAlturaNormal + (_renglonAlturaCustom * _articulo.Opciones.Count(o => o.Default) + _marginBottonCustom));
                    nCtrl.Click += lblOpcion_Click;

                    this.Controls.Add(nCtrl);
                    this.Controls.SetChildIndex(nCtrl, 1);
                    nCtrl.BringToFront();

                    _precioAdicional += ingrediente.Costo;
                    ArticuloYsChange(this.Location.Y, _renglonAlturaCustom, true);
                }
                else
                {
                    _precioAdicional -= ingrediente.Costo;
                    _articulo.Opciones.Find(o => o.ArticuloOp.Producto == articuloOp.Producto).Default = false;
                    foreach (Control child in this.Controls)
                    {
                        if (((Label)child).Text == articuloOp.Producto)
                        {
                            var locY = child.Location.Y;
                            this.Controls.Remove(child);
                            foreach (Control childOp in this.Controls)
                            {
                                if (childOp.Location.Y > locY)
                                    childOp.Location = new Point(childOp.Location.X, childOp.Location.Y - locY);
                            }

                            this.Size = new Size(309, _renglonAlturaNormal + (_renglonAlturaCustom * _articulo.Opciones.Count(o => o.Default) + _marginBottonCustom));
                            ArticuloYsChange(this.Location.Y, _renglonAlturaCustom, false);
                            break;
                        }

                    }
                }
                return;
            }

            foreach (ArticuloOpcion artOp in _articulo.Opciones) // for (var i = 1; i <= artOps.Count; i++)
            {
                // Opcion Padre 
                if (artOp.LocationY == locacionY) // if (artOps[i - 1].LocationY == locacionY) // && artOps[i - 1].Intercambiable) Verificar si realmente es necesario validar el intercambiable.
                {
                        artOp.ArticuloOp.Producto = articuloOp.Producto; //artOps[i - 1].ArticuloOp.Producto = articuloOp.Producto;
                        foreach (Control child in this.Controls)
                        {
                            if (child.Location.Y == locacionY)
                            {
                                ((Label)child).Text = articuloOp.Producto;
                                ((Label)child).Font = new Font(lblArticulo.Font, FontStyle.Bold);
                                ((Label)child).CausesValidation = false;
                                break;
                            }
                        }

                        _sinAsignar.Remove(locacionY);
                    break;
                }
            }
            /*
            foreach(ArticuloOpcion artOp in _articulo.Opciones) // for (var i = 1; i <= artOps.Count; i++)
            {
                // Opcion Padre 
                if (artOp.LocationY == locacionY) // if (artOps[i - 1].LocationY == locacionY) // && artOps[i - 1].Intercambiable) Verificar si realmente es necesario validar el intercambiable.
                {
                    if (_articulo.ComboTipo.ToLower() != "combo") // Significa que se trata de un Custom / CustomEsp
                    {
                        var ingrediente = artOp.Opciones.Where(i => i.Articulo.Producto == articuloOp.Producto).FirstOrDefault();
                        if (mas)
                        {
                            var nCtrl = new Label()
                            {
                                Size = lblOpcion.Size, //picBox.Size,
                                Visible = true,
                                Text = articuloOp.Producto,
                                Font = fontCuspom, // new Font(lblArticulo.Font.FontFamily, 12 , FontStyle.Regular),
                                Location = new Point(0, _opcionAlturaInicial + (_renglonAlturaCustom * (this.Controls.Count - 3))),
                                Padding = new Padding(13, 0, 0, 0)
                            };
                            _articulo.Opciones.Find(o => o.ArticuloOp.Producto == articuloOp.Producto).Default = true;
                            this.Size = new Size(309, _renglonAlturaNormal + (_renglonAlturaCustom * _articulo.Opciones.Count(o => o.Default)));
                            nCtrl.Click += lblOpcion_Click;

                            this.Controls.Add(nCtrl);
                            this.Controls.SetChildIndex(nCtrl, 1);
                            nCtrl.BringToFront();

                            _precioAdicional += ingrediente.Costo;
                            ArticuloYsChange(this.Location.Y, _renglonAlturaCustom, true);
                        }
                        else
                        {
                            _precioAdicional -= ingrediente.Costo;
                            _articulo.Opciones.Find(o => o.ArticuloOp.Producto == articuloOp.Producto).Default = false;
                            foreach (Control child in this.Controls)
                            {
                                if (((Label)child).Text == articuloOp.Producto)
                                {
                                    this.Controls.Remove(child);
                                    this.Size = new Size(309, _renglonAlturaNormal + (_renglonAlturaCustom * _articulo.Opciones.Count(o => o.Default)));
                                    ArticuloYsChange(this.Location.Y, _renglonAlturaCustom, false);
                                    break;
                                }

                            }
                        }
                            
                    }
                    else
                    {
                        artOp.ArticuloOp.Producto = articuloOp.Producto; //artOps[i - 1].ArticuloOp.Producto = articuloOp.Producto;
                        foreach (Control child in this.Controls)
                        {                             
                            if (child.Location.Y == locacionY)
                            {
                                ((Label)child).Text = articuloOp.Producto;
                                ((Label)child).Font = new Font(lblArticulo.Font, FontStyle.Bold);
                                ((Label)child).CausesValidation = false;
                                break;
                            }
                        }

                        _sinAsignar.Remove(locacionY);                        
                    }
                    break;
                }
            }
            */

        }
        private void onClick(object sender)
        {
            // ToSelected();  Esto se hace desde fuera, ya que primero se pasan todos a Regular.
            if (_articulo.ComboTipo.ToLower().StartsWith("custom"))
                OpcionClicked(_articulo, ((Label)sender).Parent.Location.Y, ((Label)sender).Location.Y, null);
            else
                OpcionClicked(_articulo, ((Label)sender).Parent.Location.Y, -1, null);
        }
        private void pnlArtVendido_Click(object sender, EventArgs e)
        {            
            onClick(sender);
        }

        private void lblOpcion_Click(object sender, EventArgs e)
        {
            // ToSelected();
            // TODO: Cambiar por el subMenu a desplegar si se trata de un intercambiable o un "Custom"
            var optInter = _articulo.Opciones.Where(op => 
                ((op.Intercambiable && op.LocationY == ((Label)sender).Location.Y)
                    // || (op.ArticuloOp.ComboTipo != null && op.ArticuloOp.ComboTipo.ToLower() == "customesp"))
                )).FirstOrDefault();

            if (optInter != null)
                OpcionClicked(_articulo, ((Label)sender).Parent.Location.Y, ((Label)sender).Location.Y, optInter.ArticuloOp);
            else
                OpcionClicked(_articulo, ((Label)sender).Parent.Location.Y, ((Label)sender).Location.Y, null);
        }

        private void lblArticulo_Click(object sender, EventArgs e)
        {
            onClick(sender);
        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {
            onClick(sender);
        }

        private void lblFondo_Click(object sender, EventArgs e)
        {
            onClick(sender);
        }
    }
}
