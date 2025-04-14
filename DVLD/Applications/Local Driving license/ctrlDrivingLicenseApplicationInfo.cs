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
    public partial class ctrlDrivingLicenseApplicationInfo : UserControl
    {
        clsLocalDrivingLicenseApplication _LocalLicenseApplication;
        private int _LocalDrivngLicenseApplicationID = -1;
        private int _LicenseID = -1;

        public int LocalDrivngLicenseApplicationID
        {
            get { return _LocalDrivngLicenseApplicationID; }
        }
        public ctrlDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        private void _FillApplicationsInfo()
        {
            _LocalDrivngLicenseApplicationID = _LocalLicenseApplication.LocalDrivingLicenseAppID;
            _LicenseID = _LocalLicenseApplication.GetActiveLicenseID();

            if (_LicenseID != -1)
            {
                llblLicenseInfo.Visible = true;
                pbLicenseInfo.Visible = true;
            }

            lblDrivingLicenseIAppID.Text = _LocalLicenseApplication.LocalDrivingLicenseAppID.ToString();
            lblAppliedLicense.Text = _LocalLicenseApplication.LicenseClass.ClassName;
            lblPassedTests.Text = clsTest.GetPassedTestCount(LocalDrivngLicenseApplicationID).ToString() + " / 3";
            ctrlApplicationBasicInfo1.LoadApplicationInfo(_LocalLicenseApplication.ApplicationID);

        }

        public void LoadApplicationInfoByLocalDrivingAppID(int LocalLicenseApplicationID)
        {
            _LocalLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseID(LocalLicenseApplicationID);

            if (_LocalLicenseApplication == null)
            {
                ResetDefaultValue();
                MessageBox.Show($"No Driving License Application With ID Number {_LocalDrivngLicenseApplicationID} is Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillApplicationsInfo();
        }

        public void LoadApplicationInfoByAapplicationID(int ApplicationID)
        {

            _LocalLicenseApplication = clsLocalDrivingLicenseApplication.FindByApplicationID(ApplicationID);

            if (_LocalLicenseApplication == null)
            {
                ResetDefaultValue();
                MessageBox.Show($"No Driving License Application With ID Number {_LocalDrivngLicenseApplicationID} is Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillApplicationsInfo();
        }
        public void ResetDefaultValue()
        {
            lblAppliedLicense.Text = lblDrivingLicenseIAppID.Text = lblPassedTests.Text = "[????]";
        }

        private void llblLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frmShowLicenseInfo = new frmShowLicenseInfo(_LocalDrivngLicenseApplicationID);
            frmShowLicenseInfo.ShowDialog();
        }
    }
}
