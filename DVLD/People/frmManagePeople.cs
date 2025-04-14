using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleBusinessLayer;

namespace DVLD
{
    public partial class frmManagePeople : Form
    {
        private static DataTable _AllPeople;
        private DataTable _dtSelectedPeople;
        public frmManagePeople()
        {
            InitializeComponent();
        }

        public void _RefreshData()
        {
            cmbFilter.SelectedIndex =0;
            _AllPeople = clsPerson.GetAllPeople();
            _dtSelectedPeople =  _AllPeople.DefaultView.ToTable("people Table", false, "PersonID", "NationalNo", "FirstName", "SecondName",
            "ThirdName", "LastName", "Gendor", "DateOfBirth", "CountryName", "Phone", "Email");
            dgvPeople.DataSource =  _dtSelectedPeople;
            lblCount.Text = "# Records  " + (dgvPeople.Rows.Count);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd_UpdatePerson add_Update = new frmAdd_UpdatePerson();
            add_Update.ShowDialog();
            _RefreshData();
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            frmAdd_UpdatePerson add_Update = new frmAdd_UpdatePerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            add_Update.ShowDialog();
            _RefreshData();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                if (clsPerson.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshData();
                }
                else
                    MessageBox.Show("Person was't Deleted because it has data Linked to it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }



        }

        private void tsAddNew_Click(object sender, EventArgs e)
        {
            frmAdd_UpdatePerson frmAdd_Update = new frmAdd_UpdatePerson();
            frmAdd_Update.ShowDialog();
            _RefreshData();
        }

        private void tsShowDetails_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshData();

        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _RefreshData();

            if (dgvPeople.Rows.Count > 0)
            {

                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 115;

                dgvPeople.Columns[1].HeaderText = "National No.";
                dgvPeople.Columns[1].Width = 150;


                dgvPeople.Columns[2].HeaderText = "First Name";
                dgvPeople.Columns[2].Width = 150;

                dgvPeople.Columns[3].HeaderText = "Second Name";
                dgvPeople.Columns[3].Width = 150;


                dgvPeople.Columns[4].HeaderText = "Third Name";
                dgvPeople.Columns[4].Width = 150;

                dgvPeople.Columns[5].HeaderText = "Last Name";
                dgvPeople.Columns[5].Width = 150;

                dgvPeople.Columns[6].HeaderText = "Gendor";
                dgvPeople.Columns[6].Width = 110;

                dgvPeople.Columns[7].HeaderText = "Date Of Birth";
                dgvPeople.Columns[7].Width = 180;

                dgvPeople.Columns[8].HeaderText = "Nationality";
                dgvPeople.Columns[8].Width = 150;


                dgvPeople.Columns[9].HeaderText = "Phone";
                dgvPeople.Columns[9].Width = 230;


                dgvPeople.Columns[10].HeaderText = "Email";
                dgvPeople.Columns[10].Width = 270;
            }


        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string recipientEmail = dgvPeople.CurrentRow.Cells[10].Value?.ToString();
            if (!String.IsNullOrEmpty(recipientEmail))
            {

                string mailtoLink = $"mailto:{recipientEmail}";

                // Open the default email handler (which can be Gmail if configured)
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = mailtoLink,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show($"Person {dgvPeople.CurrentRow.Cells[0].Value?.ToString()} does't set email for him", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsPhone_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dgvPeople.CurrentRow.Cells[9].Value.ToString(), "Calling Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvPeople_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form frm = new frmShowPersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cmbFilter.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National Number":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gendor":
                    FilterColumn = "Gendor";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtSelectedPeople.DefaultView.RowFilter = "";
                lblCount.Text = "# Records " + dgvPeople.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID")
                _dtSelectedPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
            else
                _dtSelectedPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());

                lblCount.Text= "# Records "  + dgvPeople.Rows.Count.ToString();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.SelectedIndex == 1)
                e.Handled =!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back);
        }
    }
}
