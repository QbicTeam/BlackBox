using BlackBox.Bussiness;
using BlackBox.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBox
{
    public partial class frmCancelSale : Form
    {
        private VentasManager vtasManager = new VentasManager(ConfigurationManager.ConnectionStrings["FBBCS"].ConnectionString);
        private Venta vta;
        public frmCancelSale()
        {
            InitializeComponent();
        }

        private void frmCancelSale_Load(object sender, EventArgs e)
        {

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRecibo.Text))
                return;

            vta = vtasManager.GetTicket(txtRecibo.Text);
            txtCajero.Text = vta.Cajero;
            txtFecha.Text = vta.FechaHora.ToString("dd/MMM/yyyy   HH:mm");
            txtVentaTotal.Text = string.Format("{0:C}", vta.Total);
            txtNumArt.Text = vta.CantidadArticulos.ToString();
            chkCancelado.Checked = vta.Cancelado;
            chkEnCorte.Checked = vta.EnCorte > 0 ? true : false;
            
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
