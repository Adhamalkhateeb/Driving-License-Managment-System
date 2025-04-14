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
    public partial class frmManageInternationlLicenseApplications : Form
    {
        private DataTable _dtAllInternationLicenes;
        public frmManageInternationlLicenseApplications()
        {
            InitializeComponent();
        }

        private void frmManageInternationlLicenseApplications_Load(object sender, EventArgs e)
        {
            _dtAllInternationLicenes = clsInternationalLicense.GetAllInternationalLicenses();
            dgvInternationalDrivingLicenseApplications.DataSource = _dtAllInternationLicenes;
            lblCount.Text = "# Records " + dgvInternationalDrivingLicenseApplications.Rows.Count;

            if (dgvInternationalDrivingLicenseApplications.Rows.Count > 0)
            {
                dgvInternationalDrivingLicenseApplications.Columns[0].HeaderText = "Inter. License ID";
                dgvInternationalDrivingLicenseApplications.Columns[0].Width = 250;

                dgvInternationalDrivingLicenseApplications.Columns[1].HeaderText = "Application ID";
                dgvInternationalDrivingLicenseApplications.Columns[1].Width = 250;

                dgvInternationalDrivingLicenseApplications.Columns[2].HeaderText = "Driver ID";
                dgvInternationalDrivingLicenseApplications.Columns[2].Width = 250;

                dgvInternationalDrivingLicenseApplications.Columns[3].HeaderText = "Issued By local License ID";
                dgvInternationalDrivingLicenseApplications.Columns[3].Width = 270;

                dgvInternationalDrivingLicenseApplications.Columns[4].HeaderText = "Issue Date";
                dgvInternationalDrivingLicenseApplications.Columns[4].Width = 270;

                dgvInternationalDrivingLicenseApplications.Columns[5].HeaderText = "Expiration Date";
                dgvInternationalDrivingLicenseApplications.Columns[5].Width = 270;

                dgvInternationalDrivingLicenseApplications.Columns[6].HeaderText = "Is Active";
                dgvInternationalDrivingLicenseApplications.Columns[6].Width = 245;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "Activity")
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

            _dtAllInternationLicenes.DefaultView.RowFilter = "";
            lblCount.Text = "# Record " + dgvInternationalDrivingLicenseApplications.Rows.Count.ToString();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = string.Empty;

            switch (cbFilter.Text)
            {
                case "Inter. License ID":
                    FilterColumn = "InternationalLicenseID";
                    break;
                case "Application ID":
                    FilterColumn = "ApplicationID";
                    break;
                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;
                case "Local License ID":
                    FilterColumn = "IssuedUsingLocalLicenseID";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                _dtAllInternationLicenes.DefaultView.RowFilter = "";
                lblCount.Text = "# Records " + _dtAllInternationLicenes.Rows.Count.ToString();
                return;
            }

            if (FilterColumn != "None")
                _dtAllInternationLicenes.DefaultView.RowFilter = string.Format("[{0}] = {1} ", FilterColumn, txtFilter.Text.Trim());

            lblCount.Text= "# Records "  + dgvInternationalDrivingLicenseApplications.Rows.Count.ToString();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbStatus.Text switch
            {
                "Active" => "1",
                "In Active" => "0",
                _ => "All"

            };


            if (FilterValue == "All")
                _dtAllInternationLicenes.DefaultView.RowFilter = "";
            else
                _dtAllInternationLicenes.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text != "None" || cbFilter.Text != "Activity")
                e.Handled = !char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back);
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsInternationalLicense internationalLicense = clsInternationalLicense.Find((int)dgvInternationalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frmShowPersonInfo frmShowPersonInfo = new frmShowPersonInfo(internationalLicense.ApplicantPersonID);
            frmShowPersonInfo.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmShowInternationalDriverLicenseInfo frmShowLicenseInfo = new frmShowInternationalDriverLicenseInfo((int)dgvInternationalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frmShowLicenseInfo.ShowDialog();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsInternationalLicense internationalLicense = clsInternationalLicense.Find((int)dgvInternationalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frmDriverLicensesHistory frm = new frmDriverLicensesHistory(internationalLicense.ApplicantPersonID);
            frm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewInternationalLicenseApplication frm = new frmAddNewInternationalLicenseApplication();
            frm.ShowDialog();

            frmManageInternationlLicenseApplications_Load(null, null);
        }
    }
}
