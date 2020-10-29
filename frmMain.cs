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
        }

        public void ShowMain(Form entryForm, Form loginForm)
        {
            //entryForm.Close();
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
    }
}
