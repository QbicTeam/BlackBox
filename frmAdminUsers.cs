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
    public partial class frmAdminUsers : Form
    {


        public frmAdminUsers()
        {
            InitializeComponent();
            this.PrepareForm();
        }

        private void PrepareForm()
        {

        }

        private void Reset()
        {
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;

            cboUsers.SelectedIndex = 0;
            cboRole.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;

        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            Reset();
        }


        private void InsertUser()
        {
            string pwdSalt = string.Empty;
            string pwdHash = string.Empty;

            // this.EncryptPwd(txtPassword.Text, out pwdSalt, out pwdHash);

            string sql = "insert users(nombre, puesto, activo, pwdhash, pwdsalt) values("
                + "'" + txtName.Text + "', "
                + "'" + cboRole.Text + "', "
                + "'" + cboStatus.Text + "', "
                + "'" + pwdHash + "', "
                + "'" + pwdSalt + "')";

            

        }

        private void UpdateUser()
        {

        }

        private void LoadUsers()
        {

        }

        private bool Sanitize()
        {
            return false;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (!this.Sanitize())
                return;

            if (lblId.Text != string.Empty)
            {
                this.UpdateUser();
            }
            else
            {
                this.InsertUser();
            }
        }
    }
}
