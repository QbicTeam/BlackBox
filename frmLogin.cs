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
    public partial class frmLogin : Form
    {
        Form _entryForm;

        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string onScreenKeyboardPath = System.IO.Path.Combine(progFiles, "TabTip.exe");
            var onScreenKeyboardProc = System.Diagnostics.Process.Start(onScreenKeyboardPath);

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            //txtUser.BorderStyle = BorderStyle.None;
            //Pen p = new Pen()
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.ShowMain(this._entryForm, this);
        }

        public void ShowLogin(Form entryForm)
        {
            this._entryForm = entryForm;
            //textBox2.Text = top.ToString();

            //this.Left = left + 100;
            //this.Location = new Point(this.Left - 100, this.Top);
            this.Show();
        }
    }
}
