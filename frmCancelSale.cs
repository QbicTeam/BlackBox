using BlackBox.Bussiness;
using BlackBox.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
            var colorFondoGrid = Color.FromArgb(254, 200, 132);
            this.BackColor = colorFondoGrid;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRecibo.Text))
                return;
            
            lstArticulos.Items.Clear();
            cmdCancelar.Enabled = false;
            

            vta = vtasManager.GetTicket(txtRecibo.Text);
            txtCajero.Text = vta.Cajero;
            txtFecha.Text = vta.FechaHora.ToString("dd/MMM/yyyy   HH:mm");
            txtVentaTotal.Text = string.Format("{0:C}", vta.Total);
            txtNumArt.Text = vta.CantidadArticulos.ToString();
            chkCancelado.Checked = vta.Cancelado;
            chkEnCorte.Checked = vta.EnCorte > 0 ? true : false;

            if (vta.VentaId == 0)
            {
                MessageBox.Show("Numero de Recibo inexistente, favor de confirmar.");
                return;
            }
                

            if (!chkCancelado.Checked && !chkEnCorte.Checked)
                cmdCancelar.Enabled = true; 


            if (vta.Productos == null)
                return;

            foreach(VentaDT vdt in vta.Productos)
            {
                lstArticulos.Items.Add(new string(' ', 5 * vdt.Nivel) + vdt.Producto);
            }
            
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            vtasManager.CancelTicket(vta.VentaId);
            // TODO: Abrir Cajon.
            AbrirCajon(); // Se abre imprimirndo, para abrirlo se configura en la impresora en settings
            MessageBox.Show("El recibo fue cancelado.");
        }

        private void AbrirCajon()
        { 
            prtdImprimir = new PrintDocument();
            var ps = new PrinterSettings();
            prtdImprimir.PrinterSettings = ps;
            prtdImprimir.PrintPage += Imprimir;
            prtdImprimir.Print();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Courier New", 10, FontStyle.Regular, GraphicsUnit.Point);
            int width = 490;
            int y = 20;


            e.Graphics.DrawString("Cancelacion del Recibo: " + txtRecibo.Text, font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString("dd/MMM/yyyy   HH:mm"), font, Brushes.Black, new RectangleF(0, y += 20, width, 20));

        }
    }
}
