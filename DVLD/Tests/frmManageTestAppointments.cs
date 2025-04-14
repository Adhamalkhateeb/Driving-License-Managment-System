using DVLD.Properties;
using DVLDBussinesLibary;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLDBussinesLibary.clsTestTypes;

namespace DVLD
{
    public partial class frmManageTestAppointments : Form
    {
        private clsTestTypes.enTestType _TestType;
        private DataTable _dtAllTestAppointments = new DataTable();
        private int _LocalDrivingApplicationID = -1;

        public frmManageTestAppointments(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestType TestTypeID)
        {
            InitializeComponent();
            _LocalDrivingApplicationID = LocalDrivingLicenseApplicationID;
            _TestType = TestTypeID;

        }


        private void _LoadTestTypeImageAndTitle()
        {
            switch (_TestType)
            {

                case clsTestTypes.enTestType.VisionTest:
                    {
                        lblTitle.Text = "Vision Test Appointments";
                        this.Text= lblTitle.Text;
                        pbManageTests.Image = Resources.Vision_512;
                        break;
                    }

                case clsTestTypes.enTestType.WrittenTest:
                    {
                        lblTitle.Text = "Written Test Appointments";
                        this.Text = lblTitle.Text;
                        pbManageTests.Image = Resources.Written_Test_512;
                        break;
                    }
                case clsTestTypes.enTestType.PracticalTest:
                    {
                        lblTitle.Text = "Street Test Appointments";
                        this.Text = lblTitle.Text;
                        pbManageTests.Image = Resources.driving_test_512;
                        break;
                    }
            }
        }


        private void frmManageTestAppointments_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImageAndTitle();

            ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingApplicationID);

            _dtAllTestAppointments = clsTestAppointments.GetAllTestAppointmentByLocalDrivingLicenseAppAndTestTypeID(_LocalDrivingApplicationID, (int)_TestType);
            dgvTestAppointments.DataSource = _dtAllTestAppointments;
            lblCount.Text = "# Records " + dgvTestAppointments.Rows.Count;

            

            if (dgvTestAppointments.RowCount > 0)
            {
                dgvTestAppointments.Columns[0].HeaderText = "Test Appointment ID";
                dgvTestAppointments.Columns[0].Width = 290;
                dgvTestAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvTestAppointments.Columns[1].Width = 240;
                dgvTestAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvTestAppointments.Columns[2].Width = 190;
                dgvTestAppointments.Columns[3].HeaderText = "Is Locked";
                dgvTestAppointments.Columns[3].Width = 200;

            }

           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (clsLocalDrivingLicenseApplication.IsThereAnActiveScheduledTest(_LocalDrivingApplicationID,(int) _TestType))
            {
                MessageBox.Show("Person Already has appointment for this Test, You can't add new appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(clsLocalDrivingLicenseApplication.DoesPassTest(_LocalDrivingApplicationID,(int)_TestType))
            {
                MessageBox.Show("this Person Already Passed the Test Before, You can Retake Failed Tests only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            frmSchedualTest schedualTest = new frmSchedualTest(_LocalDrivingApplicationID,_TestType);
            schedualTest.ShowDialog();

            frmManageTestAppointments_Load(null, null);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
          

            frmSchedualTest frmSchedualTest = new frmSchedualTest(_LocalDrivingApplicationID,_TestType,(int)dgvTestAppointments.CurrentRow.Cells[0].Value);
            frmSchedualTest.ShowDialog();

            frmManageTestAppointments_Load(null, null);

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
            frmTakeTest frmTakeTest = new frmTakeTest((int)dgvTestAppointments.CurrentRow.Cells[0].Value,_TestType);
            frmTakeTest.ShowDialog();

            frmManageTestAppointments_Load(null, null);
        }
    }
}
