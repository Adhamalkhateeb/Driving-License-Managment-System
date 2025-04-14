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
    public partial class frmSchedualTest : Form
    {

        private int _localDrivingLicenseApplicationID = -1;
        private clsTestTypes.enTestType _testType = clsTestTypes.enTestType.VisionTest;
        private int _AppointmentID = -1;

        public frmSchedualTest(int LocalDrivingLicenseAppID,clsTestTypes.enTestType testType, int AppointmentID = -1)
        {
            _localDrivingLicenseApplicationID = LocalDrivingLicenseAppID;
            _testType = testType;
            _AppointmentID = AppointmentID;
            InitializeComponent();
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSchedualTest_Load(object sender, EventArgs e)
        {
            ctrlScheduleTest1.TestType = _testType;
            ctrlScheduleTest1.LoadTestAppointmentInfo(_localDrivingLicenseApplicationID, _AppointmentID);
        }

        private void ctrlScheduleTest1_Load(object sender, EventArgs e)
        {
             
        }
    }
}
