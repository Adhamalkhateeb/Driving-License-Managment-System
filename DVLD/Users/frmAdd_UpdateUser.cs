using DVLD.Properties;
using DVLDBussinesLayer;
using Microsoft.VisualBasic;
using PeopleBusinessLayer;
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
    public partial class frmAdd_UpdateUser : Form
    {

        private enum enMode { AddNew = 1, Update = 2 }

        private enMode _Mode;
        private int _userID = -1;
        private clsUser _user;
        public frmAdd_UpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            ctrlPersonCardWithFilter2.FilterFocus();
        }

        public frmAdd_UpdateUser(int UserID)
        {

            InitializeComponent();
            _userID = UserID;
            _Mode = enMode.Update;
            ctrlPersonCardWithFilter2.FilterFocus();

        }

        private void _ResetDefaultValue()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                _user = new clsUser();
                tabLogin.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                lblTitle.Text = "Update User";
                tabLogin.Enabled = true;
                btnSave.Enabled = true;

            }
            txtUserName.Text = txtPassword.Text = txtConfirmPass.Text = string.Empty;
            this.Text = lblTitle.Text;
            btnClose.CausesValidation = false;

        }

        private void _LoadData()
        {
            _user = clsUser.FindByUserID(_userID);

            if (_user == null)
            {
                MessageBox.Show("No User with ID = " + _userID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblConfirmPassword.Visible = false;
            txtConfirmPass.Visible = false;
            btnConfirmPass.Visible = false;
            btnPass.Visible = false;
            pbConfirmPassword.Visible = false;
            txtPassword.Visible = false;
            llUpdatePass.Visible = true; 


            ctrlPersonCardWithFilter2.FilterEnabled = false;
            ctrlPersonCardWithFilter2.LoadPersonInfo(_user.PersonID);
            ctrlPersonCard1.LoadPersonInfo(_user.PersonID);

            lblUserID.Text = _userID.ToString();
            txtUserName.Text = _user.UserName;
            chkActive.Checked = _user.IsActive;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (_Mode == enMode.Update)
            {
                tabLogin.Enabled = true;
                btnSave.Enabled = true;
                tabControl1.SelectedIndex = 1;
                return;
            }
            if (ctrlPersonCardWithFilter2.PersonID != -1)
            {

                if (clsUser.IsUserExistByPersonID(ctrlPersonCardWithFilter2.PersonID))
                {
                    MessageBox.Show($@" Person with ID [{ctrlPersonCardWithFilter2.PersonID}] already has user,Choose another one",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter2.FilterFocus();
                    
                    return;
                }
                else
                {
                    btnSave.Enabled = true;
                    tabLogin.Enabled = true;
                    tabControl1.SelectedIndex =1;

                }
            }
            else
            {
                MessageBox.Show($@"Please choose Person to Continue or Create new one",
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter2.FilterFocus();
                tabControl1.SelectedIndex = 0;

            }
        }

        private void ErrorValidating(object sender, CancelEventArgs e, string ErrorMessage, bool Errorhappend = false)
        {
            if (string.IsNullOrEmpty(((Control)sender).Text.Trim()) || Errorhappend)
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, ErrorMessage);

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError((Control)sender, null);
            }
        }
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                if (clsUser.IsUserExistByUserName(txtUserName.Text.Trim()))
                {
                    ErrorValidating(sender, e, "User Name is used choose another User Name", true);
                }
            }
           
            ErrorValidating(sender, e, "User Name is Required");
            
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            ErrorValidating(sender, e, "Password is Required");
        }

        private void txtConfirmPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPass.Text.Trim() == "")
                ErrorValidating(sender, e, "Confirm Pass to continue");
            else if (txtConfirmPass.Text.Trim() != txtPassword.Text.Trim())
                ErrorValidating(sender, e, "Password Confirmation does not match Password!", true);
            else
                errorProvider1.SetError(txtConfirmPass, null);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ctrlPersonCardWithFilter2.PersonID == -1 && tabControl1.SelectedIndex != 0)
            {
                MessageBox.Show($@"Please choose Person to Continue or Create new one",
                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter2.FilterFocus();
                tabControl1.SelectedIndex = 0;
                return;
            }
            
            if(tabControl1.SelectedIndex ==1)
                ctrlPersonCard1.LoadPersonInfo(ctrlPersonCardWithFilter2.PersonID);

                
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagePassword(object sender, TextBox textBox)
        {

            if (textBox.UseSystemPasswordChar)
            {

                ((Button)sender).Image = Resources.eye__1_;
                textBox.UseSystemPasswordChar = false;
            }
            else
            {
                ((Button)sender).Image = Resources.hidden;
                textBox.UseSystemPasswordChar = true;
            }
        }
        private void btnPass_Click(object sender, EventArgs e)
        {
            ManagePassword(sender, txtPassword);
            txtPassword.Focus();
        }

        private void btnConfirmPass_Click(object sender, EventArgs e)
        {
            ManagePassword(sender, txtConfirmPass);
            txtConfirmPass.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                chkActive.Text = "Active";
            }
            else
            {
                chkActive.Text = "Not Active";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                _user.PersonID = ctrlPersonCardWithFilter2.PersonID;
                _user.Password = txtPassword.Text.Trim();
                _user.UserName = txtUserName.Text.Trim();
                _user.IsActive = chkActive.Checked;

                if (_user.Save())
                {
                    MessageBox.Show("User Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblUserID.Text = _user.UserID.ToString();
                    _Mode = enMode.Update;
                    lblTitle.Text = "Update User";
                    ctrlPersonCardWithFilter2.FilterEnabled = false;

                }
                else
                {
                    MessageBox.Show("Error Happend while saving", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Text = lblTitle.Text;
            }
        }
        private void frmAdd_UpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();

            if (_Mode == enMode.Update)
                _LoadData();
            btnPass.CausesValidation = false;
            btnConfirmPass.CausesValidation = false;

        }

        private void llUpdatePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChangeUserPassword frmChangeUserPassword = new frmChangeUserPassword(_user.UserID);
            frmChangeUserPassword.ShowDialog();
        }
    }
}
