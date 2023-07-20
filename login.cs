using System;
using System.Drawing;
using System.Windows.Forms;

namespace managementSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        // usuario
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "username")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "username";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        // password
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "password";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Cursor = Cursors.Hand;
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
