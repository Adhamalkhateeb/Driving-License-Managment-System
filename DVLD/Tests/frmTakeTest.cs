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
    public partial class frmTakeTest : Form
    {
        private int _TestAppointmentID;
        private clsTestTypes.enTestType _TestType;

        private clsTest _Test;
        private int _TestID = -1;
        public frmTakeTest(int TestAppointmentID,clsTestTypes.enTestType testType)
        {
            InitializeComponent();
            _TestAppointmentID = TestAppointmentID;
            _TestType  = testType;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure Want to Save results you can't Change Test Result Later", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _Test.TestAppointmentID = _TestAppointmentID;
                _Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                _Test.Notes = txtNotes.Text.Trim();
                _Test.PassedTest = rbPassed.Checked;

               


                if (_Test.Save())
                {
                    MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    ctrlSchedualedTest1.LoadTestInfo(_TestAppointmentID);
                    btnSave.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                return;
        }
           

        private void ctrlSchedualedTest1_Load(object sender, EventArgs e)
        {

        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlSchedualedTest1.TestType = _TestType;
            ctrlSchedualedTest1.LoadTestInfo(_TestAppointmentID);

            if (ctrlSchedualedTest1.TestAppointmentID == -1)
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;

            if (ctrlSchedualedTest1.TestAppointmentInfo.IsLocked)
            {
                lblLockedTest.Visible = true;
                rbFailed.Enabled = false;
                rbPassed.Enabled = false;
                


                _TestID = ctrlSchedualedTest1.TestID;
                _Test = clsTest.FindTestByTestID(_TestID);
                txtNotes.Text = _Test.Notes;

                
                if(_Test.PassedTest)
                    rbPassed.Checked = true;
                else
                    rbFailed.Checked = true;

                
            }
            else
            {
                _Test = new clsTest();
            }


           
        }
    }
}
