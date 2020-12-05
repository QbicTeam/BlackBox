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
        public delegate void onArticuloSelected(object sender, int y, int i);

        public event onArticuloSelected OpcionClicked;

        private decimal _precioBase = 0;
        private int _cantidad = 1;
        private int _renglonAlturaNormal = 27;
        private int _renglonAlturaCustom = 24;
        private int _opcionAlturaInicial = 27;
        private Color _verdeFuerte = Color.FromArgb(0, 128, 0);
        private Color _verdeClaro = Color.FromArgb(127, 191, 127);
        private Articulo _articulo;
        private bool _intercambiables;
        public List<int> _sinAsignar;

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
            _precioBase = articulo.Precio;
            precioF = string.Format("{0:C}", _precioBase);  //precio);

            // Valore Iniciales
            lblFondo.Location = new Point(0, 0);
            lblOpcion.Location = new Point(13, 27);
            _articulo = articulo;
            _intercambiables = false;
            _sinAsignar = new List<int>();

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
                    this.Size = new Size(309, _renglonAlturaNormal + (_renglonAlturaCustom * articulo.Opciones.Count));
                    break;
                case "customesp":
                    this.Size = new Size(309, _renglonAlturaNormal + (_renglonAlturaCustom * articulo.Opciones.Count));
                    break;
                default:  // Los Normales... si no esta definido es tratado como Normal
                    this.Size = new Size(309, _renglonAlturaNormal); // 27 Altura base Normal
                    break;
            }
            lblFondo.Size = this.Size;

            // Articulos Opciones
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
                        _intercambiables = true;
                        _articulo.Opciones[i - 1].LocationY = nCtrl.Location.Y;
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


            //pnlArtVendido.DefaultBackColor = SystemColors.ControlDark;
            /*
            lblPrecio.Font = new Font(lblPrecio.Font, FontStyle.Bold);
            lblArticulo.Font = new Font(lblArticulo.Font, FontStyle.Bold);
            lblFondo.BackColor = SystemColors.ControlDark;
            lblArticulo.BackColor = SystemColors.ControlDark;
            lblPrecio.BackColor = SystemColors.ControlDark;
            */

            ToSelected();

            lblArticulo.Text = articulo.Producto; // nombre;
            lblPrecio.Text = precioF;





        }

        public void ToRegular()
        {
            Color foreColor = SystemColors.GrayText;

            lblFondo.BackColor = Color.White;
            lblArticulo.BackColor = Color.White;
            lblPrecio.BackColor = Color.White;

            if (_articulo.ComboTipo.ToLower() == "combo")
            {
                foreColor = SystemColors.ControlText;
            }

            lblArticulo.ForeColor = foreColor;
            lblPrecio.ForeColor = foreColor;

            if (_articulo.ComboTipo.ToLower() != "combo")
            {
                lblArticulo.Font = new Font(lblArticulo.Font, FontStyle.Regular);
                lblPrecio.Font = new Font(lblPrecio.Font, FontStyle.Regular);
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
            if (_intercambiables)
                backColor = Color.White;
            else
                backColor = SystemColors.ControlDark;

            lblPrecio.Font = new Font(lblPrecio.Font, FontStyle.Bold);
            lblArticulo.Font = new Font(lblArticulo.Font, FontStyle.Bold);

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

        private void pnlArtVendido_Click(object sender, EventArgs e)
        {
            // ToSelected();
            OpcionClicked(_articulo, ((Label)sender).Parent.Location.Y, -1);
        }

        private void lblOpcion_Click(object sender, EventArgs e)
        {
            // ToSelected();
            // TODO: Cambiar por el subMenu a desplegar si se trata de un intercambiable o un "Custom"
            var optInter = _articulo.Opciones.Where(op => 
                (op.Intercambiable || op.ArticuloOp.ComboTipo.ToLower() == "customesp") 
                && op.LocationY == ((Label)sender).Location.Y).FirstOrDefault();

            if (optInter == null)
                OpcionClicked(_articulo, ((Label)sender).Parent.Location.Y, ((Label)sender).Location.Y);
            else
                OpcionClicked(optInter, ((Label)sender).Parent.Location.Y, ((Label)sender).Location.Y);
        }

        private void lblArticulo_Click(object sender, EventArgs e)
        {
            // ToSelected();
            OpcionClicked(_articulo, ((Label)sender).Parent.Location.Y, -1);
        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {
            // ToSelected();
            OpcionClicked(_articulo, ((Label)sender).Parent.Location.Y, -1);
        }

        private void lblFondo_Click(object sender, EventArgs e)
        {
            // ToSelected();
            OpcionClicked(_articulo, ((Label)sender).Parent.Location.Y, -1);
        }
    }
}
