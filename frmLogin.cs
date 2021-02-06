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

            CenterForm();
            

        }

        private void CenterForm()
        {
            int swidth = Screen.PrimaryScreen.Bounds.Width;
            int sheight = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point((swidth / 2) - this.Width / 2, (sheight) / 2 - 250);
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
            UsersManager um = new UsersManager(ConfigurationManager.ConnectionStrings["FBBCS"].ConnectionString);

            User user = um.Login(txtUser.Text, txtPassword.Text);
            //User user = new User();

            if (user != null)
            {
                frmMain frmMain = new frmMain(user);
                frmMain.ShowMain(this._entryForm, this);
            }
            else
            {
                MessageBox.Show("Lo siento pero no tiene acceso a esta apliacion PIRATA!");
            }
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
