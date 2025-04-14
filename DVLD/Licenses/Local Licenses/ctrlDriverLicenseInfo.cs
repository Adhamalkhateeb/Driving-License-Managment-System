using DVLD.Properties;
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
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        private int _licenseID = -1;
        private clsDriverLicense _driverLicense;



        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }

        public int LicenseID { get { return _licenseID; } }

        public clsDriverLicense SelectedLicenseInfo { get { return _driverLicense; } }

        public void ResetData()
        {
            lblClass.Text = lblName.Text = lblLicenseID.Text = lblNationalNo.Text = lblGendor.Text =
                lblIssueDate.Text = lblIssueReason.Text = lblNotes.Text = lblIsActive.Text = lblDateOfBirth.Text =
                lblDriverID.Text = lblExpirationDate.Text = lblIsDetained.Text = "[????]";
        }

        public void LoadLicenseInfo(int LicenseID)
        {

            _driverLicense = clsDriverLicense.FindLicense(LicenseID);

            if (_driverLicense == null)
            {
                MessageBox.Show($"Can't Find License With ID [{LicenseID}] Please enter another number or go on Issue License Process", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _licenseID = -1;
                return;
            }
            _licenseID = LicenseID;


            _FillLicenseInfo();



        }

        private void _FillLicenseInfo()
        {

            lblClass.Text = _driverLicense.LicenseClassInfo.ClassName;
            lblName.Text = _driverLicense.DriverInfo.PersonInfo.FullName;
            lblLicenseID.Text = _driverLicense.LicenseID.ToString();
            lblNationalNo.Text = _driverLicense.DriverInfo.PersonInfo.NationalNumber;

            lblGendor.Text = _driverLicense.DriverInfo.PersonInfo.Gendor == 0 ? "Male" : "Female";

            lblIssueDate.Text = _driverLicense.IssueDate.ToString("dd/MMM/yyyy");
            lblIssueReason.Text = _driverLicense.IssueReasonText;
            lblNotes.Text = string.IsNullOrEmpty(_driverLicense.Notes) ? "No Notes" : _driverLicense.Notes;
            lblIsActive.Text = _driverLicense.IsActive ? "Yes" : "No";

            lblDateOfBirth.Text = _driverLicense.DriverInfo.PersonInfo.DateOFBirth.ToString("dd/MMM/yyyy");
            lblDriverID.Text = _driverLicense.DriverID.ToString();
            lblExpirationDate.Text = _driverLicense.ExpirationDate.ToString("dd/MMM/yyyy");

            lblIsDetained.Text = _driverLicense.IsDetained ? "Yes" : "No" +
                "";

            _LoadImage();
        }

        private void _LoadImage()
        {
            string ImagePath = _driverLicense.DriverInfo.PersonInfo.ImagePath;
            if (!string.IsNullOrEmpty(ImagePath))
            {
                if (File.Exists(ImagePath))
                    pbDriverImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show($"Could't Find image File Path {ImagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (_driverLicense.DriverInfo.PersonInfo.Gendor == 0)
                    pbDriverImage.Image = Resources.Anonymous_Man;
                else
                    pbDriverImage.Image= Resources.Anonymous_Woman;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
