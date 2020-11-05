using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBox.Controls
{
    public partial class pnlArtVendido : UserControl
    {
        public pnlArtVendido()
        {
            InitializeComponent();
        }
        public pnlArtVendido(string nombre, double precio)
        {
            InitializeComponent();

            string precioF = string.Empty;
            precioF = string.Format("{0:C}", precio);

            //pnlArtVendido.DefaultBackColor = SystemColors.ControlDark;
            lblPrecio.Font = new Font(lblPrecio.Font, FontStyle.Bold);
            /* lblPrecio.AutoSize = false;
            lblPrecio.TextAlign = ContentAlignment.MiddleRight;
            lblPrecio.RightToLeft = RightToLeft.Yes;
            */
            lblArticulo.Font = new Font(lblArticulo.Font, FontStyle.Bold);
            lblFondo.BackColor = SystemColors.ControlDark;
            lblArticulo.BackColor = SystemColors.ControlDark;
            lblPrecio.BackColor = SystemColors.ControlDark;

            lblArticulo.Text = nombre;
            lblPrecio.Text = precioF;
            

            
        }

        public void ToRegular()
        {
            lblFondo.BackColor = Color.White;
            lblArticulo.BackColor = Color.White;
            lblPrecio.BackColor = Color.White;

            lblArticulo.Font = new Font(lblArticulo.Font, FontStyle.Regular);
            lblPrecio.Font = new Font(lblPrecio.Font, FontStyle.Regular);

            lblArticulo.ForeColor = SystemColors.GrayText;
            lblPrecio.ForeColor = SystemColors.GrayText;
        }
    }
}
