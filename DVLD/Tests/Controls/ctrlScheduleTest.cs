using DVLD.Properties;
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
using static DVLDBussinesLibary.clsTestTypes;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class ctrlScheduleTest : UserControl
    {
        public enum enMode { AddNew = 1, Update = 2}
        private enMode _Mode = enMode.AddNew;
        public enum enCreationMode { FirstTimeSchedule = 0, RetakeTestSchedule = 1 };
        private enCreationMode _CreationMode = enCreationMode.FirstTimeSchedule;

        private clsTestTypes.enTestType _TestTypeID = clsTestTypes.enTestType.VisionTest;

        private int _LocalDrivingLicenseApplicationID = -1;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        private clsTestAppointments _testAppointment;
        private int _TestAppointmentID = -1;

        public clsTestTypes.enTestType TestType
        {
            get
            {
                return _TestTypeID;
            }
            set
            {
                _TestTypeID = value;

                switch (_TestTypeID)
                {

                    case clsTestTypes.enTestType.VisionTest:
                        {
                            gbSchedualTest.Text = "Vision Test";
                            pbTitleImage.Image = Resources.Vision_512;
                            break;
                        }

                    case clsTestTypes.enTestType.WrittenTest:
                        {
                            gbSchedualTest.Text = "Written Test";
                            pbTitleImage.Image = Resources.Written_Test_512;
                            break;
                        }
                    case clsTestTypes.enTestType.PracticalTest:
                        {
                            gbSchedualTest.Text = "Street Test";
                            pbTitleImage.Image = Resources.driving_test_512;
                            break;


                        }
                }
            }
        }
        private bool _HandleActiveTestAppointmentConstraint()
        {
            if (_Mode == enMode.AddNew && clsLocalDrivingLicenseApplication.IsThereAnActiveScheduledTest(_LocalDrivingLicenseApplicationID,(int)_TestTypeID))
            {
                lblLockedTest.Text = "Person Already have an active appointment for this test";
                lblLockedTest.Visible = true;
                btnSave.Enabled = false;
                AppointmentDate.Enabled = false;
                return false;
            }

            return true;
        }

        private bool _HandleAppointmentLockedConstraint()
        {
            
            if (_testAppointment.IsLocked)
            {
                lblLockedTest.Visible = true;
                lblLockedTest.Text = "Person already sat for the test, appointment loacked.";
                AppointmentDate.Enabled = false;
                btnSave.Enabled = false;
                return false;

            }
            else
                lblLockedTest.Visible = false;

            return true;
        }

        private bool _HandlePrviousTestConstraint()
        {
 

            switch (TestType)
            {
                case clsTestTypes.enTestType.VisionTest:
                    lblLockedTest.Visible = false;

                    return true;

                case clsTestTypes.enTestType.WrittenTest:
                    if (!_LocalDrivingLicenseApplication.DoesPassTest((int)clsTestTypes.enTestType.VisionTest))
                    {
                        lblLockedTest.Text = "Cannot Sechule, Vision Test should be passed first";
                        lblLockedTest.Visible = true;
                        btnSave.Enabled = false;
                        AppointmentDate.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblLockedTest.Visible = false;
                        btnSave.Enabled = true;
                        AppointmentDate.Enabled = true;
                    }
                    return true;

                case clsTestTypes.enTestType.PracticalTest:

                    if (!_LocalDrivingLicenseApplication.DoesPassTest((int)clsTestTypes.enTestType.WrittenTest))
                    {
                        lblLockedTest.Text = "Cannot Sechule, Written Test should be passed first";
                        lblLockedTest.Visible = true;
                        btnSave.Enabled = false;
                        AppointmentDate.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblLockedTest.Visible = false;
                        btnSave.Enabled = true;
                        AppointmentDate.Enabled = true;
                    }


                    return true;

            }
            return true;

        }

        public void LoadTestAppointmentInfo(int LocalDrivingLicenseAppID, int AppointmentID = -1)
        {

            if (AppointmentID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;


            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseAppID;
            _TestAppointmentID = AppointmentID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseID(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show($"No Driving License Application With ID Number {_LocalDrivingLicenseApplicationID} is Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            if (_LocalDrivingLicenseApplication.DoesAttendTest((int)_TestTypeID))

                _CreationMode = enCreationMode.RetakeTestSchedule;
            else
                _CreationMode = enCreationMode.FirstTimeSchedule;



            if (_CreationMode == enCreationMode.RetakeTestSchedule)
            {
                lblTestTitle.Text = "Schedule Retake Test";
                lblTestTitle.Left = (this.Width - lblTestTitle.Width) / 2;
                gbRetakeTest.Enabled = true;
                float RetakeFees = clsApplicationTypes.Find((int)clsApplication.enApplicationType.RetakeTest).Fees;
                lblRetakeAppFees.Text =  RetakeFees.ToString("0.000");
               
            }
            else
            {
                gbRetakeTest.Enabled = false;
                lblTestTitle.Text = "Schedule Test";
                lblRetakeAppFees.Text = "0";
                lblRetakeAppID.Text = "N/A";
            }

            lblDrivingLicenseAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseAppID.ToString();
            lblDrivingLicenseClass.Text = _LocalDrivingLicenseApplication.LicenseClass.ClassName;
            lblName.Text = _LocalDrivingLicenseApplication.ApplicantFullName;
            lblTrial.Text = _LocalDrivingLicenseApplication.TotalTrialsPerTest((int)_TestTypeID).ToString();
           



            if (_Mode==enMode.AddNew)
            {
                lblFees.Text = clsTestTypes.Find((int)_TestTypeID).TestFees.ToString("0.000");
                AppointmentDate.MinDate = DateTime.Now;
                lblRetakeAppID.Text = "N/A";

                _testAppointment = new clsTestAppointments();
            }
            else
            {

                if (!_LoadTestAppointmentData())
                    return;
            }

            lblTotalFees.Text= (Convert.ToSingle(lblFees.Text) + Convert.ToSingle(lblRetakeAppFees.Text)).ToString("0.000");

            if (!_HandleActiveTestAppointmentConstraint())

                return;

            if (!_HandleAppointmentLockedConstraint())
                return;

            if (!_HandlePrviousTestConstraint())
                return;



        }

        private bool _LoadTestAppointmentData()
        {
            _testAppointment = clsTestAppointments.FindByTestAppointmentID(_TestAppointmentID);

            if (_testAppointment == null)
            {
                MessageBox.Show($"Error: No Appointment with ID [{_TestAppointmentID}]",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;
            }

            lblFees.Text = _testAppointment.PaidFees.ToString();

            
            if (DateTime.Compare(DateTime.Now, _testAppointment.AppointmentDate) < 0)
                AppointmentDate.MinDate = DateTime.Now;
            else
                AppointmentDate.MinDate = _testAppointment.AppointmentDate;

            AppointmentDate.Value = _testAppointment.AppointmentDate;

            
            if (_testAppointment.RetakeTestApplicationID == -1)
            {
                lblRetakeAppFees.Text = "0";
                lblRetakeAppID.Text = "N/A";
            }
            else
            {
                lblRetakeAppFees.Text = _testAppointment.RetakeTestApplication.PaidFees.ToString();
                gbRetakeTest.Enabled = true;
                lblTestTitle.Text = "Schedule Retake Test";
                lblTestTitle.Location = new Point(117, 143);
                lblRetakeAppID.Text = _testAppointment.RetakeTestApplicationID.ToString();

            }
            return true;
        }

        private bool _HandleRetakeApplication()
        {
            if (_Mode == enMode.AddNew && _CreationMode == enCreationMode.RetakeTestSchedule)
            {
                clsApplication Application = new clsApplication();

                Application.ApplicantPersonID = _LocalDrivingLicenseApplication.ApplicantPersonID;
                Application.ApplicationDate = DateTime.Now;
                Application.ApplicationTypeID = (int)clsApplication.enApplicationType.RetakeTest;
                Application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
                Application.LastStatusDate = DateTime.Now;
                Application.PaidFees = clsApplicationTypes.Find((int)clsApplication.enApplicationType.RetakeTest).Fees;
                Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                if (!Application.Save())
                {
                    _testAppointment.RetakeTestApplicationID = -1;
                    MessageBox.Show("Faild to Create application", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                _testAppointment.RetakeTestApplicationID = Application.ApplicationID;

            }
            return true;
        }

        public ctrlScheduleTest()
        {
            InitializeComponent();
            string.Format("dd/MM/yyyy - HH/mm/ss", AppointmentDate.Format);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!_HandleRetakeApplication())
                return;

            _testAppointment.TestTypeID = (int)_TestTypeID;
            _testAppointment.LocalDrivingLicensesID = _LocalDrivingLicenseApplicationID;
            _testAppointment.AppointmentDate = AppointmentDate.Value;
            _testAppointment.PaidFees = Convert.ToSingle(lblTotalFees.Text);
            _testAppointment.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_testAppointment.Save())
            {
                _Mode = enMode.Update;
                _TestAppointmentID = _testAppointment.TestAppointmentID;
                MessageBox.Show("Test Appointment is Scheduled Successfully", "Test Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblRetakeAppID.Text = _testAppointment.RetakeTestApplicationID.ToString();

            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
