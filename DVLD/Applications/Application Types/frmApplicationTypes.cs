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
    public partial class frmApplicationTypes : Form
    {

        private DataTable _dtAllApplicationTypes;
        public frmApplicationTypes()
        {
            InitializeComponent();
        }


        private void frmApplicationTypes_Load(object sender, EventArgs e)
        {
            _dtAllApplicationTypes = clsApplicationTypes.GetAllApplicationTypes();
            dgvApplicationTypes.DataSource = _dtAllApplicationTypes;
            lblCount.Text = "# Records " + dgvApplicationTypes.Rows.Count;


            if (dgvApplicationTypes.Rows.Count > 0)
            {
                dgvApplicationTypes.Columns[0].HeaderText = "Application ID";
                dgvApplicationTypes.Columns[0].Width = 240;

                dgvApplicationTypes.Columns[1].HeaderText = "Application Title";
                dgvApplicationTypes.Columns[1].Width = 600;

                dgvApplicationTypes.Columns[2].HeaderText = "Application Fees";
                dgvApplicationTypes.Columns[2].Width = 292;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationType frmUpdateApplicationType = new frmUpdateApplicationType((int) dgvApplicationTypes.CurrentRow.Cells[0].Value);
            frmUpdateApplicationType.ShowDialog();
            frmApplicationTypes_Load(null, null);
        }
    }
}
