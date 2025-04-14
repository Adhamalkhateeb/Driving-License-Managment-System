using DataLayer;
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
    public partial class frmAddNewInternationalLicenseApplication : Form
    {

        private int _internationallicenseID = -1;

        clsInternationalLicense _internationalLicense;
        public frmAddNewInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        public frmAddNewInternationalLicenseApplication(int LicenseID)
        {

            InitializeComponent();
            ctrlLocalLicenseInfoWithFilter1.LoadLicenseInfo(LicenseID);
            ctrlLocalLicenseInfoWithFilter1.FilterEnabled = false;
        }

        private void ctrlLocalLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int LicenseID = obj;
            lblLocalLicenseID.Text = LicenseID.ToString();

  
            if (ctrlLocalLicenseInfoWithFilter1.DriverLicense.LicenseClassID != 3)
            {
                MessageBox.Show("Can't Issue International License till you Have Local License from Ordinary Driving License Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }
            else
            {
                btnSave.Enabled = true;
                llblShowLicenseHistory.Enabled = true;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void frmAddNewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            lblAppDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            lblIssueDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToString("dd/MMM/yyyy");
            lblFees.Text = clsApplicationTypes.Find((int)clsApplication.enApplicationType.NewInternationalLicense).Fees.ToString("0.00");
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            ctrlLocalLicenseInfoWithFilter1.FilterFocus();

        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicensesHistory frmDriverLicensesHistory = new frmDriverLicensesHistory(ctrlLocalLicenseInfoWithFilter1.DriverLicense.DriverInfo.PersonID);
            frmDriverLicensesHistory.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = clsInternationalLicense.GetActiveLInternationalLicenseByDriverID(ctrlLocalLicenseInfoWithFilter1.DriverLicense.DriverID);
            if (InternationalLicenseID != -1)
            {
                MessageBox.Show("Driver has already active International License with ID [" + InternationalLicenseID + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                llblShowLicenseInfo.Enabled = true;
                _internationallicenseID = InternationalLicenseID;
                return;
            }


            _internationalLicense = new clsInternationalLicense();

            _internationalLicense.DriverID = ctrlLocalLicenseInfoWithFilter1.DriverLicense.DriverID;
            _internationalLicense.IssuedUsingLocalLicenseID = ctrlLocalLicenseInfoWithFilter1.DriverLicense.LicenseID;
            _internationalLicense.ApplicantPersonID = ctrlLocalLicenseInfoWithFilter1.DriverLicense.DriverInfo.PersonID;
            _internationalLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _internationalLicense.PaidFees = Convert.ToSingle(lblFees.Text);

            if (MessageBox.Show("Are You sure you Want to issue the license ?", "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (_internationalLicense.Save())
                {
                    MessageBox.Show($"International License Issued Successfully with ID [{_internationalLicense.InternationalLicenseID}]", "License Issued",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                    llblShowLicenseInfo.Enabled = true;
                    lblAppID.Text = _internationalLicense.ApplicationID.ToString();
                    lblInternationalLIcenseID.Text = _internationalLicense.InternationalLicenseID.ToString();
                    _internationallicenseID = _internationalLicense.InternationalLicenseID;
                }
                else
                {
                    MessageBox.Show($"Error Happend while International License ", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ctrlLocalLicenseInfoWithFilter1.DriverLicense != null)
            {
                frmShowInternationalDriverLicenseInfo frmShowInternationalDriverLicenseInfo = new frmShowInternationalDriverLicenseInfo(_internationallicenseID);
                frmShowInternationalDriverLicenseInfo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose Driver First","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlLocalLicenseInfoWithFilter1.FilterFocus();
                return;

            }
        }
    }
}
