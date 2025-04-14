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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class ctrlSchedualedTest : UserControl
    {
        private int _TestAppointmentID = -1;
        private clsTestAppointments _TestAppointmentInfo;
        private clsTestTypes.enTestType _TestType = clsTestTypes.enTestType.VisionTest;

        private int _TestID;

        public int TestID { get { return _TestID; } }

        public clsTestTypes.enTestType TestType
        {

            get { return _TestType; }
            set
            {
                _TestType = value;

                switch (_TestType)
                {
                    case clsTestTypes.enTestType.VisionTest:
                        gbSchedualTest.Text = "Vision Test";
                        pbTitleImage.Image = Properties.Resources.Vision_512;
                        break;
                    case clsTestTypes.enTestType.WrittenTest:
                        gbSchedualTest.Text = "Written Test";
                        pbTitleImage.Image = Properties.Resources.Written_Test_512;
                        break;
                    case clsTestTypes.enTestType.PracticalTest:
                        gbSchedualTest.Text = "Driving Test";
                        pbTitleImage.Image = Properties.Resources.driving_test_512;
                        break;

                }
            }

        }

        public int TestAppointmentID
        {
            get
            {
                return _TestAppointmentID;
            }
        }

        public clsTestAppointments TestAppointmentInfo
        {
            get { return _TestAppointmentInfo; }
        }


        public ctrlSchedualedTest()
        {
            InitializeComponent();
            string.Format("dd/MM/yyyy - HH/mm/ss", AppointmentDate.Format);
        }


        public void LoadTestInfo(int TestAppointmentID)
        {

            _TestAppointmentID = TestAppointmentID;
            _TestAppointmentInfo = clsTestAppointments.FindByTestAppointmentID(_TestAppointmentID);
            _TestType = (clsTestTypes.enTestType)_TestAppointmentInfo.TestTypeID;
            TestType = _TestType;


            if (_TestAppointmentInfo == null)
            {
                MessageBox.Show($"No Appointment available With ID Number {_TestAppointmentID} is Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _TestID  = _TestAppointmentInfo.TestID;

            lblDrivingLicenseAppID.Text =_TestAppointmentInfo.LocalDrivingLicensesID.ToString();
            lblDrivingLicenseClass.Text = _TestAppointmentInfo.localDrivingLicenseApplicationInfo.LicenseClass.ClassName;
            lblName.Text = _TestAppointmentInfo.localDrivingLicenseApplicationInfo.ApplicantFullName;
            lblTrial.Text = clsLocalDrivingLicenseApplication.TotalTrialsPerTest(_TestAppointmentInfo.LocalDrivingLicensesID, (int)TestType).ToString();
            lblFees.Text = _TestAppointmentInfo.PaidFees.ToString("0.000");
            AppointmentDate.Value = _TestAppointmentInfo.AppointmentDate;
            AppointmentDate.Enabled = false;

            lblTestID.Text = (_TestAppointmentInfo.TestID == -1) ? "Not Taken Yet" : _TestAppointmentInfo.TestID.ToString();
        }

        private void gbSchedualTest_Enter(object sender, EventArgs e)
        {

        }
    }
}
