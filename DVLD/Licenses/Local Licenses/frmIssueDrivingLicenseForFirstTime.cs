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
    public partial class frmIssueDrivingLicenseForFirstTime : Form
    {
        private int _LocalDrivingLicenseApplicationID;
        private clsLocalDrivingLicenseApplication _localDrivingLicenseApplication;


        public frmIssueDrivingLicenseForFirstTime(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int LicenseID = _localDrivingLicenseApplication.IssueLicenseForTheFirtTime(txtNotes.Text.Trim(), clsGlobal.CurrentUser.UserID);




            if (LicenseID != -1)
            {
                MessageBox.Show($"License Issued Successfully With ID [{LicenseID}]", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show($"Error: Failed to Add New Licnese to Driver{LicenseID} ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frmIssueDrivingLicenseForFirstTime_Load(object sender, EventArgs e)
        {
            txtNotes.Focus();
            _localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseID(_LocalDrivingLicenseApplicationID);

            if(_localDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: Can't Find Application with ID [" + _LocalDrivingLicenseApplicationID + "] ","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if(!_localDrivingLicenseApplication.PassedAllTests())
            {
                MessageBox.Show("Error: Person Should Pass All tests first to Issue License ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if(_localDrivingLicenseApplication.IsLicenseIssued())
            {
                MessageBox.Show("Person Has already License  Can't Issue one more ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingLicenseApplicationID);
        }
    }
}
