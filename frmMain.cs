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
    public partial class frmMain : Form
    {
        Form _entryForm;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pnlInicio.Location = new Point(15, 96);
            pnlAdmon.Location = new Point(15, 96);
            pnlHorario.Location = new Point(15, 96);
            pnlMensajeria.Location = new Point(15, 96);

            pnlInicio.Height = 622;
            pnlInicio.Width = 958;

            pnlAdmon.Height = 622;
            pnlAdmon.Width = 958;

            pnlHorario.Height = 622;
            pnlHorario.Width = 958;

            pnlMensajeria.Height = 622;
            pnlMensajeria.Width = 958;

            cmdInicio.Location = new Point(22, 690);
            cmdAdmon.Location = new Point(257, 690);
            cmdHorario.Location = new Point(496, 690);
            cmdMensajeria.Location = new Point(738, 690);

            cmdEntrada.Image = imgEntrada.Image;
            cmdImprimir.Image = imgImprimir.Image;
            cmdDisponibilidad.Image = imgEmpleados.Image;
            cmdEmpleados.Image = imgEmpleados.Image;
            cmdHorarioV2.Image = imgHorario.Image;
            cmdResumen.Image = imgResumen.Image;
            cmdCompletar.Image = imgCompletar.Image;
            cmdOrdenes.Image = imgOrden.Image;
            cmdMensajeriaV2.Image = imgMensajeria.Image;

        }

        public void ShowMain(Form entryForm, Form loginForm)
        {
            this._entryForm = entryForm;
            loginForm.Close();

            this.Show();
        }

        private void cmdShowPanel(object sender, EventArgs e)
        {
            HidePanels();
            Button btn = (Button)sender;

            if (btn.Name == "cmdInicio") pnlInicio.Show();
            if (btn.Name == "cmdAdmon") pnlAdmon.Show();
            if (btn.Name == "cmdHorario") pnlHorario.Show();
            if (btn.Name == "cmdMensajeria") pnlMensajeria.Show();
        }

        private void HidePanels()
        {

            pnlInicio.Hide();
            pnlAdmon.Hide();
            pnlHorario.Hide();
            pnlMensajeria.Hide();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this._entryForm.Close();
        }

        private void cmdEntrada_MouseEnter(object sender, EventArgs e)
        {
            cmdEntrada.Image = imgHEntrada.Image;
        }

        private void cmdEntrada_MouseLeave(object sender, EventArgs e)
        {
            cmdEntrada.Image = imgEntrada.Image;
        }

        private void cmdImprimir_MouseEnter(object sender, EventArgs e)
        {
            cmdImprimir.Image = imgHImprimir.Image;
        }

        private void cmdImprimir_MouseLeave(object sender, EventArgs e)
        {
            cmdImprimir.Image = imgImprimir.Image;
        }

        private void cmdDisponibilidad_MouseEnter(object sender, EventArgs e)
        {
            cmdDisponibilidad.Image = imgHEmpleados.Image;
        }

        private void cmdDisponibilidad_MouseLeave(object sender, EventArgs e)
        {
            cmdDisponibilidad.Image = imgDisponibilidad.Image;
        }

        private void cmdEmpleados_MouseEnter(object sender, EventArgs e)
        {
            cmdEmpleados.Image = imgHEmpleados.Image;
        }

        private void cmdEmpleados_MouseLeave(object sender, EventArgs e)
        {
            cmdEmpleados.Image = imgEmpleados.Image;
        }

        private void cmdHorarioV2_MouseEnter(object sender, EventArgs e)
        {
            cmdHorarioV2.Image = imgHHorario.Image;
        }

        private void cmdHorarioV2_MouseLeave(object sender, EventArgs e)
        {
            cmdHorarioV2.Image = imgHorario.Image;
        }

        private void cmdResumen_MouseEnter(object sender, EventArgs e)
        {
            cmdResumen.Image = imgHResumen.Image;
        }

        private void cmdResumen_MouseLeave(object sender, EventArgs e)
        {
            cmdResumen.Image = imgResumen.Image;
        }

        private void cmdCompletar_MouseEnter(object sender, EventArgs e)
        {
            cmdCompletar.Image = imgHCompletar.Image;
        }

        private void cmdCompletar_MouseLeave(object sender, EventArgs e)
        {
            cmdCompletar.Image = imgCompletar.Image;
        }

        private void cmdOrdenes_MouseEnter(object sender, EventArgs e)
        {
            cmdOrdenes.Image = imgHOrden.Image;
        }

        private void cmdOrdenes_MouseLeave(object sender, EventArgs e)
        {
            cmdOrdenes.Image = imgOrden.Image;
        }

        private void cmdMensajeriaV2_MouseEnter(object sender, EventArgs e)
        {
            cmdMensajeriaV2.Image = imgHMensajeria.Image;
        }

        private void cmdMensajeriaV2_MouseLeave(object sender, EventArgs e)
        {
            cmdMensajeriaV2.Image = imgMensajeria.Image;
        }

        private void cmdOrdenes_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
        }
    }
}
