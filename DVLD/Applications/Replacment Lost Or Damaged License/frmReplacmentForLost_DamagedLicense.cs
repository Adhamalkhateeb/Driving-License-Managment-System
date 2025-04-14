using DVLDBussinesLibary;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmReplacmentForLost_DamagedLicense : Form
    {
        private int _LicenseID = -1;
        public frmReplacmentForLost_DamagedLicense()
        {
            InitializeComponent();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsDriverLicense.enIssueReason IssueReason = rbDamagedLicense.Checked ? clsDriverLicense.enIssueReason.ReplacementForDamagedLicense : clsDriverLicense.enIssueReason.ReplacementForLostLicense;

            if (MessageBox.Show("Are you sure want to replace License ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsDriverLicense NewDriverLicense = ctrlLocalLicenseInfoWithFilter1.DriverLicense.Replace(IssueReason, txtNotes.Text.Trim(), clsGlobal.CurrentUser.UserID);

                if (NewDriverLicense != null)
                {
                    btnSave.Enabled = false;
                    _LicenseID = NewDriverLicense.LicenseID;
                    lblAppID.Text = NewDriverLicense.ApplicationID.ToString();
                    lblReplacedLicenseID.Text = NewDriverLicense.LicenseID.ToString();
                    MessageBox.Show($"License Replaced Successfully with ID [{_LicenseID}]", "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrlLocalLicenseInfoWithFilter1.FilterEnabled = false;

                }
                else
                {
                    MessageBox.Show("Failed to Replace License With ID [" +_LicenseID + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void frmReplacmentForLost_DamagedLicense_Load(object sender, EventArgs e)
        {
            lblAppDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            ctrlLocalLicenseInfoWithFilter1.FilterFocus();
            lblAppFees.Text = clsApplicationTypes.Find((int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense).Fees.ToString();
        }

        private void ctrlLocalLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;
            llblShowLicenseHistory.Enabled = (obj != -1);

            if (_LicenseID == -1)
                return;

            llblShowLicenseInfo.Enabled = true;

            if (!ctrlLocalLicenseInfoWithFilter1.DriverLicense.IsActive)
            {
                MessageBox.Show("License With ID [" + _LicenseID + "] Isn't Active you can Issue new one or call administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            lblOldLicenseID.Text = _LicenseID.ToString();
            txtNotes.Text = ctrlLocalLicenseInfoWithFilter1.DriverLicense.Notes;
            btnSave.Enabled = true;


        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDamagedLicense.Checked)
                lblAppFees.Text = clsApplicationTypes.Find((int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense).Fees.ToString();
            else
                lblAppFees.Text =  clsApplicationTypes.Find((int)clsApplication.enApplicationType.ReplaceLostDrivingLicense).Fees.ToString();

        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicensesHistory frmDriverLicensesHistory = new frmDriverLicensesHistory(ctrlLocalLicenseInfoWithFilter1.DriverLicense.DriverInfo.PersonID);
            frmDriverLicensesHistory.ShowDialog();
        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_LicenseID);
            frm.ShowDialog();
        }
    }
}
