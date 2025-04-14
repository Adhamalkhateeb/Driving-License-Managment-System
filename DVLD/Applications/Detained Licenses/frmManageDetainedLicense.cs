using DVLDBussinesLibary;
using PeopleBusinessLayer;
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
    public partial class frmManageDetainedLicense : Form
    {
        private DataTable _dtAllDetainedLicense;
        public frmManageDetainedLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageDetainedLicense_Load(object sender, EventArgs e)
        {
            _dtAllDetainedLicense = clsDetainLicense.GetAllDetainedLicense();
            dgvDetainedLicenses.DataSource = _dtAllDetainedLicense;

            lblCount.Text = "# Record " + dgvDetainedLicenses.Rows.Count;

            if (dgvDetainedLicenses.Rows.Count > 0)
            {
                dgvDetainedLicenses.Columns[0].HeaderText = "Detain ID";
                dgvDetainedLicenses.Columns[0].Width = 170;

                dgvDetainedLicenses.Columns[1].HeaderText = "License ID";
                dgvDetainedLicenses.Columns[1].Width = 170;

                dgvDetainedLicenses.Columns[2].HeaderText = "Detain Date";
                dgvDetainedLicenses.Columns[2].Width = 230;

                dgvDetainedLicenses.Columns[3].HeaderText = "Released";
                dgvDetainedLicenses.Columns[3].Width = 180;

                dgvDetainedLicenses.Columns[4].HeaderText = "Fine Fees";
                dgvDetainedLicenses.Columns[4].Width = 200;

                dgvDetainedLicenses.Columns[5].HeaderText = "Release Date";
                dgvDetainedLicenses.Columns[5].Width = 230;

                dgvDetainedLicenses.Columns[6].HeaderText = "National No.";
                dgvDetainedLicenses.Columns[6].Width = 180;

                dgvDetainedLicenses.Columns[7].HeaderText = "Full Name";
                dgvDetainedLicenses.Columns[7].Width = 275;

                dgvDetainedLicenses.Columns[8].HeaderText = " Release App ID";
                dgvDetainedLicenses.Columns[8].Width = 170;





            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "Released")
            {
                txtFilter.Visible = false;
                cbReleased.Visible = true;

                cbReleased.SelectedIndex = 0;
                cbReleased.Focus();
            }
            else
            {
                cbReleased.Visible = false;
                txtFilter.Visible = (cbFilter.Text != "None");
                if (txtFilter.Visible)
                {
                    txtFilter.Text = "";
                    txtFilter.Focus();
                }
            }

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = string.Empty;

            switch (cbFilter.Text)
            {
                case "Detain ID":
                    FilterColumn = "DetainID";
                    break;
                case "National No.":
                    FilterColumn = "NationalNo";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Release Application ID":
                    FilterColumn = "ReleaseApplicationID";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (string.IsNullOrEmpty(txtFilter.Text) || FilterColumn == "None")
            {
                _dtAllDetainedLicense.DefaultView.RowFilter = "";
                lblCount.Text = "# Records " + _dtAllDetainedLicense.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "DetainID" || FilterColumn == "ReleaseApplicationID")
                _dtAllDetainedLicense.DefaultView.RowFilter = string.Format("[{0}] = {1} ", FilterColumn, txtFilter.Text.Trim());
            else
                _dtAllDetainedLicense.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilter.Text.Trim());

            lblCount.Text= "# Records "  + dgvDetainedLicenses.Rows.Count.ToString();
        }

        private void cbReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsReleased";

            int FilterValue = cbReleased.Text switch
            {
                "Released" => 1,
                _ => 0,
            };



            if (cbReleased.Text == "All")
                _dtAllDetainedLicense.DefaultView.RowFilter = "";
            else

                _dtAllDetainedLicense.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            frmDetaineLicense frmDetaineLicense = new frmDetaineLicense();
            frmDetaineLicense.ShowDialog();

            frmManageDetainedLicense_Load(null, null);
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frmReleaseLicense = new frmReleaseDetainedLicense();
            frmReleaseLicense.ShowDialog();

            frmManageDetainedLicense_Load(null, null);
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Detain ID" || cbFilter.Text == "Release Application ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !((char)Keys.Back == e.KeyChar);
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo((string)dgvDetainedLicenses.CurrentRow.Cells[6].Value);
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicenseInfo frmShowLicenseInfo = new frmShowLicenseInfo((int)dgvDetainedLicenses.CurrentRow.Cells[1].Value);
            frmShowLicenseInfo.ShowDialog();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPerson Person = clsPerson.Find((string)dgvDetainedLicenses.CurrentRow.Cells[6].Value);
            frmDriverLicensesHistory frm = new frmDriverLicensesHistory(Person.PersonID);
            frm.ShowDialog();

        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense((int)dgvDetainedLicenses.CurrentRow.Cells[1].Value);
            frm.ShowDialog();

            frmManageDetainedLicense_Load(null, null);
        }

        private void cmsDetainedLicenses_Opening(object sender, CancelEventArgs e)
        {
            releaseDetainedLicenseToolStripMenuItem.Enabled = (!(bool)dgvDetainedLicenses.CurrentRow.Cells[3].Value);
        }
    }
}
