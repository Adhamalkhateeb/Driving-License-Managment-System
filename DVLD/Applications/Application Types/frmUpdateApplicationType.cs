using DVLDBussinesLibary;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD.frmAdd_UpdatePerson;

namespace DVLD
{
    public partial class frmUpdateApplicationType : Form
    {
        clsApplicationTypes _ApplicationType;
        int _ApplicationID = -1;
        public frmUpdateApplicationType(int ApplicationID)
        {
            InitializeComponent();
            _ApplicationID = ApplicationID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                _ApplicationType.ApplicationTypeTitle = txtTitle.Text.Trim();
                _ApplicationType.Fees = Convert.ToSingle(txtFees.Text.Trim());

                if (_ApplicationType.UpdateApplication())
                {
                    MessageBox.Show("Application Details Updated Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Happend while Updating", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == (char)Keys.Back) && !(char.IsDigit(e.KeyChar)) && e.KeyChar != '.';
        }

        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {

            _ApplicationType = clsApplicationTypes.Find(_ApplicationID);

            if (_ApplicationType == null)
            {
                MessageBox.Show($"No Application Type with ID {_ApplicationID} Is Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblApplicationTypeID.Text = _ApplicationID.ToString();
            txtTitle.Text = _ApplicationType.ApplicationTypeTitle;
            txtFees.Text = _ApplicationType.Fees.ToString();
            txtTitle.Focus();

        }


        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {

                e.Cancel = false;
                errorProvider1.SetError(txtTitle, "this Field can't be Empty");
            }
            else
                errorProvider1.SetError(txtTitle, null);

        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {

                e.Cancel = false;
                errorProvider1.SetError(txtFees, "this Field can't be Empty");
            }
            else
                errorProvider1.SetError(txtFees, null);
        }
    }
}
