using DVLDBussinesLayer;
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

    public partial class frmManageUsers : Form
    {

        private DataTable _dtUsers;

        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void _RefreshUserData()
        {
            cmbFilter.SelectedIndex = 0;
            _dtUsers = clsUser.GetAllUsers();
            dgvUsers.DataSource = _dtUsers;
            lblCount.Text = "# Records  " + (dgvUsers.Rows.Count);
        }
        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _RefreshUserData();

            if (dgvUsers.Rows.Count > 0)
            {

                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 340;

                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[1].Width = 340;


                dgvUsers.Columns[2].HeaderText = "Full Name";
                dgvUsers.Columns[2].Width = 450;

                dgvUsers.Columns[3].HeaderText = "User Name";
                dgvUsers.Columns[3].Width = 340;


                dgvUsers.Columns[4].HeaderText = "Is Active";
                dgvUsers.Columns[4].Width = 340;
                dgvUsers.Columns[4].ReadOnly = true;

            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.SelectedIndex == 1 || cmbFilter.SelectedIndex == 2)
                e.Handled = !char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back);

        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbFilter.Text == "Is Active")
            {
                txtFilter.Visible   = false;
                cbActive.Visible = true;
                cbActive.SelectedIndex =0;
                cbActive.Focus();
            }
            else
            {
                cbActive.Visible = false;
                txtFilter.Visible = (cmbFilter.Text != "None");
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

            switch (cmbFilter.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "Name":
                    FilterColumn = "FullName";
                    break;
                case "User Name":
                    FilterColumn = "UserName";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtUsers.DefaultView.RowFilter = "";
                lblCount.Text = "# Records " + dgvUsers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "UserID" || FilterColumn == "PersonID")
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilter.Text.Trim());

            lblCount.Text= "# Records "  + dgvUsers.Rows.Count.ToString();

        }


        private void cbActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbActive.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dtUsers.DefaultView.RowFilter = "";
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd_UpdateUser frm = new frmAdd_UpdateUser();
            frm.ShowDialog();
            _RefreshUserData();
        }

        private void tsShowDetails_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frmShowUser = new frmShowUserDetails((int)dgvUsers.CurrentRow.Cells[0].Value);
            frmShowUser.ShowDialog();
            _RefreshUserData();

        }

        private void tsAddNew_Click(object sender, EventArgs e)
        {
            frmAdd_UpdateUser frm = new frmAdd_UpdateUser();
            frm.ShowDialog();
            _RefreshUserData();
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            frmAdd_UpdateUser frm = new frmAdd_UpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshUserData();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete User [" + dgvUsers.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                if (clsUser.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshUserData();
                }
                else
                    MessageBox.Show("User was't Deleted because it has data Linked to it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword frmuserPassword = new frmChangeUserPassword((int)dgvUsers.CurrentRow.Cells[0].Value);
            frmuserPassword.ShowDialog();
            _RefreshUserData();

        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUser _user = clsUser.FindByPersonD((int)dgvUsers.CurrentRow.Cells[0].Value);
            if (_user == null)
            {
                MessageBox.Show($"Can't Find User With ID {_user.UserID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(_user.Person.Email))
            {
                string recepitent = "mailto:" + _user.Person.Email;

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = recepitent,
                    UseShellExecute = true

                });
            }
            else
            {
                MessageBox.Show($"Person {dgvUsers.CurrentRow.Cells[0].Value?.ToString()} does't set email for him", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void tsPhone_Click(object sender, EventArgs e)
        {
            clsUser _user = clsUser.FindByPersonD((int)dgvUsers.CurrentRow.Cells[0].Value);

            if (_user == null)
            {
                MessageBox.Show($"Can't Find User With ID {_user.UserID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(_user.Person.Phone, "Calling Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmShowUserDetails frmShowUser = new frmShowUserDetails((int)dgvUsers.CurrentRow.Cells[0].Value);
            frmShowUser.ShowDialog();
            _RefreshUserData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
