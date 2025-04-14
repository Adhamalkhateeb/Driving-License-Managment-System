using DVLDBussinesLayer;
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
    public partial class frmReleaseDetainedLicense : Form
    {
        int _LicenseID = -1;
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
          
        }

        public frmReleaseDetainedLicense(int DetainedLicenseID)
        {
            _LicenseID = DetainedLicenseID;
            InitializeComponent();

            ctrlLocalLicenseInfoWithFilter1.LoadLicenseInfo(_LicenseID);
            ctrlLocalLicenseInfoWithFilter1.FilterEnabled = false;

          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            lblAppFees.Text = clsApplicationTypes.Find((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense).Fees.ToString("0.00");
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

            if (!ctrlLocalLicenseInfoWithFilter1.DriverLicense.IsDetained)
            {
                MessageBox.Show("License is't Detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            lblDetainID.Text =  ctrlLocalLicenseInfoWithFilter1.DriverLicense.DetainedInfo.DetainID.ToString();
            lblDetainDate.Text = ctrlLocalLicenseInfoWithFilter1.DriverLicense.DetainedInfo.DetainDate.ToString("dd/MMM/yyyy");
            lblCreatedBy.Text = ctrlLocalLicenseInfoWithFilter1.DriverLicense.DetainedInfo._CreatedByUserInfo.UserName;
            lblFineFees.Text = ctrlLocalLicenseInfoWithFilter1.DriverLicense.DetainedInfo.FineFees.ToString("0.00");
            lblAppFees.Text = clsApplicationTypes.Find((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense).Fees.ToString("0.00");
            lblTotalFees.Text =(float.Parse(lblAppFees.Text) + float.Parse(lblFineFees.Text)).ToString("0.00");
            txtNotes.Text = ctrlLocalLicenseInfoWithFilter1.DriverLicense.DetainedInfo.Notes;

            btnSave.Enabled = true;
            lblLocalLicenseID.Text = _LicenseID.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int ApplicationID = -1;
            if (ctrlLocalLicenseInfoWithFilter1.DriverLicense.ReleaseDetainLicense(clsGlobal.CurrentUser.UserID, ref ApplicationID))
            {

                if (ApplicationID == -1)
                {
                    MessageBox.Show("Failed to Release License With ID [" +_LicenseID + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ctrlLocalLicenseInfoWithFilter1.FilterEnabled = false;
                ctrlLocalLicenseInfoWithFilter1.LoadLicenseInfo(_LicenseID);
                btnSave.Enabled = false;

                MessageBox.Show($"License with ID [{_LicenseID}]  Released Successfully", "License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrlLocalLicenseInfoWithFilter1.LoadLicenseInfo(_LicenseID);
            }
            else
                MessageBox.Show("Failed to Release License With ID [" +_LicenseID + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicensesHistory frmDriverLicensesHistory = new frmDriverLicensesHistory(ctrlLocalLicenseInfoWithFilter1.DriverLicense.DriverInfo.PersonID);
            frmDriverLicensesHistory.ShowDialog();
        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frmShowLicenseInfo = new frmShowLicenseInfo(_LicenseID);
            frmShowLicenseInfo.ShowDialog();
        }
    }
}
