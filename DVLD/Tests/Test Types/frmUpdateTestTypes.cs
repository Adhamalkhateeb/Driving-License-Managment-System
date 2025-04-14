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
    public partial class frmUpdateTestTypes : Form
    {
        private int _TestID = -1;
        private clsTestTypes _TestType;
        public frmUpdateTestTypes(int TestID)
        {
            InitializeComponent();
            _TestID = TestID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateTestTypes_Load(object sender, EventArgs e)
        {
            _TestType = clsTestTypes.Find(_TestID);


            if (_TestType == null)
            {
                MessageBox.Show($"No Test Type with ID {_TestID} Is Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblTestTypeID.Text = _TestID.ToString();
            txtTitle.Text = _TestType.TestTitle;
            txtDescription.Text = _TestType.TestDescription;
            txtFees.Text = _TestType.TestFees.ToString();
            txtTitle.Focus();
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {

                e.Cancel = false;
                errorProvider1.SetError(txtTitle, "Title can't be Empty");
            }
            else
                errorProvider1.SetError(txtTitle, null);
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {

                e.Cancel = false;
                errorProvider1.SetError(txtDescription, "Descreption can't be Empty");
            }
            else
                errorProvider1.SetError(txtDescription, null);
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {

                e.Cancel = false;
                errorProvider1.SetError(txtFees, "Descreption can't be Empty");
            }
            else
                errorProvider1.SetError(txtFees, null);
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back) && e.KeyChar != '.';
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                _TestType.TestTitle = txtTitle.Text.Trim();
                _TestType.TestDescription = txtDescription.Text.Trim();
                _TestType.TestFees = Convert.ToSingle(txtFees.Text);

                if(_TestType.Save())
                {
                    MessageBox.Show("Test Details Updated Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else { MessageBox.Show("Error Happend while Updating", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
