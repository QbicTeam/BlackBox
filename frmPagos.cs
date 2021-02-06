using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBox
{
    public partial class frmPagos : Form
    {
        string result = "";

        public frmPagos()
        {
            InitializeComponent();
        }

        public string PaySale()
        {

            this.ShowDialog();
            return result;
        }

        private void TipoPago(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;


        }

        private void Importe(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            decimal importe = Convert.ToDecimal(btn.Tag);


        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdPagar_Click(object sender, EventArgs e)
        {
            result = "true|" + txtCliente.Text ;
            this.Close();
        }
    }
}
