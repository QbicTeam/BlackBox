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
        
        private string _format = "{0:$#######.00}";
        
        private int _cantidadXprecio4Sel = 5;
        private int _canidadX1Sel = 175;
        private int _canidadX2Sel = 9;

        private int _cantidadXprecio4Reg = 11;
        private int _canidadX1Reg = 195;
        private int _canidadX2Reg = 11;
        
        private decimal _precioAdicional = 0;
        private int _cantidad = 1;
        
        private int _renglonAlturaNormal = 27;
        private int _renglonAlturaCustom = 14;
        private int _opcionAlturaInicial = 27;
        private int _marginBottonCustom = 5;
        private int _OpcionPaddin = 13;
        private int _SubOpcionPaddin = 40;

        private Font fontCustom;
        private Color _verdeFuerte = Color.FromArgb(0, 128, 0);
        private Color _verdeClaro = Color.FromArgb(127, 191, 127);
        private Color _rojo = Color.FromArgb(255, 0, 0);

        public int _opAutoSelectLocationY = -1;

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
            precioF = string.Format(_format, articulo.Precio);  //precio); "{0:C}"
            fontCustom = new Font(lblArticulo.Font.FontFamily, 10, FontStyle.Regular);

            // Valore Iniciales
            lblFondo.Location = new Point(0, 0);
            lblOpcion.Location = new Point(13, 27);
            lblCantidad.Location = new Point(_canidadX1Sel, -1);
            lblPrecio.Location = new Point(206, 0);
            lblCantidad.Font = new Font(lblArticulo.Font, FontStyle.Bold);

            articulo.ComboTipo = articulo.ComboTipo == null ? "normal" : articulo.ComboTipo;
            _articulo = articulo;
            _intercambiablesY = new List<int>();
            _intercambiablesNombres = new List<string>();
            _sinAsignar = new List<int>();

            // var _opAutoSelectLocationY = -1;
            int opAutoSelect = 0; // 0: Sin Seleccion; 1: CustomEsp sin Validar; 2: Intercambiable sin Default; 3: CustomEsp Con Validar

            lblArticulo.Text = articulo.Producto; // nombre;
            lblPrecio.Text = precioF;
            
            /* Normal, Combo, Custom, CustomEst */
            //articulo.ComboTipo = articulo.ComboTipo == null ? "normal" : articulo.ComboTipo;
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
            if (articulo.ComboTipo.ToLower() != "combo")
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
                        //Name = articulo.Opciones[i - 1].ArticuloOp.Producto + "_" + i.ToString(),
                        //BackColor = SystemColors.ControlDark,
                        //AutoSize = true,
                        Location = new Point(0, _opcionAlturaInicial + (_renglonAlturaNormal * (i - 1))),
                        Padding = new Padding(_OpcionPaddin, 0, 0, 0)
                    };
                    nCtrl.Name = nCtrl.Location.Y.ToString() + "_" + articulo.Opciones[i - 1].ArticuloOp.Producto;
                    if (articulo.Opciones[i - 1].Intercambiable)
                    {
                        _intercambiablesY.Add(nCtrl.Location.Y);
                        _articulo.Opciones[i - 1].LocationY = nCtrl.Location.Y;
                        _intercambiablesNombres.AddRange(_articulo.Opciones[i - 1].ArticuloOp.Opciones.Select(o => o.Articulo.Producto).ToList());

                        if (articulo.Opciones[i - 1].ArticuloOp.ComboTipo != null 
                            && articulo.Opciones[i - 1].ArticuloOp.ComboTipo.ToLower() == "customesp")
                        {
                            if(articulo.Opciones[i - 1].ArticuloOp.Validar)
                            {
                                nCtrl.ForeColor = _rojo;
                                nCtrl.CausesValidation = true;
                                _sinAsignar.Add(nCtrl.Location.Y);
                                _opAutoSelectLocationY = nCtrl.Location.Y;
                                opAutoSelect = 3; // 0: Sin Seleccion; 1: CustomEsp sin Validar; 2: Intercambiable sin Default; 3: CustomEsp Con Validar
                            }
                            else 
                            {
                                if (opAutoSelect < 1)
                                {
                                    opAutoSelect = 1;
                                    _opAutoSelectLocationY = nCtrl.Location.Y;
                                }
                                    
                            }
                        }
                        else
                        {
                            if (articulo.Opciones[i - 1].Default)
                            {
                                nCtrl.ForeColor = _verdeFuerte;
                                nCtrl.CausesValidation = false;
                            }
                            else
                            {
                                nCtrl.ForeColor = _verdeClaro;
                                nCtrl.Font = new Font(lblArticulo.Font, FontStyle.Bold | FontStyle.Italic);
                                nCtrl.CausesValidation = true;
                                _sinAsignar.Add(nCtrl.Location.Y);
                                if (opAutoSelect < 2)
                                {
                                    opAutoSelect = 2; // 0: Sin Seleccion; 1: CustomEsp sin Validar; 2: Intercambiable sin Default; 3: CustomEsp Con Validar
                                    _opAutoSelectLocationY = nCtrl.Location.Y;
                                }
                                    
                            }
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
                        Size = lblOpcion.Size, 
                        Visible = true,
                        Text = articulo.Opciones[z - 1].ArticuloOp.Producto,
                        Font = fontCustom, 
                        Location = new Point(0, _opcionAlturaInicial + (_renglonAlturaCustom * (z - 1))),
                        Padding = new Padding(_OpcionPaddin, 0, 0, 0)
                    };
                    nCtrl.Name = nCtrl.Location.Y.ToString() + "_" + articulo.Opciones[z - 1].ArticuloOp.Producto;

                    nCtrl.Click += lblOpcion_Click;

                    this.Controls.Add(nCtrl);
                    this.Controls.SetChildIndex(nCtrl, 1);
                    nCtrl.BringToFront();
                }
            }

            //ToSelected();

        }
        /// <summary>
        /// Da la apariencia regular (no seleccionado) al articulo venta y su detalle.
        /// </summary>
        public void ToRegular()
        {
            Color foreColor = SystemColors.GrayText;
            Control ForeInWhite = null;

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
                if (child.ForeColor == Color.White)
                    ForeInWhite = child;

                if (child.BackColor == _verdeClaro)
                    child.ForeColor =  child.CausesValidation ? _verdeClaro : _verdeFuerte;
                child.BackColor = Color.White;
            }

            ForecolorInWhite(ForeInWhite);
            CandidadLocationX();
        }
        /// <summary>                                                                                                                             
        /// Da la apariciencia de "Seleccionado" al articulo venta o su detalle.
        /// </summary>
        /// <param name="locationY">Posicion Y de la opcion</param>
        public void ToSelected(int locationY = -1, bool init = false)
        {
            /* Normal, Combo, Custom, CustomEst */
            Color backColor;
            Control ForeInWhite = null;

            Console.WriteLine("LocationY: " + locationY.ToString() );


            backColor = Color.White;

            // Encabezado Articulo Venta
            if (_articulo.ComboTipo.ToLower() != "combo")
                backColor = SystemColors.ControlDark;

            lblPrecio.Font = new Font(lblPrecio.Font, FontStyle.Bold);
            lblPrecio.ForeColor = SystemColors.ControlText;
            lblCantidad.Font = new Font(lblPrecio.Font, FontStyle.Bold);
            lblCantidad.ForeColor = SystemColors.ControlText;
            lblArticulo.Font = new Font(lblArticulo.Font, FontStyle.Bold);
            lblArticulo.ForeColor = SystemColors.ControlText;

            // Investigar si es necesario validar el "ComboTipo"
            Console.WriteLine("--- Controles I ---");
            foreach (Control child in this.Controls)
            {
                Console.WriteLine("Nombre: " + child.Name + ", Texto: " + ((Label)child).Text);
                if (child.ForeColor == Color.White)
                    ForeInWhite = child;

                //if (_articulo.ComboTipo.ToLower() == "combo" &&  i < 0 && child.Location.Y < _opcionAlturaInicial)
                if (_articulo.ComboTipo.ToLower() == "combo" // && child.Name.StartsWith(locationY.ToString()) )
                    && (child.Name.StartsWith(locationY.ToString()) 
                        || (locationY < _opcionAlturaInicial && child.Location.Y < _opcionAlturaInicial )
                        )
                    ) 
                    child.BackColor = SystemColors.ControlDark;
                else
                    child.BackColor = backColor;
                

                if (locationY >= 0 && child.Location.Y == locationY)
                {

                    var op = _articulo.Opciones.Where(o => o.LocationY == locationY).FirstOrDefault();
                    if (op == null)
                    {
                        child.BackColor = SystemColors.ControlDark;
                        if (_articulo.ComboTipo.ToLower() == "customesp" && _articulo.Validar)
                        {
                            child.BackColor = _rojo;
                            child.ForeColor = Color.White;
                        }
                    }
                    else
                    {
                        if (op.Intercambiable)
                        {
                            if (op.ArticuloOp.ComboTipo != null 
                                && op.ArticuloOp.ComboTipo.ToLower() == "customesp" 
                                && op.ArticuloOp.Validar)
                            {
                                if (op.ArticuloOp.Opciones.Count > 0 
                                    && op.ArticuloOp.Opciones.Where(o => o.Default).ToList().Count() == 0)
                                {
                                    child.BackColor = _rojo;
                                    child.ForeColor = Color.White;
                                }   
                            }
                            else
                            {
                                if (!_articulo.ComboTipo.ToLower().StartsWith("custom"))
                                {
                                    child.BackColor = _verdeClaro;
                                    child.ForeColor = Color.White;
                                }
                            }
                            
                        }
                        
                    }
                }
                    
            }
            Console.WriteLine("--- Controles F ---");

            ForecolorInWhite(ForeInWhite);
            if (init)
            {
                ArticuloOpcion optInter = null;
                if (_articulo.Opciones != null)
                    optInter = _articulo.Opciones.Where(op =>
                        (op.LocationY == locationY && op.ArticuloOp.Opciones.Count > 0
                        )).FirstOrDefault();

                if (optInter != null)
                    OpcionClicked(_articulo, this.Location.Y, locationY, optInter.ArticuloOp);
            }

            CandidadLocationX();
        }       
        private void ForecolorInWhite (Control ForeInWhite)
        {
            if (ForeInWhite != null)
            {
                ForeInWhite.BackColor = Color.White;
                var op = _articulo.Opciones.Where(o => o.LocationY == ForeInWhite.Location.Y).FirstOrDefault();
                if (op.ArticuloOp.ComboTipo != null
                    && op.ArticuloOp.ComboTipo.ToLower() == "customesp"
                    && op.ArticuloOp.Validar)
                {
                    if (op.ArticuloOp.Opciones.Count > 0
                        && op.ArticuloOp.Opciones.Where(o => o.Default).ToList().Count() == 0)
                    {
                        ForeInWhite.ForeColor = _rojo;                        
                    }
                    else
                        ForeInWhite.ForeColor = SystemColors.ControlText;

                }
            }
        }
        /// <summary>
        /// Indica si hay Alguna opcion que necesite ser asignada. Util para saber si se puede cerrar la venta o no.
        /// </summary>
        /// <returns></returns>
        public bool OpcionesSinAsignar()
        {
            return _sinAsignar.Count > 0 ? true : false;
        }
        /// <summary>
        /// Aumenta en uno el Articulo Venta.
        /// </summary>
        public void MasUno()
        {
            _cantidad++;
            var precio = _cantidad * _articulo.Precio;
            
            lblCantidad.Text = string.Format("({0})", _cantidad);
            lblCantidad.Visible = true;
            lblPrecio.Text = string.Format(_format, precio); //"{0:C}"

            CandidadLocationX();

            ArticuloMasMenosChange();
        }
        /// <summary>
        /// Disminulle en uno el Articulo Venta.
        /// </summary>
        public void MenosUno()
        {
            if (_cantidad == 1)
                return;
            
            _cantidad--;
            var precio = _cantidad * _articulo.Precio;

            if (_cantidad == 1)
                lblCantidad.Visible = false;

            lblCantidad.Text = string.Format("({0})", _cantidad);
            lblPrecio.Text = string.Format(_format, precio);

            CandidadLocationX();
            ArticuloMasMenosChange();
        }

        private void CandidadLocationX()
        {
            var precio = _cantidad * _articulo.Precio;

            int cX;
            if (lblCantidad.Font.Bold)
            {
                cX = _canidadX1Sel;
                if (precio >= 1000)
                    cX -= _cantidadXprecio4Sel;
                if (_cantidad >= 10)
                    cX -= _canidadX2Sel;                
            }
            else
            {
                cX = _canidadX1Reg;
                if (precio >= 1000)
                    cX -= _cantidadXprecio4Reg;
                if (_cantidad >= 10)
                    cX -= _canidadX2Reg;
            }
            lblCantidad.Location = new Point(cX, -1);
        }
        /// <summary>
        /// Numero total de Articulos de acuerdo al Articulo venta (puede variar en los Combos, los custom cuentan como uno)
        /// </summary>
        /// <returns></returns>
        public int CantidadArticulosTotal()
        {
            return _cantidad * (_articulo.Cantidad == 0 ? 1 : _articulo.Cantidad);
        }
        /// <summary>
        /// Precio total del articulo: Cantidad * Precio Base + Adicionales si existen
        /// </summary>
        /// <returns></returns>
        public decimal PrecioArticuloTotal()
        {
            return _cantidad * (_articulo.Precio + _precioAdicional);
            
        }
        /// <summary>
        /// Agrega/Quita Articulos En Custom o Intercambiables.
        /// </summary>
        /// <param name="articuloOp">Opcion a Agregar/Quitar o intercambiar</param>
        /// <param name="locacionY">Posicion del articulo/Para los de tipo CustomEsp sera la LocacionY padre.</param>
        /// <param name="mas">Indica si se agrega/intercambio o quita.</param>        
        /// <param name="mediaRacion">Indica si solo se esta agregando Media Racion y se manda 1 u 2, si es Cero = Racion completa</param>        
        public void ArticuloOpcion(Articulo articuloOp, int locacionY, bool mas, int mediaRacion = 0)
        {
            if (!((_articulo.ComboTipo.ToLower() == "combo" && _intercambiablesY.Count > 0)
                || (_articulo.ComboTipo.ToLower().StartsWith("custom")))) 
                return;

            int locacionYsoN = 0; // Locacion Y de la nueva opcion si se esta agregando.

            if (_articulo.ComboTipo.ToLower().StartsWith("custom")) // Significa que se trata de un Custom / CustomEsp
            {
                var ingrediente = _articulo.Opciones.Where(i => i.ArticuloOp.Producto == articuloOp.Producto).FirstOrDefault();
                if (mas)
                {
                    ingrediente.MediaRacion = mediaRacion;

                    if (!ingrediente.Default)
                    {
                        // _articulo.Opciones.Find(o => o.ArticuloOp.Producto == articuloOp.Producto).Default = true;
                        ingrediente.Default = true;                        

                        // _precioAdicional += ingrediente.Costo;
                        locacionYsoN = _opcionAlturaInicial + (_renglonAlturaCustom * (_articulo.Opciones.Count(o => o.Default) - 1)); //locacionY + _renglonAlturaNormal - _marginBottonCustom + (_renglonAlturaCustom * (artOp.ArticuloOp.Opciones.Count(o => o.Default) - 1)); // locacionY + _renglonAlturaNormal + (_renglonAlturaCustom * (artOp.ArticuloOp.Opciones.Count(o => o.Default) - 1));                                                   
                        AddSubOpcionCtrl(articuloOp, locacionY, locacionYsoN, _OpcionPaddin, false, mediaRacion);
                        ingrediente.LocationY = locacionY; // Locacion del padre.
                        ArticuloYsChangeInterno(locacionYsoN, _renglonAlturaCustom, true);
                    }
                    else
                    {
                        foreach (Control child in this.Controls)
                        {
                            if (((Label)child).Text.StartsWith(articuloOp.Producto))
                            {
                                var locY = child.Location.Y;
                                ((Label)child).Text = articuloOp.Producto + (mediaRacion != 0 ? mediaRacion.ToString() : string.Empty);
                                break;
                            }

                        }
                    }
                }
                else
                {
                    // _precioAdicional -= ingrediente.Costo;
                    _articulo.Opciones.Find(o => o.ArticuloOp.Producto == articuloOp.Producto).Default = false;
                    foreach (Control child in this.Controls)
                    {
                        if (((Label)child).Text.StartsWith(articuloOp.Producto))
                        {
                            var locY = child.Location.Y;
                            this.Controls.Remove(child);
                            ArticuloYsChangeInterno(locY, _renglonAlturaCustom, false);
                            this.Size = new Size(309, this.Size.Height - _renglonAlturaCustom);
                            ArticuloYsChange(this.Location.Y, _renglonAlturaCustom, false);
                            break;
                        }

                    }
                }
                // Calcular el nuevo costo Adicional de acuerdo la aconfiguracion del Especial (Cantidad de Ingredientes Incluidos, Cantidad de Mitades)
                if (_articulo.CostoIngredienteAdicional > 0)
                {
                    // _precioAdicional += ingrediente.Costo;                    
                    CalculaCostoAdicional();                    
                }

                return;
            }

            // Si se trata de una SubOpcion de otra Opcion... Ejemplo Refresco en un Combo.

            // locacionY para las subOpciones tipo CustomEsp sera el LocationY del padre.
            int locacionYsOp = 0;
            
            Control csOp = null; // Control SubOpcion 
            Control cOp = null; // Control Opcion
            var artOp = _articulo.Opciones.Where(op => op.LocationY == locacionY).FirstOrDefault();
            if(artOp != null)
            {
                // Si se trata de una Opcion CustomEsp 
                if (artOp.ArticuloOp.ComboTipo != null && artOp.ArticuloOp.ComboTipo.ToLower() == "customesp")
                {
                    if (artOp.ArticuloOp.Validar) // Si solo tiene un Hijo y require validacion
                    {
                        // Preguntar si existe alguno seleccionado antes
                        if (mas)
                        {
                            _sinAsignar.Remove(locacionY);
                            var sOpO = artOp.ArticuloOp.Opciones.Where(o2 => o2.Default).FirstOrDefault(); // SubOpcion Seleccionada anteriormente
                            if (sOpO != null)
                                sOpO.Default = false;

                            var sOpAc = artOp.ArticuloOp.Opciones.Where(o3 => o3.Articulo.Producto.ToLower() == articuloOp.Producto.ToLower()).FirstOrDefault(); // SubOpcion Actual
                            if (sOpAc != null)
                            {
                                sOpAc.Default = true;
                                // Agregar el nuevo articulo o sobre escribir el anterior.

                                foreach (Control child in this.Controls)
                                {
                                    if (child.Name.StartsWith(locacionY.ToString()))
                                    {
                                        if (child.Location.Y > locacionY)
                                        {
                                            csOp = child;
                                            locacionYsOp = child.Location.Y;
                                        }

                                        if (child.Location.Y == locacionY)
                                            cOp = child;
                                    }
                                }

                                if(locacionYsOp == 0) // Si no se ha puesto ninguna subOpcion, hay que agregarla.
                                {
                                    locacionYsoN = locacionY + _renglonAlturaNormal - _marginBottonCustom + (_renglonAlturaCustom * (artOp.ArticuloOp.Opciones.Count(o => o.Default) - 1)); // locacionY + _renglonAlturaNormal + (_renglonAlturaCustom * (artOp.ArticuloOp.Opciones.Count(o => o.Default) - 1));                                                   
                                    AddSubOpcionCtrl(articuloOp, locacionY, locacionYsoN, _SubOpcionPaddin);
                                    
                                    sOpAc.LocationY = locacionY; // Locacion del padre.
                                    ArticuloYsChangeInterno(locacionYsoN, _renglonAlturaCustom, true);

                                    cOp.BackColor = SystemColors.ControlDark;
                                    cOp.ForeColor = SystemColors.ControlText;
                                }
                                else // Si ya existia uno anterior, se sobre escribe.
                                {
                                    ((Label)csOp).Text = articuloOp.Producto;
                                }
                            }

                        }
                        else // Si se esta quitando.
                        {
                            _sinAsignar.Add(locacionY);
                            var sOpAc = artOp.ArticuloOp.Opciones.Where(o3 => o3.Articulo.Producto.ToLower() == articuloOp.Producto.ToLower()).FirstOrDefault(); // SubOpcion Actual
                            if (sOpAc != null)
                            {
                                sOpAc.Default = false;
                                // Localizar el subArticulo y eliminarlo
                                foreach (Control child in this.Controls)
                                {
                                    if (child.Name.StartsWith(locacionY.ToString()))
                                    {
                                        if (child.Location.Y > locacionY)
                                        {
                                            csOp = child;
                                            locacionYsOp = child.Location.Y;

                                            if (child.Location.Y == locacionY)
                                                cOp = child;
                                        }
                                    }
                                }

                                if (locacionYsOp != 0) // Si no se ha puesto ninguna subOpcion, hay que agregarla.
                                {
                                    this.Controls.Remove(csOp);
                                    ArticuloYsChangeInterno(locacionYsOp, _renglonAlturaCustom, false);
                                    ArticuloYsChange(this.Location.Y, _renglonAlturaCustom, false);

                                    cOp.BackColor = _rojo;
                                    cOp.ForeColor = Color.White;
                                }
                            }
                        }
                    }
                    else // Si puede tener varias opciones y no requiere validacion.
                    {                        
                        if (mas)
                        {
                            var sOpAc = artOp.ArticuloOp.Opciones.Where(o3 => o3.ArticuloOp.Producto.ToLower() == articuloOp.Producto.ToLower()).FirstOrDefault(); // SubOpcion Actual
                            if (sOpAc != null)
                            {
                                sOpAc.Default = true;
                                // Agregar el nuevo articulo
                                locacionYsoN = locacionY + _renglonAlturaNormal + (_renglonAlturaCustom * (artOp.ArticuloOp.Opciones.Count(o => o.Default) - 1));
                                AddSubOpcionCtrl(articuloOp, locacionY, locacionYsoN, _SubOpcionPaddin);

                                sOpAc.LocationY = locacionY; // Locacion del padre.
                                ArticuloYsChangeInterno(locacionYsoN, _renglonAlturaCustom, true);
                            }

                        }
                        else // Si se esta quitando.
                        {
                            //_sinAsignar.Add(locacionY);
                            var sOpAc = artOp.ArticuloOp.Opciones.Where(o3 => o3.ArticuloOp.Producto.ToLower() == articuloOp.Producto.ToLower()).FirstOrDefault(); // SubOpcion Actual
                            if (sOpAc != null)
                            {
                                sOpAc.Default = false;
                                // Localizar el subArticulo y eliminarlo
                                foreach (Control child in this.Controls)
                                {
                                    if (child.Name.StartsWith(locacionY.ToString()) && child.Text == articuloOp.Producto)
                                    {
                                        csOp = child;
                                        locacionYsOp = child.Location.Y;
                                        break;
                                    }
                                }

                                if (locacionYsOp != 0) // Si no se ha puesto ninguna subOpcion, hay que agregarla.
                                {
                                    this.Controls.Remove(csOp);
                                    ArticuloYsChangeInterno(locacionYsOp, _renglonAlturaCustom, false);
                                    ArticuloYsChange(this.Location.Y, _renglonAlturaCustom, false);
                                }
                            }
                        }
                    }

                }
                else // Si es un Intercambiable Normal
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
            }
        }
        /// <summary>
        /// Calcula el costo por los Ingredientes extras de acuerdo a la configuracion del Articulo Padre (debe de ser de tipo 'Custom') 
        /// </summary>
        private void CalculaCostoAdicional()
        {
            var precioAdicionalOrg = _precioAdicional;
            var ingRacionCompleta = _articulo.Opciones.Where(i => i.Default && i.MediaRacion == 0).Count(); // Cantidad ingredientes con Racion Completa.
            var mediasRaciones = _articulo.Opciones.Where(i => i.Default && i.MediaRacion > 0).Count(); // Cantidad total de ingredientes a Media Racion.
            var ingTotales = ingRacionCompleta + (mediasRaciones / 2); 
            if (mediasRaciones > 0)
                if ((mediasRaciones % 2) != 0)
                    ingTotales++; // Si la divicion termina en fraccion se agrega un ingrediente
            if (ingTotales > _articulo.IngredientesSinCosto)
                _precioAdicional = _articulo.CostoIngredienteAdicional * (ingTotales - _articulo.IngredientesSinCosto);
            else
                _precioAdicional = 0;

            if (precioAdicionalOrg == 0 && _precioAdicional > 0) // Si se recien tiene costo extra (Agregar la leyenda)
            {

                // Agregar la leyenda de Costo por Ingredientes Extras.
                var locacionYCA = _opcionAlturaInicial + (_renglonAlturaCustom * (_articulo.Opciones.Count(o => o.Default))) + 1;
                var nCtrl = new Label()
                {
                    Size = lblOpcion.Size,
                    Visible = true,
                    Text = string.Format("Costo de Ingrediente " + _format, _precioAdicional),
                    Font = fontCustom,
                    Location = new Point(0, locacionYCA),
                    BackColor = SystemColors.ControlDark,
                    TextAlign = ContentAlignment.MiddleRight,
                    Name = "CostoAdicional"
                };                
                this.Size = new Size(309, this.Size.Height + _renglonAlturaCustom + _marginBottonCustom);
                nCtrl.Click += lblOpcion_Click;

                this.Controls.Add(nCtrl);
                this.Controls.SetChildIndex(nCtrl, 1);
                nCtrl.BringToFront();

                ArticuloYsChange(this.Location.Y, _renglonAlturaCustom, true);
            }
            if (precioAdicionalOrg != 0 && _precioAdicional == 0) // Si se recien NO tiene costo extra (Quitar la leyenda)
            {
                foreach (Control child in this.Controls)
                {
                    if (((Label)child).Name == "CostoAdicional")
                    {
                        var locY = child.Location.Y;
                        this.Controls.Remove(child);
                        ArticuloYsChangeInterno(locY, _renglonAlturaCustom, false);
                        this.Size = new Size(309, this.Size.Height - _renglonAlturaCustom);
                        ArticuloYsChange(this.Location.Y, _renglonAlturaCustom, false);
                        break;
                    }

                }
            }
            if (precioAdicionalOrg != 0 && _precioAdicional != 0) // Si se recien tiene costo extra (Actualizar el precio)
            {
                foreach (Control child in this.Controls)
                {
                    if (((Label)child).Name == "CostoAdicional")
                    {
                        var locY = child.Location.Y;
                        ((Label)child).Text = string.Format("Costo de Ingrediente " + _format, _precioAdicional);
                        break;
                    }
                }
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="articuloOp">Sub Articulo (articulo opcion) agregado</param>
        /// <param name="locacionY">PosicionY del producto Padre</param>
        /// <param name="locacionYso">PosicionY del subproducto</param>
        /// <param name="paddingLeft">Padding del subproducto</param>
        /// <param name="causesValidation">Para los casos de ""CustomEsp" como Refrescos</param>
        /// <param name="mediaRacion">Indica la cantidad de la racion donde 0 = Racion comprela, 1.- Media Racion 1, 2.- Media Racion 2</param>
        private void AddSubOpcionCtrl(Articulo articuloOp, int locacionY, int locacionYso, int paddingLeft, bool causesValidation = false, int mediaRacion = 0)
        {
            var nCtrl = new Label()
            {
                Size = lblOpcion.Size, 
                Visible = true,
                Text = articuloOp.Producto + (mediaRacion != 0 ? mediaRacion.ToString() : string.Empty),
                Font = fontCustom, 
                Location = new Point(0, locacionYso), 
                BackColor = SystemColors.ControlDark,
                Padding = new Padding(paddingLeft, 0, 0, 0),
                Name = locacionY.ToString() + "_" + articuloOp.Producto,
                CausesValidation = causesValidation
            };
            //_articulo.Opciones.Find(o => o.ArticuloOp.Producto == articuloOp.Producto).Default = true;
            //this.Size = new Size(309, _renglonAlturaNormal + (_renglonAlturaCustom * _articulo.Opciones.Count(o => o.Default) + _marginBottonCustom));
            this.Size = new Size(309, this.Size.Height + _renglonAlturaCustom);
            nCtrl.Click += lblOpcion_Click;

            this.Controls.Add(nCtrl);
            this.Controls.SetChildIndex(nCtrl, 1);
            nCtrl.BringToFront();
            
            ArticuloYsChange(this.Location.Y, _renglonAlturaCustom, true);
        }
        private void ArticuloYsChangeInterno(int locationY, int altura, bool mas)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Location.Y > locationY)
                {
                    if (mas)
                    {
                        ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y + altura);
                        if (((Label)ctrl).Name == "CostoAdicional")
                        {
                            this.Controls.SetChildIndex(ctrl, 1);
                            ctrl.BringToFront();
                        }
                    }
                    else
                        ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y - altura);
                }
            }
        }
        private void onClick(object sender)
        {
            // ToSelected();  Esto se hace desde fuera, ya que primero se pasan todos a Regular.
            //if (_articulo.ComboTipo.ToLower().StartsWith("custom"))
            //    OpcionClicked(_articulo, ((Label)sender).Parent.Location.Y, 2, null); //((Label)sender).Location.Y, null);
            //else
            //    OpcionClicked(_articulo, ((Label)sender).Parent.Location.Y, -1, null);

            if (_articulo.ComboTipo.ToLower().StartsWith("custom"))
                OpcionClicked(_articulo, this.Location.Y, 2, null); //((Label)sender).Location.Y, null);
            else
                OpcionClicked(_articulo, this.Location.Y, -1, null);
        }
        private void pnlArtVendido_Click(object sender, EventArgs e)
        {            
            onClick(sender);
        }

        private void lblOpcion_Click(object sender, EventArgs e)
        {
            int locationY;
            locationY = Convert.ToInt32(((Label)sender).Name.Split('_')[0]);
            
            var optInter = _articulo.Opciones.Where(op =>
                (op.LocationY == locationY && op.ArticuloOp.Opciones.Count > 0
                )).FirstOrDefault();


            //if (optInter != null)
            //    OpcionClicked(_articulo, ((Label)sender).Parent.Location.Y, locationY, optInter.ArticuloOp);
            //else
            //    OpcionClicked(_articulo, ((Label)sender).Parent.Location.Y, locationY, null);

            if (optInter != null)
                OpcionClicked(_articulo, this.Location.Y, locationY, optInter.ArticuloOp);
            else
                OpcionClicked(_articulo, this.Location.Y, locationY, null);
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
