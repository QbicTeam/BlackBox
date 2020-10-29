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
            this.FormBorderStyle = FormBorderStyle.None;
            lblVersion.Parent = pnlHeader;
            lblVersion.BackColor = Color.Transparent;

            lblVersion.Text = "17.1.2.0.1827 03 Sep-2020";

            lblFooter1.Text = "Sitio: Q27-A1U-HHA-80U Computadora: L2A6-PHONE1";
            lblFooter2.Text = "Lun 11:57 am";
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            //string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            //string onScreenKeyboardPath = System.IO.Path.Combine(progFiles, "TabTip.exe");
            //var onScreenKeyboardProc = System.Diagnostics.Process.Start(onScreenKeyboardPath);
        }
    }
}
