using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackBox.Model;
using Newtonsoft.Json.Linq;

namespace BlackBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var json = File.ReadAllText("appSettings.json");
            var datos = JsonConvert.DeserializeObject<ObjBlackBox>(json);

            this.FormBorderStyle = FormBorderStyle.None;
            lblVersion.Parent = pnlHeader;
            lblVersion.BackColor = Color.Transparent;

            lblVersion.Text = datos.Login.Version + " " + datos.Login.FechaVersion; //"17.1.2.0.1827 03 Sep-2020";

            lblFooter1.Text = String.Format("Sitio: {0} Computadora: {1}", datos.Login.Sitio, datos.Login.Computadora); //"Sitio: Q27-A1U-HHA-80U Computadora: L2A6-PHONE1";

            //System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("es-MX");
            //System.Threading.Thread.CurrentThread.CurrentCulture = ci;

            string[] dias = { "Dom", "Lun", "Mar", "Mie", "Jue", "Vie", "Sab" };
            var diai = (int)DateTime.Today.DayOfWeek;
            var dia = dias[diai];


            lblFooter2.Text = dia + " " + DateTime.Now.ToString("hh:mm") + (DateTime.Now.Hour <= 12 ? "am":"pm"); // "Lun 11:57 am";  spa-es ddd
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            
            frmLogin login = new frmLogin();
            login.ShowLogin(this);
            
            frmMenu menu = new frmMenu();
            menu.Show();
            

            

            //string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            //string onScreenKeyboardPath = System.IO.Path.Combine(progFiles, "TabTip.exe");
            //var onScreenKeyboardProc = System.Diagnostics.Process.Start(onScreenKeyboardPath);
        }
    }
}
