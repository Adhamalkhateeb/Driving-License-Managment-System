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
    public partial class frmTestTypes : Form
    {
        private DataTable _dtAllTestTypes;
        public frmTestTypes()
        {
            InitializeComponent();
        }

        private void frmTestTypes_Load(object sender, EventArgs e)
        {
            _dtAllTestTypes = clsTestTypes.GetAllTestTypes();
            dgvTestTypes.DataSource = _dtAllTestTypes;
            lblCount.Text = "# Records " + dgvTestTypes.Rows.Count;

            if (dgvTestTypes.Rows.Count > 0)
            {
                dgvTestTypes.Columns[0].HeaderText = "Test ID";
                dgvTestTypes.Columns[0].Width = 130;

                dgvTestTypes.Columns[1].HeaderText = "Test Title";
                dgvTestTypes.Columns[1].Width = 320;

                dgvTestTypes.Columns[2].HeaderText = "Test Descreption";
                dgvTestTypes.Columns[2].Width = 532;

                dgvTestTypes.Columns[3].HeaderText = "Test Fees";
                dgvTestTypes.Columns[3].Width = 150;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTestTypes frmUpdateTestTypes = new frmUpdateTestTypes((int)dgvTestTypes.CurrentRow.Cells[0].Value);
            frmUpdateTestTypes.ShowDialog();
            frmTestTypes_Load(null, null);

        }
    }
}
