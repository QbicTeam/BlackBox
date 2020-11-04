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

            lblArticulo.Text = nombre;
            lblPrecio.Text = precioF;
            

            
        }

        public void ToRegular()
        {
            lblArticulo.Font = new Font(lblArticulo.Font, FontStyle.Regular);
            lblPrecio.Font = new Font(lblPrecio.Font, FontStyle.Regular);

            lblArticulo.ForeColor = SystemColors.InactiveCaptionText;
            lblPrecio.ForeColor = SystemColors.InactiveCaptionText;
        }
    }
}
