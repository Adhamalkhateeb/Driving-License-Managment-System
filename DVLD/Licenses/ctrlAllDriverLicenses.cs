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
    public partial class ctrlAllDriverLicenses : UserControl
    {
        private int _driverID = -1;
        private clsDriver _driver;
        private DataTable _dtAllLocalLicenses;
        private DataTable _dtAllInternationalLicenses;
        private int _DriverID = -1;
        public ctrlAllDriverLicenses()
        {
            InitializeComponent();
        }

        private void _LoadLoaclDriverLicenses()
        {
            _dtAllLocalLicenses = clsDriverLicense.GetAllDriverLicense(_driverID);
            dgvLocalLicenses.DataSource = _dtAllLocalLicenses;

            if (dgvLocalLicenses.Rows.Count > 0)
            {
                dgvLocalLicenses.Columns[0].HeaderText = "L.D.L ID";
                dgvLocalLicenses.Columns[0].Width = 115;

                dgvLocalLicenses.Columns[1].HeaderText = "App ID";
                dgvLocalLicenses.Columns[1].Width = 100;

                dgvLocalLicenses.Columns[2].HeaderText = "Class Name";
                dgvLocalLicenses.Columns[2].Width = 300;

                dgvLocalLicenses.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicenses.Columns[3].Width = 170;

                dgvLocalLicenses.Columns[4].HeaderText = "Expiration Date";
                dgvLocalLicenses.Columns[4].Width = 190;

                dgvLocalLicenses.Columns[5].HeaderText = "Is Active";
                dgvLocalLicenses.Columns[5].Width = 100;
            }

            lblLocalCount.Text = "# Record " + dgvLocalLicenses.Rows.Count;
        }

        private void _LoadinternationalLicensesInfo()
        {
            _dtAllInternationalLicenses = clsDriverLicense.GetAllInternationalLicense(_driverID);


            dgvInternationalLicenses.DataSource= _dtAllInternationalLicenses;

            lblInternationalCount.Text = "# Records " + dgvInternationalLicenses.Rows.Count;

            if (dgvInternationalLicenses.Rows.Count > 0)
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "International D.L ID";
                dgvInternationalLicenses.Columns[0].Width = 235;

                dgvInternationalLicenses.Columns[1].HeaderText = "App ID";
                dgvInternationalLicenses.Columns[1].Width = 100;

                dgvInternationalLicenses.Columns[2].HeaderText = "License ID";
                dgvInternationalLicenses.Columns[2].Width = 180;

                dgvInternationalLicenses.Columns[3].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[3].Width = 170;

                dgvInternationalLicenses.Columns[4].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[4].Width = 190;

                dgvInternationalLicenses.Columns[5].HeaderText = "Is Active";
                dgvInternationalLicenses.Columns[5].Width = 100;
            }
        }
        public void LoadDriverLicenses(int DriverID)
        {
            _driverID = DriverID;
            _driver = clsDriver.FindByID(_driverID);

            if (_driver == null)
            {
                MessageBox.Show("There is No driver With ID [" + _driverID +"]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadLoaclDriverLicenses();
            _LoadinternationalLicensesInfo();

        }

        public void LoadDriverLicenesByPersonID(int PersonID)
        {
            _driver = clsDriver.FindByPersonID(PersonID);



            if (_driver == null)
            {
                MessageBox.Show("There is No Driver With PersonID [" + PersonID +"]  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _driverID = _driver.DriverID;

            _LoadinternationalLicensesInfo();
            _LoadLoaclDriverLicenses();

        }


        private void dgvLocalLicenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void clear()
        {
            _dtAllInternationalLicenses.Clear();
            _dtAllLocalLicenses.Clear();
        }

        private void showLicneseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicenseInfo frmShowLicenseInfo = new frmShowLicenseInfo((int)dgvLocalLicenses.CurrentRow.Cells[0].Value);
            frmShowLicenseInfo.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Internationl Licenses Info will be Here");
        }
    }
}
