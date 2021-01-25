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
    public partial class frmAdminUsers : Form
    {

        UsersManager um = new UsersManager(ConfigurationManager.ConnectionStrings["FBBCS"].ConnectionString);

        public frmAdminUsers()
        {
            InitializeComponent();
            this.PrepareForm();
        }

        private void PrepareForm()
        {
            this.Reset();
            this.LoadUsers();
        }

        private void Reset()
        {
            lblId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            txtUserName.Text = string.Empty;

            cboUsers.SelectedIndex = -1;
            cboRole.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;

        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            Reset();
        }


        private void InsertUser()
        {
            User user = new User
            {
                Nombre = txtName.Text,
                Password = txtPassword.Text,
                Puesto = cboRole.Text,
                Status = cboStatus.Text,
                UserName = txtUserName.Text
            };

            this.um.Save(user);
            
        }

        private void UpdateUser()
        {
            User user = new User
            {
                Id = Convert.ToInt32(lblId.Text),
                Nombre = txtName.Text,
                Password = txtPassword.Text,
                Puesto = cboRole.Text,
                Status = cboStatus.Text,
                UserName = txtUserName.Text
            };

            this.um.Update(user);
        }

        private void LoadUsers()
        {
            cboUsers.Items.Clear();
            List<User> users = this.um.GetUsersList();

            cboUsers.Items.Add(new User { Id = 0, Nombre = "" });

            foreach(var itm in users)
            {
                cboUsers.Items.Add(itm);
            }

            cboUsers.DisplayMember = "Nombre";
            cboUsers.ValueMember = "Id";

        }

        private bool Sanitize()
        {


            if (txtName.Text == string.Empty ||
                txtUserName.Text == string.Empty ||
                cboRole.Text == string.Empty ||
                cboStatus.Text == string.Empty)
                return false;

            if (string.IsNullOrEmpty(lblId.Text))
            {
                if (txtPassword.Text == string.Empty || txtConfirmPassword.Text == string.Empty)
                    return false;

            }
            if (txtConfirmPassword.Text != txtPassword.Text)
                return false;

            return true;
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

        private void cboUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            User user = (User)cboUsers.SelectedItem; // (User)sender;

            if (user == null)
                return;

            if (user.Id > 0)
            {
                User loadedUser = this.um.GetUserById(user.Id);

                if (loadedUser != null)
                {
                    this.DisplayUser(loadedUser);
                }
            }
        }

        private void DisplayUser(User user)
        {
            lblId.Text = user.Id.ToString();
            txtName.Text = user.Nombre;
            cboRole.Text = user.Puesto;
            cboStatus.Text = user.Status;
            txtUserName.Text = user.UserName;
        }
    }
}
