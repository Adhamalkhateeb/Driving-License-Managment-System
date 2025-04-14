using DVLD.Properties;
using DVLDBussinesLibary;
using Microsoft.VisualBasic;
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
    public partial class ctrlInternationalLicenseInfo : UserControl
    {
        private int _internationalLicenseId =-1;
        private clsInternationalLicense _internationalLicenseinfo;
        public ctrlInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        public void ResetData()
        {
            lblInternationlLicenseID.Text = lblName.Text = lblName.Text = lblGendor.Text  = lblApplicationID.Text = lblLicenseID.Text = lblIsActive.Text =
                lblDriverID.Text ="[????]";
            lblIssueDate.Text = lblExpirationDate.Text = lblDateOfBirth.Text = "[??/??/??]";
        }

        public void LoadInfo(int InternationalLicenseID)
        {
            _internationalLicenseId=InternationalLicenseID;
            _internationalLicenseinfo = clsInternationalLicense.Find(InternationalLicenseID);

            if (_internationalLicenseinfo == null)
            {
                MessageBox.Show($"There Is No International License With ID [{InternationalLicenseID}]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillInternLicenseInfo();
        }

        private void _FillInternLicenseInfo()
        {
            lblName.Text = _internationalLicenseinfo.ApplicantFullName;
            lblInternationlLicenseID.Text= _internationalLicenseinfo.InternationalLicenseID.ToString();
            lblLicenseID.Text = _internationalLicenseinfo.IssuedUsingLocalLicenseID.ToString();
            lblNationalNo.Text = _internationalLicenseinfo.DriverInfo.PersonInfo.NationalNumber;

            if (_internationalLicenseinfo.DriverInfo.PersonInfo.Gendor == 0)
                lblGendor.Text = "Male";
            else
                lblGendor.Text = "Female";

            lblIssueDate.Text = _internationalLicenseinfo.IssueDate.ToString("dd/MMM/yyyy");
            lblApplicationID.Text =_internationalLicenseinfo.ApplicationID.ToString();

            if (_internationalLicenseinfo.IsActive)
                lblIsActive.Text = "Acitve";
            else
                lblIsActive.Text = "InActive";

            lblDateOfBirth.Text = _internationalLicenseinfo.DriverInfo.PersonInfo.DateOFBirth.ToString("dd/MMM/yyyy");
            lblDriverID.Text = _internationalLicenseinfo.DriverID.ToString();
            lblExpirationDate.Text = _internationalLicenseinfo.ExpirationDate.ToString("dd/MMM/yyyy");


            _LoadPersonImage();
        }

        private void _LoadPersonImage()
        {
            string ImagePath = _internationalLicenseinfo.DriverInfo.PersonInfo.ImagePath;
            if (!string.IsNullOrEmpty(ImagePath))
            {
                if(File.Exists(ImagePath))
                {
                    pbDriverImage.ImageLocation = ImagePath;
                }
                else
                    MessageBox.Show($"Could't Find image File Path {ImagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (_internationalLicenseinfo.DriverInfo.PersonInfo.Gendor == 0)
                    pbDriverImage.Image = Resources.Anonymous_Man;
                else
                    pbDriverImage.Image= Resources.Anonymous_Woman;
            }
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
