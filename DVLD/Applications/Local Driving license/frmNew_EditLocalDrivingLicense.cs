using DataLayer;
using DVLDBussinesLayer;
using DVLDBussinesLibary;
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
    public partial class frmNew_EditLocalDrivingLicense : Form
    {
        private enum enMode { AddNew = 1, Update = 2 }

        private enMode _Mode;
        private int _LocalLicenseApplicationID = -1;
        private int _SelectedPersonID = -1;
        private clsLocalDrivingLicenseApplication _LocalLicenseApplication;
        public frmNew_EditLocalDrivingLicense()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;


        }

        public frmNew_EditLocalDrivingLicense(int LicenseApplicationID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _LocalLicenseApplicationID = LicenseApplicationID;

        }

        private void _FillClassesComboBox()
        {
            DataTable dt = clsLicenseClasses.GetAllClasses();
            foreach (DataRow row in dt.Rows)
            {
                cbLicenseClass.Items.Add(row["ClassName"]);
            }

        }

        private void _ResetDefaultValue()
        {
            _FillClassesComboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "New Local Driving License Application";
                this.Text = lblTitle.Text;
                tabApplicationInfo.Enabled = false;
                _LocalLicenseApplication = new clsLocalDrivingLicenseApplication();
                ctrlPersonCardWithFilter2.FilterFocus();
                btnSave.Enabled = false;

                lblAppDate.Text = DateTime.Now.ToShortDateString();
                lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
                lblAppFees.Text = clsApplicationTypes.Find((int)clsLocalDrivingLicenseApplication.enApplicationType.NewDrivingLicense).Fees.ToString();

            }
            else
            {
                lblTitle.Text = "Update Local Driving License Application";
                this.Text = lblTitle.Text;
                btnSave.Enabled = true;
                tabApplicationInfo.Enabled = true;
            }

        }

        private void _LoadData()
        {

            _LocalLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseID(_LocalLicenseApplicationID);

            if (_LocalLicenseApplication == null)
            {
                MessageBox.Show("No Application Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblAppID.Text = _LocalLicenseApplication.LocalDrivingLicenseAppID.ToString();
            lblAppDate.Text = _LocalLicenseApplication.ApplicationDate.ToShortDateString();
            lblAppFees.Text = _LocalLicenseApplication.PaidFees.ToString();
            lblCreatedBy.Text = _LocalLicenseApplication.CreatedByUser.UserName;
            cbLicenseClass.SelectedIndex = cbLicenseClass.FindString(_LocalLicenseApplication.LicenseClass.ClassName);

            ctrlPersonCardWithFilter2.FilterEnabled = false;
            ctrlPersonCardWithFilter2.LoadPersonInfo(_LocalLicenseApplication.ApplicantPersonID);

        }


        private void DataBackEvent(object sender, int PersonID)
        {
            // Handle the data received
            _SelectedPersonID=PersonID;
            ctrlPersonCardWithFilter2.LoadPersonInfo(PersonID);


        }

        private void frmNewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();

            if (_Mode == enMode.Update)
                _LoadData();

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctrlPersonCardWithFilter2.PersonID == -1 && tabControl1.SelectedIndex != 0)
            {
                MessageBox.Show($@"Please choose Person to Continue or Create new one",
                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter2.FilterFocus();
                tabControl1.SelectedIndex = 0;
                return;
            }

            if (tabControl1.SelectedIndex ==1)
                ctrlPersonCard1.LoadPersonInfo(ctrlPersonCardWithFilter2.PersonID);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                tabApplicationInfo.Enabled = true;
                btnSave.Enabled = true;
                tabControl1.SelectedIndex = 1;
                ctrlPersonCard1.LoadPersonInfo(ctrlPersonCardWithFilter2.PersonID);
                return;
            }

            if (ctrlPersonCardWithFilter2.PersonID != -1)
            {


                btnSave.Enabled = true;
                tabApplicationInfo.Enabled = true;
                ctrlPersonCard1.LoadPersonInfo(ctrlPersonCardWithFilter2.PersonID);
                tabControl1.SelectedIndex =1;


            }
            else
            {
                MessageBox.Show($@"Please choose Person to Continue or Create new one",
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectedIndex = 0;
                ctrlPersonCardWithFilter2.FilterFocus();

            }
        }

        private void cbLicenseClass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbLicenseClass.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(cbLicenseClass, "Please Choose License Class");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbLicenseClass, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
               clsLicenseClasses LicenseClass= clsLicenseClasses.Find(cbLicenseClass.Text);
                int ActiveApplicationID = clsApplication.GetActiveApplicationIDForLicenseClass(_SelectedPersonID, clsApplication.enApplicationType.NewDrivingLicense, LicenseClass.LicenseClassID);

                if (ActiveApplicationID != -1)
                {
                    MessageBox.Show($"Choose another License Class, Person Already have  Application for the Selected Class with ID [{ActiveApplicationID}]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (clsDriverLicense.IsLicenseExistByPersonID(ctrlPersonCardWithFilter2.PersonID, LicenseClass.LicenseClassID))
                {

                    MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _LocalLicenseApplication.ApplicationTypeID = (int)clsLocalDrivingLicenseApplication.enApplicationType.NewDrivingLicense;
                _LocalLicenseApplication.LicenseClassID = LicenseClass.LicenseClassID;
                _LocalLicenseApplication.ApplicationDate = DateTime.Now;
                _LocalLicenseApplication.ApplicationStatus = clsLocalDrivingLicenseApplication.enApplicationStatus.New;
                _LocalLicenseApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                _LocalLicenseApplication.PaidFees = clsApplicationTypes.Find((int)clsLocalDrivingLicenseApplication.enApplicationType.NewDrivingLicense).Fees;
                _LocalLicenseApplication.LastStatusDate = DateTime.Now;
                _LocalLicenseApplication.ApplicantPersonID = ctrlPersonCardWithFilter2.PersonID;


                TimeSpan time = DateTime.Now - ctrlPersonCardWithFilter2.SelectedPersonInfo.DateOFBirth;

                if (LicenseClass.MinimumAllowedAge > time.TotalDays / 365.25)
                {
                    MessageBox.Show($"Person is not allowed for this Driving License Class, it requires a {LicenseClass.MinimumAllowedAge} years old and above", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (_LocalLicenseApplication.Save())
                {
                    lblAppID.Text = _LocalLicenseApplication.LocalDrivingLicenseAppID.ToString();
                    lblTitle.Text = "Update Local Driving License Application";
                    this.Text = lblTitle.Text;
                    MessageBox.Show("Application Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblAppID.Text = _LocalLicenseApplication.LocalDrivingLicenseAppID.ToString();
                }
                else
                {
                    MessageBox.Show("Error Saving Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ctrlPersonCardWithFilter2_OnPersonSelected(int obj)
        {
            _SelectedPersonID = obj;
        }
    }
}
