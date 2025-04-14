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
    public partial class frmManageDrivers : Form
    {
        private DataTable _dtAllDrivers;
        public frmManageDrivers()
        {
            InitializeComponent();
        }


        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            cmbFilter.SelectedIndex = 0;
            _dtAllDrivers = clsDriver.GetAllDrivers();
            dgvDrivers.DataSource = _dtAllDrivers;

            lblCount.Text = "# Records " + dgvDrivers.Rows.Count;

            if (dgvDrivers.Rows.Count > 0)
            {
                dgvDrivers.Columns[0].HeaderText = "Driver ID";
                dgvDrivers.Columns[0].Width = 200;

                dgvDrivers.Columns[1].HeaderText = "Person ID";
                dgvDrivers.Columns[1].Width = 200;

                dgvDrivers.Columns[2].HeaderText = "National Number";
                dgvDrivers.Columns[2].Width = 300;

                dgvDrivers.Columns[3].HeaderText = "Full Name";
                dgvDrivers.Columns[3].Width = 450;

                dgvDrivers.Columns[4].HeaderText = "Creation Date";
                dgvDrivers.Columns[4].Width = 400;

                dgvDrivers.Columns[5].HeaderText = "Active Licenses";
                dgvDrivers.Columns[5].Width = 255;


            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = (cmbFilter.Text != "None");

            if (txtFilter.Visible)
            {
                txtFilter.Text = "";
                txtFilter.Focus();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterCoulmn = "";

            switch (cmbFilter.Text)
            {
                case "Driver ID":
                    FilterCoulmn = "DriverID";
                    break;
                case "Person ID":
                    FilterCoulmn = "PersonID";
                    break;
                case "National No.":
                    FilterCoulmn = "NationalNo";
                    break;
                case "Full Name":
                    FilterCoulmn = "FullName";
                    break;
                default:
                    FilterCoulmn = "None";
                    break;

            }

            if (string.IsNullOrEmpty(txtFilter.Text.Trim()))
            {
                _dtAllDrivers.DefaultView.RowFilter = "";
                lblCount.Text = "# Records " + dgvDrivers.Rows.Count.ToString();
                return;
            }

            if (FilterCoulmn == "DriverID" || FilterCoulmn == "PersonID")
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterCoulmn, txtFilter.Text.Trim());
            else
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterCoulmn, txtFilter.Text.Trim());

            lblCount.Text= "# Records "  + dgvDrivers.Rows.Count.ToString();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.SelectedIndex == 1 || cmbFilter.SelectedIndex == 2)
                e.Handled =!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo((int)dgvDrivers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmManageDrivers_Load(null, null);
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvDrivers.CurrentRow.Cells[1].Value;
            int LicenseID = clsDriverLicense.GetActiveLicenseIDByPersonID(PersonID, 3);

            if (LicenseID == -1)
            {
                MessageBox.Show("Can't Make International License for That person\n [Must have active license from Ordinary License Type First]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmAddNewInternationalLicenseApplication frmAddNewInternationalLicenseApplication = new frmAddNewInternationalLicenseApplication(LicenseID);
            frmAddNewInternationalLicenseApplication.ShowDialog();



        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDriverLicensesHistory frm = new frmDriverLicensesHistory((int)dgvDrivers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }
    }
}
