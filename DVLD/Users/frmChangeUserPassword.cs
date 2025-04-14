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
using System.Security.Cryptography;


namespace DVLD
{
    public partial class frmChangeUserPassword : Form
    {
        private clsUser _user;
        private int _userID;
        public frmChangeUserPassword(int UserID)
        {
            InitializeComponent();
            _userID = UserID;
            btnShowPass.CausesValidation = false;
        }

        private void _ResetDefaultValues()
        {
            txtCurrentPass.Text = txtNewPass.Text = txtConfirmPass.Text = string.Empty;
            txtCurrentPass.Focus();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConfirmPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPass.Text.Trim() != txtNewPass.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPass, "Password Must Match");
            }
            else
                errorProvider1.SetError(txtConfirmPass, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                using (SHA256 sha = SHA256.Create())
                {
                    byte[] HashedPassBytes = sha.ComputeHash(Encoding.UTF8.GetBytes(txtCurrentPass.Text));
                    string HashedPass = BitConverter.ToString(HashedPassBytes).Replace("-", "").ToLower();


                    if (_user.Password != HashedPass)
                    {
                        MessageBox.Show("Current Password is Wrong Check your Password and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        _user.Password = txtNewPass.Text;
                        if (_user.ChangeUserPassword())
                        {
                            MessageBox.Show("Password Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error Happend while Updating", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill all required Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
             if (btnShowPass.Tag?.ToString() == "0")
            {
                btnShowPass.Image = Resources.eye__1_;
                txtCurrentPass.UseSystemPasswordChar =  txtNewPass.UseSystemPasswordChar =
                    txtConfirmPass.UseSystemPasswordChar = false;
                btnShowPass.Tag = "1";
            }
            else
            {
                btnShowPass.Image = Resources.hidden;
                txtCurrentPass.UseSystemPasswordChar =  txtNewPass.UseSystemPasswordChar =
                    txtConfirmPass.UseSystemPasswordChar = true;
                btnShowPass.Tag = "0";
            }
        }

        private void ctrlUserCard1_Load(object sender, EventArgs e)
        {

        }

        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            _user = clsUser.FindByUserID(_userID);


            if (_user == null)
            {
                MessageBox.Show("No User with ID = " + _userID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            ctrlUserCard1.LoadUserInfo(_userID);
        }

        private void txtCurrentPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtCurrentPass.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPass, "Password Can't be empty");
            }
            else
                errorProvider1.SetError(txtCurrentPass, null);
        }

        private void txtNewPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewPass.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPass, "New Password Can't be empty");
            }
            else
                errorProvider1.SetError(txtNewPass, null);
        }
    }
}
