using System.Windows.Forms;

namespace DVLD
{
    public partial class FrmMain : Form
    {
        private frmLogin _frmLogin;
        public FrmMain(frmLogin frmLogin)
        {
            InitializeComponent();
            _frmLogin = frmLogin;
        }



        frmManagePeople managePeople = new frmManagePeople();
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (managePeople.IsDisposed)
            {
                managePeople = new frmManagePeople();
            }

            managePeople.MdiParent = this;
            managePeople.Dock = DockStyle.Fill;

            managePeople.Show();


        }

        private void btnApplication_Click(object sender, EventArgs e)
        {

        }

        frmLocalDrivingLicenseApplication frmLocalDrivingLicenseApplication = new frmLocalDrivingLicenseApplication();

        private void btnlocalDriverLicenseApplication_Click(object sender, EventArgs e)
        {
            if (frmLocalDrivingLicenseApplication.IsDisposed)
            {
                frmLocalDrivingLicenseApplication = new frmLocalDrivingLicenseApplication();
            }
            frmLocalDrivingLicenseApplication.MdiParent = this;
            frmLocalDrivingLicenseApplication.Dock = DockStyle.Fill;
            frmLocalDrivingLicenseApplication.Show();

        }
        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmLocalDrivingLicenseApplication.IsDisposed)
            {
                frmLocalDrivingLicenseApplication = new frmLocalDrivingLicenseApplication();
            }
            frmLocalDrivingLicenseApplication.MdiParent = this;
            frmLocalDrivingLicenseApplication.Dock = DockStyle.Fill;
            frmLocalDrivingLicenseApplication.Show();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        frmManageUsers manageUsers = new frmManageUsers();
        private void btnusers_Click(object sender, EventArgs e)
        {
            if (manageUsers.IsDisposed)
            {
                manageUsers = new frmManageUsers();
            }
            manageUsers.MdiParent = this;
            manageUsers.Dock = DockStyle.Fill;
            manageUsers.Show();
        }


        private void btnCurrentUserInfo_Click(object sender, EventArgs e)
        {
            frmShowUserDetails userDetails = new frmShowUserDetails(clsGlobal.CurrentUser.UserID);
            userDetails.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword changeUserPassword = new frmChangeUserPassword(clsGlobal.CurrentUser.UserID);
            changeUserPassword.ShowDialog();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            _frmLogin.Show();
            this.Close();


        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnManageApTypes_Click(object sender, EventArgs e)
        {
            frmApplicationTypes frmApplicationTypes = new frmApplicationTypes();
            frmApplicationTypes.ShowDialog();
        }

        private void btnManageTestTypes_Click(object sender, EventArgs e)
        {

            frmTestTypes frmTestTypes = new frmTestTypes();
            frmTestTypes.ShowDialog();
        }




        private void btnLocalLicense_Click(object sender, EventArgs e)
        {
            frmNew_EditLocalDrivingLicense frmNew_EditLocalDrivingLicense = new frmNew_EditLocalDrivingLicense();
            frmNew_EditLocalDrivingLicense.ShowDialog();
        }


        frmManageDrivers frmManageDrivers = new frmManageDrivers();
        private void btnDrivers_Click(object sender, EventArgs e)
        {
            if (frmManageDrivers.IsDisposed)
            {
                frmManageDrivers = new frmManageDrivers();
            }

            frmManageDrivers.MdiParent = this;
            frmManageDrivers.Dock = DockStyle.Fill;
            frmManageDrivers.Show();

        }

        frmManageInternationlLicenseApplications frmManageInternationalLicenses = new frmManageInternationlLicenseApplications();
        private void btnInternationalDriverLicenseApplication_Click(object sender, EventArgs e)
        {
            if (frmManageInternationalLicenses.IsDisposed)
            {
                frmManageInternationalLicenses = new frmManageInternationlLicenseApplications();
            }

            frmManageInternationalLicenses.MdiParent = this;
            frmManageInternationalLicenses.Dock = DockStyle.Fill;
            frmManageInternationalLicenses

                .Show();
        }

        private void btnInternationalLicense_Click(object sender, EventArgs e)
        {
            frmAddNewInternationalLicenseApplication frmAddNewInternationalLicenseApplication = new frmAddNewInternationalLicenseApplication();
            frmAddNewInternationalLicenseApplication.ShowDialog();
        }

        private void btnRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            frmRenewLicneseApplication frm = new frmRenewLicneseApplication();
            frm.ShowDialog();
        }

        private void btnReplacmentLostOrDamagedLicense_Click(object sender, EventArgs e)
        {
            frmReplacmentForLost_DamagedLicense frmReplacmentForLost_DamagedLicense = new frmReplacmentForLost_DamagedLicense();
            frmReplacmentForLost_DamagedLicense.ShowDialog();

        }

        private void btnReleaseDetainLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frmReleaseDetainedLicense = new frmReleaseDetainedLicense();
            frmReleaseDetainedLicense.ShowDialog();
        }

        private void btnDetainLicenses_Click(object sender, EventArgs e)
        {
            frmDetaineLicense frmDetaineLicense = new frmDetaineLicense();
            frmDetaineLicense.ShowDialog();
        }

        private void btnReleaseDetainedDrivingLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frmReleaseDetainedLicense = new frmReleaseDetainedLicense();
            frmReleaseDetainedLicense.ShowDialog();

        }

        frmManageDetainedLicense frmManageDetainedLicense = new frmManageDetainedLicense();
        private void btnManagedDetainedLicense_Click(object sender, EventArgs e)
        {
           if(frmManageDetainedLicense.IsDisposed)
            {
                frmManageDetainedLicense = new frmManageDetainedLicense();
            }

            frmManageDetainedLicense.MdiParent = this;
            frmManageDetainedLicense.Dock = DockStyle.Fill;
            frmManageDetainedLicense.Show();

        }
    }
}
