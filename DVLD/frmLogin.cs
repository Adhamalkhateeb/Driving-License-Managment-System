using DVLD.Properties;
using DVLDBussinesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLogin : Form
    {


        public frmLogin()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar)
            {
                txtPass.UseSystemPasswordChar = false;
                btnShowPass.Image = Resources.eye__1_;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                btnShowPass.Image = Resources.hidden;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {


            string UserName = string.Empty, Password = string.Empty;

            if (clsGlobal.GetStoredCredentials(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPass.Text = Password;
                chkRemeberMe.Checked = true;
                btnShowPass.Enabled = false;
            }
            else
                chkRemeberMe.Checked = false;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = clsUser.FindByUsernameAndPassword(txtUserName.Text.Trim(), txtPass.Text.Trim());

            if (clsGlobal.CurrentUser != null)
            {

                if (chkRemeberMe.Checked)
                {
                    clsGlobal.RememberUserNameAndPassword(txtUserName.Text.Trim(), txtPass.Text.Trim());
                }
                else
                {
                    clsGlobal.RememberUserNameAndPassword("", "");
                }

                if (clsGlobal.CurrentUser.IsActive)
                {
                    MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserName.Text = txtPass.Text= string.Empty;

                    this.Hide();
                    FrmMain frmMain = new FrmMain(this);
                    frmMain.ShowDialog();

                }
                else
                {

                    MessageBox.Show("Your account is inactive. Please contact the administrator.", "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
            }
        }

        private void chkRemeberMe_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
