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
    public partial class frmLocalDrivingLicenseApplication : Form
    {

        private DataTable _dtAllLocalDrivingLicenseApplications = new DataTable();
        public frmLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void frmLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _dtAllLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
            dgvLocalDrivingLicenseApplications.DataSource = _dtAllLocalDrivingLicenseApplications;
            lblCount.Text = "# Records " + _dtAllLocalDrivingLicenseApplications.Rows.Count.ToString();

            if (_dtAllLocalDrivingLicenseApplications.Rows.Count > 0)
            {
                dgvLocalDrivingLicenseApplications.Columns[0].HeaderText ="L.D.L Application ID";
                dgvLocalDrivingLicenseApplications.Columns[0].Width = 225;


                dgvLocalDrivingLicenseApplications.Columns[1].HeaderText = "Driving Class";
                dgvLocalDrivingLicenseApplications.Columns[1].Width = 360;
                dgvLocalDrivingLicenseApplications.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvLocalDrivingLicenseApplications.Columns[2].HeaderText = "National No";
                dgvLocalDrivingLicenseApplications.Columns[2].Width = 193;

                dgvLocalDrivingLicenseApplications.Columns[3].HeaderText = " Person's Full Name ";
                dgvLocalDrivingLicenseApplications.Columns[3].Width = 330;

                dgvLocalDrivingLicenseApplications.Columns[4].HeaderText = "Application Date";
                dgvLocalDrivingLicenseApplications.Columns[4].Width = 320;


                dgvLocalDrivingLicenseApplications.Columns[5].HeaderText = "Passed Tests";
                dgvLocalDrivingLicenseApplications.Columns[5].Width = 190;

                dgvLocalDrivingLicenseApplications.Columns[6].HeaderText = "Application Status";
                dgvLocalDrivingLicenseApplications.Columns[6].Width = 191;

            }




        }


        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "Status")
            {
                txtFilter.Visible = false;
                cbStatus.Visible = true;
                cbStatus.SelectedIndex = 0;
                cbStatus.Focus();
            }
            else
            {
                cbStatus.Visible = false;
                txtFilter.Visible = (cbFilter.Text != "None");
                if (txtFilter.Visible)
                {
                    txtFilter.Text = "";
                    txtFilter.Focus();
                }
            }

            _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
            lblCount.Text = "# Record " + dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = string.Empty;

            switch (cbFilter.Text)
            {
                case "L.D.L AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;
                case "National No.":
                    FilterColumn = "NationalNo";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (string.IsNullOrEmpty(txtFilter.Text) || FilterColumn == "None")
            {
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
                lblCount.Text = "# Records " + _dtAllLocalDrivingLicenseApplications.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "LocalDrivingLicenseApplicationID")
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1} ", FilterColumn, txtFilter.Text.Trim());
            else
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilter.Text.Trim());

            lblCount.Text= "# Records "  + dgvLocalDrivingLicenseApplications.Rows.Count.ToString();


        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "Status";
            string FilterValue = cbStatus.Text;


            if (FilterValue == "All")
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
            else
                
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, FilterValue);
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedIndex == 1)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNew_EditLocalDrivingLicense frmNew_EditLocalDrivingLicense = new frmNew_EditLocalDrivingLicense();
            frmNew_EditLocalDrivingLicense.ShowDialog();
            frmLocalDrivingLicenseApplication_Load(null, null);
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            frmNew_EditLocalDrivingLicense frmNew_EditLocalDrivingLicense = new frmNew_EditLocalDrivingLicense((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frmNew_EditLocalDrivingLicense.ShowDialog();
            frmLocalDrivingLicenseApplication_Load(null, null);
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication LDLApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseID((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);

            if (LDLApplication != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this Application?", "Delete Applicatioin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (LDLApplication.Delete())
                    {
                        MessageBox.Show("Application Deleted Successfully", "Delete Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmLocalDrivingLicenseApplication_Load(null, null);
                    }
                    else
                        MessageBox.Show("Error Deleting Application", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsCancel_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication LDLApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseID((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            if (LDLApplication != null)
            {
                if (MessageBox.Show("Are you sure you want to Cancel this Application?", "Cancel Applicatioin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (LDLApplication.Cancel())
                    {
                        MessageBox.Show("Application Cancelled Successfully", "Cancel Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmLocalDrivingLicenseApplication_Load(null, null);
                    }
                    else
                        MessageBox.Show("Error Cancelling Application", "Cancel Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsShowDetails_Click(object sender, EventArgs e)
        {
            frmDrivingLicenseApplicationInfo frmDrivingLicenseApplicationInfo = new frmDrivingLicenseApplicationInfo((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frmDrivingLicenseApplicationInfo.ShowDialog();

            frmLocalDrivingLicenseApplication_Load(null, null);
        }

        private void cmsApplications_Opening(object sender, CancelEventArgs e)
        {

            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseID((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);


            int TotalPassedTests = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[5].Value;
            bool LicenseExists = LocalDrivingLicenseApplication.IsLicenseIssued();

            IssueDrivingLicenseToolStripMenuItem.Enabled = (!LicenseExists && TotalPassedTests == 3);

            tsShowDrivingLicense.Enabled = LicenseExists;

            tsEdit.Enabled = !LicenseExists && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
            SchedualToolTestsStripMenuItem.Enabled = !LicenseExists;

            tsCancelApp.Enabled = (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
            tsDelete.Enabled =  (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);



            SchedualToolTestsStripMenuItem.Enabled = (TotalPassedTests < 3)
                && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);



            if (SchedualToolTestsStripMenuItem.Enabled)
            {

                bool PassedVisionTest = LocalDrivingLicenseApplication.DoesPassTest((int)clsTestTypes.enTestType.VisionTest); ;
                bool PassedWrittenTest = LocalDrivingLicenseApplication.DoesPassTest((int)clsTestTypes.enTestType.WrittenTest);
                bool PassedStreetTest = LocalDrivingLicenseApplication.DoesPassTest((int)clsTestTypes.enTestType.PracticalTest);


                scheduleVisionTestToolStripMenuItem.Enabled = !PassedVisionTest;

                scheduleWrittenTestToolStripMenuItem.Enabled = PassedVisionTest && !PassedWrittenTest;

                schedulePracticalTestToolStripMenuItem.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;

            }
        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestAppointments frmManageTest = new frmManageTestAppointments((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value,
              clsTestTypes.enTestType.VisionTest);
            frmManageTest.ShowDialog();

            frmLocalDrivingLicenseApplication_Load(null, null);
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsLocalDrivingLicenseApplication.DoesPassTest((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value,
                (int)clsTestTypes.enTestType.VisionTest))
            {
                MessageBox.Show("Person Should Pass the Vision Test First!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmManageTestAppointments frmManageTest = new frmManageTestAppointments((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value
                , clsTestTypes.enTestType.WrittenTest);
            frmManageTest.ShowDialog();

            frmLocalDrivingLicenseApplication_Load(null, null);
        }

        private void schedulePracticalTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!clsLocalDrivingLicenseApplication.DoesPassTest((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value,
               (int)clsTestTypes.enTestType.WrittenTest))
            {
                MessageBox.Show("Person Should Pass the Written Test First!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmManageTestAppointments frmManageTest = new frmManageTestAppointments((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value
                , clsTestTypes.enTestType.PracticalTest);
            frmManageTest.ShowDialog();

            frmLocalDrivingLicenseApplication_Load(null, null);
        }

        private void IssueDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueDrivingLicenseForFirstTime frmIssueDrivingLicense = new frmIssueDrivingLicenseForFirstTime((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frmIssueDrivingLicense.ShowDialog();

            frmLocalDrivingLicenseApplication_Load(null, null);
        }

        private void tsShowDrivingLicense_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

            int LicenseID = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseID(
               LocalDrivingLicenseApplicationID).GetActiveLicenseID();

            if (LicenseID != -1)
            {
                frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID);
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("No License Found!", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }



        private void showPersonLIcenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseID(
                (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frmDriverLicensesHistory frm = new frmDriverLicensesHistory((localDrivingLicenseApplication.ApplicantPersonID
                ));
            frm.ShowDialog();

            frmLocalDrivingLicenseApplication_Load(null, null);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
