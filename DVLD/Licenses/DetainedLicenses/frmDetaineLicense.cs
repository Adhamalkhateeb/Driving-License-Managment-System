using DVLDBussinesLibary;
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
    public partial class frmDetaineLicense : Form
    {
        private int _LicenseID;
        public frmDetaineLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetaineLicense_Load(object sender, EventArgs e)
        {

            lblDetainDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            ctrlLocalLicenseInfoWithFilter1.FilterFocus();
            
        }

        private void ctrlLocalLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {

            if (obj == -1)
                return;
            llblShowLicenseHistory.Enabled = true;
            _LicenseID = obj;
            llblShowLicenseInfo.Enabled = true;

            if (!ctrlLocalLicenseInfoWithFilter1.DriverLicense.IsActive)
            {
                MessageBox.Show("Error: License Isn't active Check another active license or Call Adminstrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;

                return;
            }

            if (ctrlLocalLicenseInfoWithFilter1.DriverLicense.IsDetained)
            {
                MessageBox.Show("License is already Detained Go and pay fees To Release it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }
            txtFineFees.Focus();
            
            btnSave.Enabled = true;
            lblLocalLicenseID.Text = _LicenseID.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                int DetaineID = ctrlLocalLicenseInfoWithFilter1.DriverLicense.Detain(float.Parse(txtFineFees.Text), clsGlobal.CurrentUser.UserID, txtNotes.Text.Trim());

                if (DetaineID == -1)
                {
                    MessageBox.Show("Failed to Detain License With ID [" +_LicenseID + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ctrlLocalLicenseInfoWithFilter1.FilterEnabled = false;
                btnSave.Enabled = false;
                ctrlLocalLicenseInfoWithFilter1.LoadLicenseInfo(_LicenseID);
                lblDetainID.Text =  DetaineID.ToString();
                txtFineFees.Enabled = false;

                MessageBox.Show($"License Detained Successfully with DetainID [{DetaineID}]", "License Detained", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frmShowLicenseInfo = new frmShowLicenseInfo(_LicenseID);
            frmShowLicenseInfo.ShowDialog();
        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicensesHistory frmDriverLicensesHistory = new frmDriverLicensesHistory(ctrlLocalLicenseInfoWithFilter1.DriverLicense.DriverInfo.PersonID);
            frmDriverLicensesHistory.ShowDialog();
        }

        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFineFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Put Fines to continue");
            }
            else
                errorProvider1.SetError(txtFineFees, null);
        }

        private void txtFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back || e.KeyChar == '.');
        }
    }
}
